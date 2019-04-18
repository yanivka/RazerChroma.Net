using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.MousePad
{
    [StructLayout(LayoutKind.Sequential)]
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
}