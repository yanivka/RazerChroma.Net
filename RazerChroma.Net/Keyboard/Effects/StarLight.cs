using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Keyboard
{
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
            NativeWin32.ColorRef  Color1;
            NativeWin32.ColorRef  Color2;
            public _Duration Duration;             
 
         }
}