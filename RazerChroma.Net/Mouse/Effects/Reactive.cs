using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Reactive
    {
        public enum _Duration
        {
            None = 0,
            Short,
            Medium,
            Long
        }
        public Definitions.RzLed LEDId;
        public _Duration Duration;
        public NativeWin32.ColorRef Color;

        public Reactive(Definitions.RzLed lEDId, _Duration duration, NativeWin32.ColorRef color)
        {
            LEDId = lEDId;
            Duration = duration;
            Color = color;
        }
    }
}