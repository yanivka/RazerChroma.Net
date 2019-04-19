using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Keyboard.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Custom
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxRow * Definitions.MaxCol))]
        public NativeWin32.ColorRef[][] Color;

        public Custom(NativeWin32.ColorRef[][] color)
        {
            Color = color;
        }
    }
}