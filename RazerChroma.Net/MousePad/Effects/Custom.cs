using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.MousePad.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Custom
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxLeds))]
        public NativeWin32.ColorRef[] Color;

        public Custom(NativeWin32.ColorRef[] color)
        {
            Color = color;
        }
    }
}