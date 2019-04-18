using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.MousePad
{
    public static class Definitions
    {


        public const uint MaxLeds = 15;

        public enum EffectType
        {
            None = 0,
            Breathing,
            Custom,
            Spectrumcycling,
            Static,
            Wave,
            Invalid
        }
 
         // Chroma mousepad effects
         public struct Breathing
         {
            public enum _Type
            {
                TwoColors = 1,
                RandomColors,
                Invaild
            }
            public _Type Type;
            public NativeWin32.ColorRef Color1;
            public NativeWin32.ColorRef Color2;
        }
 
         public struct Custom
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxLeds))]
            public NativeWin32.ColorRef[] Color;
        }
 
         public struct Static
        {
            public NativeWin32.ColorRef Color;
        }
 
         public struct Wave
        {
            public enum _Direction
            {
                None = 0,
                LeftToRight,
                RightToLeft,
                Invalid
            }
            public _Direction Direction;                    
         }

    }
}
