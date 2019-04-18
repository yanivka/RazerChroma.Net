using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK.Effects
{

    public struct Breathing
    {

        public enum _Type
        {
            OneColor = 1,
            TwoColors,
            RandomColors
        }

        public uint Size;
        public uint Param;
        public _Type Type;
        public NativeWin32.ColorRef Color1;
        public NativeWin32.ColorRef Color2;
    }

}
