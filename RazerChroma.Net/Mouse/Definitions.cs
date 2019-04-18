using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse
{
    public static class Definitions
    {
        public const uint MaxLeds = 30;
        //public const public NativeWin32.ColorRef public RzLed_LAYOUT[MAX_LEDS] = { };
        public const uint MaxRow = 9;
        public const uint MaxCol = 7;
        public const uint MaxLed2 = MaxRow * MaxCol;
        //public const public NativeWin32.ColorRef public RzLed_LAYOUT2[MAX_ROW][MAX_COLUMN] = {};
        public enum RzLed
        {
            None = 0,
            Scrollwheel = 1,
            Logo = 2,
            Backlight = 3,
            Side_strip1 = 4,
            Side_strip2 = 5,
            Side_strip3 = 6,
            Side_strip4 = 7,
            Side_strip5 = 8,
            Side_strip6 = 9,
            Side_strip7 = 10,
            Side_strip8 = 11,
            Side_strip9 = 12,
            Side_strip10 = 13,
            Side_strip11 = 14,
            Side_strip12 = 15,
            Side_strip13 = 16,
            Side_strip14 = 17,
            All = 0xffff
        }
        public enum RzLed2
        {
            Scrollwheel = 0x0203,
            Logo = 0x0703,
            Backlight = 0x0403,
            Left_side1 = 0x0100,
            Left_side2 = 0x0200,
            Left_side3 = 0x0300,
            Left_side4 = 0x0400,
            Left_side5 = 0x0500,
            Left_side6 = 0x0600,
            Left_side7 = 0x0700,
            Bottom1 = 0x0801,
            Bottom2 = 0x0802,
            Bottom3 = 0x0803,
            Bottom4 = 0x0804,
            Bottom5 = 0x0805,
            Right_side1 = 0x0106,
            Right_side2 = 0x0206,
            Right_side3 = 0x0306,
            Right_side4 = 0x0406,
            Right_side5 = 0x0506,
            Right_side6 = 0x0606,
            Right_side7 = 0x0706
        }

        public enum EffectType
        {
            None = 0,
            Blinking,
            Breathing,
            Custom,
            Reactive,
            Spectrumcycling,
            Static,
            Wave,
            Custom2,
            Invalid
        }
 
    }
}
