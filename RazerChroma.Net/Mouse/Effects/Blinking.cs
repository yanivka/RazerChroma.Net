using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Blinking
    {
        public Definitions.RzLed LedId;
        public NativeWin32.ColorRef Color;

        public Blinking(Definitions.RzLed ledId, NativeWin32.ColorRef color)
        {
            LedId = ledId;
            Color = color;
        }
    }
}