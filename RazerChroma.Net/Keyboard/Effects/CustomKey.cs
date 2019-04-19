using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Keyboard.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CustomKey
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxRow * Definitions.MaxCol))]
        public NativeWin32.ColorRef[][] Color;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxRow * Definitions.MaxCol))]
        public NativeWin32.ColorRef[][] Key;

        public CustomKey(NativeWin32.ColorRef[][] color, NativeWin32.ColorRef[][] key)
        {
            Color = color;
            Key = key;
        }
    }
}