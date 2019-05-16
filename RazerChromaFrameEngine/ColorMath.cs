using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChromaFrameEngine
{
    public static class ColorMath
    {

        public static void Add(this ref RazerChroma.Net.NativeWin32.ColorRef baseColor, RazerChroma.Net.NativeWin32.ColorRef drawOnTop)
        {
            baseColor.B =(byte)(baseColor.B + (drawOnTop.B - baseColor.B) * (drawOnTop.A / 255.0));
            baseColor.G = (byte)(baseColor.G + (drawOnTop.G - baseColor.G) * (drawOnTop.A / 255.0));
            baseColor.R = (byte)(baseColor.R + (drawOnTop.R - baseColor.R) * (drawOnTop.A / 255.0));
        }
        public static void Add(this ref RazerChroma.Net.NativeWin32.ColorRef baseColor, byte r, byte g, byte b, byte a)
        {
            baseColor.B = (byte)(baseColor.B + (b - baseColor.B) * (a / 255.0));
            baseColor.G = (byte)(baseColor.G + (g - baseColor.G) * (a / 255.0));
            baseColor.R = (byte)(baseColor.R + (r - baseColor.R) * (a / 255.0));
        }
    }
}
