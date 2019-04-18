using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.MousePad
{
    public static class Definitions
    {


        public const uint MaxLeds = 15;

        public enum EffectType
        {
            None = 0,
            Breathing,
            Custom,
            Spectrumcycling,
            Static,
            Wave,
            Invalid
        }
 
    }
}
