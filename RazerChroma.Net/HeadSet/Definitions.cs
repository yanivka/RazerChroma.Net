using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.HeadSet
{
    public static class Definitions
    {
        public const uint MaxLeds = 5;

        public enum EffectType
        {
            None = 0,
            Static,
            Breathing,
            Spectrumcycling,
            Custom,
            Invalid
        }


    }
}
