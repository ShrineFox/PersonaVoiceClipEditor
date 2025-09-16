using System;
using System.IO;
using System.Linq;
using System.Reflection;
using VGAudio.Containers.Adx;
using VGAudio.Formats;
using VGAudio.Formats.Pcm16;

namespace PersonaVCE
{
    public static class AudioExtensions
    {
        public static MemoryStream AdjustAdxVolumeInMemory(string adxPath, double volumeFactor)
        {
            // Step 1: Read ADX into AudioData
            var reader = new AdxReader();
            AudioData audioData = reader.Read(File.ReadAllBytes(adxPath));

            // Step 2: Convert to PCM16 for editing
            var pcm = audioData.GetFormat<Pcm16Format>();

            // Step 3: Adjust samples (per channel)
            short[][] samples = pcm.Channels;
            for (int ch = 0; ch < samples.Length; ch++)
            {
                var arr = samples[ch];
                for (int i = 0; i < arr.Length; i++)
                {
                    int scaled = (int)Math.Round(arr[i] * volumeFactor);

                    // Hard clip to Int16 range
                    if (scaled > short.MaxValue) scaled = short.MaxValue;
                    if (scaled < short.MinValue) scaled = short.MinValue;

                    arr[i] = (short)scaled;
                }
            }

            // Step 4: Convert back to AudioData
            var adjustedAudioData = new AudioData(pcm);

            // Step 5: Encode back to ADX into a MemoryStream
            var memoryStream = new MemoryStream();
            var writer = new AdxWriter();
            writer.WriteToStream(adjustedAudioData, memoryStream);

            // Reset position so it's ready for reading elsewhere
            memoryStream.Position = 0;

            return memoryStream;
        }

        public static Pcm16Format LoadAndAdjustVolume(string adxPath, double volumeFactor)
        {
            // Step 1: Read ADX into an AudioData container
            var reader = new AdxReader();
            AudioData audioData = reader.Read(File.ReadAllBytes(adxPath));

            // Step 2: Convert to PCM16
            var pcm = audioData.GetFormat<Pcm16Format>();

            // Step 3: Get the per-channel samples
            short[][] samples = pcm.Channels;

            // Step 4: Scale and hard clip
            for (int ch = 0; ch < samples.Length; ch++)
            {
                var arr = samples[ch];
                for (int i = 0; i < arr.Length; i++)
                {
                    int scaled = (int)Math.Round(arr[i] * volumeFactor);

                    // Hard clip manually
                    if (scaled > short.MaxValue) scaled = short.MaxValue;
                    if (scaled < short.MinValue) scaled = short.MinValue;

                    arr[i] = (short)scaled;
                }
            }

            return pcm; // modified in-memory PCM16 samples
        }

        public static void ScaleVolumeInPlace(object audioFormat, double volumeFactor)
        {
            if (audioFormat == null) throw new ArgumentNullException(nameof(audioFormat));
            if (double.IsNaN(volumeFactor) || double.IsInfinity(volumeFactor)) throw new ArgumentOutOfRangeException(nameof(volumeFactor));

            var t = audioFormat.GetType();

            // Helper to clamp int -> short range safely
            short ClampToInt16(int v) => v > short.MaxValue ? short.MaxValue : (v < short.MinValue ? short.MinValue : (short)v);

            // 1) short[][] (deinterleaved per-channel) - common representation
            var short2Prop = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                              .FirstOrDefault(p => p.PropertyType == typeof(short[][]));
            if (short2Prop != null)
            {
                var channels = (short[][])short2Prop.GetValue(audioFormat);
                for (int ch = 0; ch < channels.Length; ch++)
                {
                    var arr = channels[ch];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        //arr[i] = ClampToInt16((int)Math.Round(arr[i] * volumeFactor));
                        // hard clipping:
                        /*
                        arr[i] = (short)Math.Clamp(
                            (int)Math.Round(arr[i] * volumeFactor),
                            short.MinValue,
                            short.MaxValue
                        );
                        */
                        arr[i] = ClampToInt16((int)Math.Round(arr[i] * volumeFactor));

                    }
                }
                return;
            }

            // 2) short[] (interleaved 16-bit samples)
            var short1Prop = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                              .FirstOrDefault(p => p.PropertyType == typeof(short[]));
            if (short1Prop != null)
            {
                var samples = (short[])short1Prop.GetValue(audioFormat);
                for (int i = 0; i < samples.Length; i++)
                {
                    samples[i] = ClampToInt16((int)Math.Round(samples[i] * volumeFactor));
                }
                return;
            }

            // 3) float[][] (deinterleaved floats, e.g. normalized -1..1)
            var float2Prop = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                              .FirstOrDefault(p => p.PropertyType == typeof(float[][]));
            if (float2Prop != null)
            {
                var channels = (float[][])float2Prop.GetValue(audioFormat);
                for (int ch = 0; ch < channels.Length; ch++)
                {
                    var arr = channels[ch];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = arr[i] * (float)volumeFactor;
                    }
                }
                return;
            }

            // 4) float[] (interleaved floats)
            var float1Prop = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                              .FirstOrDefault(p => p.PropertyType == typeof(float[]));
            if (float1Prop != null)
            {
                var samples = (float[])float1Prop.GetValue(audioFormat);
                for (int i = 0; i < samples.Length; i++)
                {
                    samples[i] = samples[i] * (float)volumeFactor;
                }
                return;
            }

            // 5) byte[] (raw bytes — assume little-endian PCM16)
            var bytesProp = t.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                             .FirstOrDefault(p => p.PropertyType == typeof(byte[]));
            if (bytesProp != null)
            {
                var data = (byte[])bytesProp.GetValue(audioFormat);
                // process little-endian 16-bit signed samples
                for (int i = 0; i + 1 < data.Length; i += 2)
                {
                    short s = (short)(data[i] | (data[i + 1] << 8));
                    int scaled = (int)Math.Round(s * volumeFactor);
                    short outS = ClampToInt16(scaled);
                    data[i] = (byte)(outS & 0xFF);
                    data[i + 1] = (byte)((outS >> 8) & 0xFF);
                }
                return;
            }

            // 6) Fallback: look for fields (not properties) with matching types
            var short2Field = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                               .FirstOrDefault(f => f.FieldType == typeof(short[][]));
            if (short2Field != null)
            {
                var channels = (short[][])short2Field.GetValue(audioFormat);
                for (int ch = 0; ch < channels.Length; ch++)
                {
                    var arr = channels[ch];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        //arr[i] = ClampToInt16((int)Math.Round(arr[i] * volumeFactor));
                        arr[i] = ClampToInt16((int)Math.Round(arr[i] * volumeFactor));
                    }
                }
                return;
            }

            // If we get here the helper could not find sample storage
            var typeName = t.FullName ?? t.Name;
            throw new InvalidOperationException($"Couldn't find sample storage on VGAudio type '{typeName}'. " +
                "Inspect properties/fields of the object to see where samples are stored (short[][], short[], float[][], float[], or byte[]).");
        }

        static short ClampToInt16(int v)
        {
            if (v > short.MaxValue) return short.MaxValue;
            if (v < short.MinValue) return short.MinValue;
            return (short)v;
        }
    }
}