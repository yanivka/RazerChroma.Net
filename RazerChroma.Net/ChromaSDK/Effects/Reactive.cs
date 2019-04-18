using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Reactive
    {
        public enum _Duration
        {
            Short = 1,
            Medium,
            Long
        }

        public uint Size;
        public uint Param;
        public _Duration Duration;
        public NativeWin32.ColorRef Color;
    }
}
