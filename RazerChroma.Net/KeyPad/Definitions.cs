using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.KeyPad
{
    public static class Definitions
    {
        public const uint MaxRow = 4;
        public const uint MaxCol = 5;
        public const uint MaxKeys = MaxRow * MaxCol;
        public enum EffectType
        {
            None = 0,
            Breathing,
            Custom,
            Reactive,
            Spectrumcycling,
            Static,
            Wave,
            Invalid
        }
 
         // Chroma keypad effects
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
 
         public struct Custom
         {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxRow * Definitions.MaxCol))]
            public NativeWin32.ColorRef[][] Color; 
         }
 
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
                Left_to_right,
                Right_to_left,
                Invalid
            }
            public _Direction Direction;                    
         }

    }
}
