using System.Runtime.InteropServices;

namespace RazerChroma.Net.ChromaLink
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Custom
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)(Definitions.MaxLeds))]
        public NativeWin32.ColorRef[] Color;
    }
}