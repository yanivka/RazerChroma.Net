using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Breathing
    {

        public enum _Type
        {
            OneColor = 1,
            TwoColors,
            RandomColors
        }

        public uint Size;
        public uint Param;
        public _Type Type;
        public NativeWin32.ColorRef Color1;
        public NativeWin32.ColorRef Color2;

        public Breathing(uint size, uint param, _Type type, NativeWin32.ColorRef color1, NativeWin32.ColorRef color2)
        {
            Size = size;
            Param = param;
            Type = type;
            Color1 = color1;
            Color2 = color2;
        }
    }

}
