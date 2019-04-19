using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Static
    {
        public Definitions.RzLed LEDId;
        public NativeWin32.ColorRef Color;

        public Static(Definitions.RzLed lEDId, NativeWin32.ColorRef color)
        {
            LEDId = lEDId;
            Color = color;
        }
    }
}