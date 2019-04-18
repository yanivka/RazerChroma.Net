using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse
{
    public struct Breathing
         {
            public enum _Type
            {
                OneColor = 1,
                TwoColors,
                RandomColors,
                Invalid
            }
            public Definitions.RzLed LEDId;   
            public _Type Type;
            public NativeWin32.ColorRef Color1;
            public NativeWin32.ColorRef Color2;
         }
}