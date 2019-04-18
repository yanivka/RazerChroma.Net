using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.KeyPad
{
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