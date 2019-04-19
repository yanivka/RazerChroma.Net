using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.Mouse.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Spectrumcycling
    {
        public Definitions.RzLed LEDId;

        public Spectrumcycling(Definitions.RzLed lEDId)
        {
            LEDId = lEDId;
        }
    }
}