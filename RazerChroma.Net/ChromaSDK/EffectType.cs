using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK
{

    public static class Definitions
    {
        public const uint MaxRow = 30;
        public const uint MaxCol = 30;
        public enum EffectType
        {
            None = 0,
            Wave,
            SpectrumCycling,
            Breathing,
            Blinking,
            Reactive,
            Static,
            Custom,
            Reserved,
            Invaild
        }


    }
    
}
