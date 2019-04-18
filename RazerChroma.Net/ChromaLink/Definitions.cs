using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaLink
{
    public static class Definitions
    {

        public const uint MaxLeds = 5;

        public enum EffectType
        {
            CHROMA_NONE = 0,
            CHROMA_CUSTOM,
            CHROMA_STATIC,
            CHROMA_INVALID
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


    }

}

