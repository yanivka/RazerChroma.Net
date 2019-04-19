using System.Runtime.InteropServices;

namespace RazerChroma.Net.ChromaLink.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Custom
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxLeds))]
        public NativeWin32.ColorRef[] Color;

        public Custom(NativeWin32.ColorRef[] color)
        {
            Color = color;
        }
    }
}