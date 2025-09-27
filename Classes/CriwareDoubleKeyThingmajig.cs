using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// code by DeathChaos25
namespace PersonaVCE
{
    public class CriwareDoubleKeyThingmajig
    {
        public static void Main(byte[] globalKey, string acbDir)
        {
            ulong keyCode = BitConverter.ToUInt64(globalKey, 0);
            ulong keyCodeBE = SwapEndianness(keyCode);
            ushort awbHash = BitConverter.ToUInt16(File.ReadAllBytes(Path.Combine(acbDir, ".subkey")), 0);
            ushort awbHashBE = SwapEndianness(awbHash);

            ulong acbKey = keyCodeBE * (((ulong)awbHash << 16) | (ulong)((ushort)~awbHash + 2));

            File.WriteAllBytes(Path.Combine(acbDir, ".hcakey"), BitConverter.GetBytes(SwapEndianness(acbKey)));

            List<string> strings = new List<string>();

            strings.Add($"keyCode is 0x{keyCodeBE:X8} - {keyCodeBE}");
            strings.Add($"awbHash is 0x{awbHash:X4} - {awbHash}");
            strings.Add($"acbKey is 0x{acbKey:X16} - {acbKey}");
            File.WriteAllLines(Path.Combine(acbDir, "keys.txt"), strings);
        }

        static ushort SwapEndianness(ushort value)
        {
            return (ushort)((value >> 8) | (value << 8));
        }

        public static ulong SwapEndianness(ulong value)
        {
            return ((value & 0x00000000000000FFUL) << 56) |
                   ((value & 0x000000000000FF00UL) << 40) |
                   ((value & 0x0000000000FF0000UL) << 24) |
                   ((value & 0x00000000FF000000UL) << 8) |
                   ((value & 0x000000FF00000000UL) >> 8) |
                   ((value & 0x0000FF0000000000UL) >> 24) |
                   ((value & 0x00FF000000000000UL) >> 40) |
                   ((value & 0xFF00000000000000UL) >> 56);
        }
    }
}
