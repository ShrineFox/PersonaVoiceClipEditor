using NAudio.Wave;
using ShrineFox.IO;
using System;
using System.IO;

// How stuff was done before using mainly VGAudio and NAudio
namespace PersonaVCE.Classes
{
    internal class UnusedADXHelpers
    {
        private Tuple<int, int> GetADXLoopPoints(string file)
        {
            Tuple<int, int> loopPoints = new Tuple<int, int>(0, 0);

            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                using (EndianBinaryReader reader = new EndianBinaryReader(fs, Endianness.BigEndian))
                {
                    reader.BaseStream.Position = 34;

                    if (reader.ReadByte() == Convert.ToByte(0)
                        && reader.ReadByte() == Convert.ToByte(1))
                    {
                        reader.BaseStream.Position = 40;
                        var startSample = reader.ReadInt32();

                        reader.BaseStream.Position = 48;
                        var endSample = reader.ReadInt32();

                        loopPoints = new Tuple<int, int>(startSample, endSample);
                    }
                }
            }

            return loopPoints;
        }

        private bool CheckADXEncryption(string file)
        {
            if (Path.GetExtension(file).ToLower() == ".wav")
                return false;

            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    reader.BaseStream.Position = 19;

                    if (reader.ReadByte() == Convert.ToByte(9))
                        return true;

                    return false;
                }
            }
        }

        private void SetADXEncryptionFlag(string outPath, bool encryptType9 = true)
        {
            using (FileStream fs = new FileStream(outPath, FileMode.Open))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    // Add encryption flag to adx file if using keycode
                    writer.BaseStream.Position = 19;
                    byte newByte = Convert.ToByte(9);
                    // Remove encryption flag if decrypting
                    if (!encryptType9)
                        newByte = Convert.ToByte(0);
                    Output.VerboseLog($"[INFO] Setting encryption byte to: {newByte.ToString("x2")}");
                    writer.Write(newByte);
                }
                ;
            }
        }

        private long GetSampleCount(string file)
        {
            long sampleCount = -1;

            if (File.Exists(file))
            {
                if (Path.GetExtension(file).ToLower() == ".adx")
                    using (FileStream fs = new FileStream(file, FileMode.Open))
                    {
                        using (EndianBinaryReader reader = new EndianBinaryReader(fs, Endianness.LittleEndian))
                        {
                            reader.BaseStream.Position = 12;
                            sampleCount = reader.ReadInt32();
                        }
                    }
                else if (Path.GetExtension(file).ToLower() == ".wav")
                {
                    using (var waveFile = new WaveFileReader(file))
                    {
                        sampleCount = waveFile.SampleCount;
                    }
                }
            }

            return sampleCount;
        }

        private static int Clamp(int value, int min, int max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        public static bool ChangeVolume(string inputFilePath, string outputFilePath, float volumeFactor)
        {
            if (volumeFactor < 0)
            {
                Output.Log($"[ERROR] Volume change failed, volume factor must be a non-negative number.", ConsoleColor.Red);
                return false;
            }

            using (var inputFile = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            using (var outputFile = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
            using (var reader = new BinaryReader(inputFile))
            using (var writer = new BinaryWriter(outputFile))
            {
                // Read WAV header (first 44 bytes)
                byte[] header = reader.ReadBytes(44);
                writer.Write(header);

                // Determine bit depth from header (e.g., 16-bit, 24-bit, etc.)
                int bitsPerSample = BitConverter.ToInt16(header, 34);
                int bytesPerSample = bitsPerSample / 8;

                if (bytesPerSample != 2)
                {
                    Output.Log($"[ERROR] Volume change failed, only 16-bit PCM WAV files are supported..", ConsoleColor.Red);
                    return false;
                }

                // Process audio data
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    // Read a sample (16-bit signed integer)
                    short sample = reader.ReadInt16();

                    // Adjust the sample by the volume factor
                    int newSample = (int)(sample * volumeFactor);

                    // Clamp to avoid overflow
                    newSample = Clamp(newSample, short.MinValue, short.MaxValue);

                    // Write the adjusted sample
                    writer.Write((short)newSample);
                }
            }

            if (File.Exists(outputFilePath))
            {
                Output.Log($"[INFO] Volume change succeeded: \"{outputFilePath}\"", ConsoleColor.Green);
                return true;
            }

            return false;
        }
    }
}
