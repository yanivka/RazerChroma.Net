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

    }
}
