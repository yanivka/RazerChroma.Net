using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.KeyPad
{
    public struct Breathing
        {
            public enum _Type
            {
                TWO_COLORS = 1,
                RANDOM_COLORS,
                INVALID
            }
            public _Type Type;
            public NativeWin32.ColorRef Color1;
            public NativeWin32.ColorRef Color2;
        }
}