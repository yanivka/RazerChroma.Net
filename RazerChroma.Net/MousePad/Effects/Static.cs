using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.MousePad.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Static
        {
            public NativeWin32.ColorRef Color;

        public Static(NativeWin32.ColorRef color)
        {
            Color = color;
        }
    }
}