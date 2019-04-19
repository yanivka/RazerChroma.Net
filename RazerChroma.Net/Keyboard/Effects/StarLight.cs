using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Keyboard.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct StarLight
    {
        public enum _Duration
        {
            Short = 1,
            Medium,
            Long
        }
        public enum _Type
        {
            TwoColors = 1,
            RandomColors
        }
        public _Type Type;
        NativeWin32.ColorRef Color1;
        NativeWin32.ColorRef Color2;
        public _Duration Duration;

        public StarLight(_Type type, NativeWin32.ColorRef color1, NativeWin32.ColorRef color2, _Duration duration)
        {
            Type = type;
            Color1 = color1;
            Color2 = color2;
            Duration = duration;
        }
    }
}