using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.KeyPad.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Reactive
    {
        public enum _Duration
        {
            None = 0,
            Short,
            Medium,
            Long,
            Invalid
        }
        public _Duration Duration;

        public NativeWin32.ColorRef Color;

        public Reactive(_Duration duration, NativeWin32.ColorRef color)
        {
            Duration = duration;
            Color = color;
        }
    }
}