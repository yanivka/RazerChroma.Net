using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaLink
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Static
    {
        public NativeWin32.ColorRef Color;
    }
}