using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK.Effects
{
    public struct Wave
    {
        public enum _Direction
        {
            LeftToRight = 1,
            RightToLeft,
            FrontToBack,
            BackToFront
        }

        public uint Size;
        public uint Param;
        public _Direction Direction;
    }
}
