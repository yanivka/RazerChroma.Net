using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Custom
    {
        public uint Size;
        public uint Param;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxRow * Definitions.MaxCol))]
        public NativeWin32.ColorRef[][] Color;

        public Custom(uint size, uint param, NativeWin32.ColorRef[][] color)
        {
            Size = size;
            Param = param;
            Color = color;
        }
    }
}
