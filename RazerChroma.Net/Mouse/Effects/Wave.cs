using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse
{
    public struct Wave
         {
            public enum _Direction
            {
                FrontToBack,
                BackToFront
            }
            public _Direction Direction;
          }
}