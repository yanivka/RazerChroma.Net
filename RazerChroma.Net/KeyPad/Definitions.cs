using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.KeyPad
{
    public static class Definitions
    {
        public const uint MaxRow = 4;
        public const uint MaxCol = 5;
        public const uint MaxKeys = MaxRow * MaxCol;
        public enum EffectType
        {
            None = 0,
            Breathing,
            Custom,
            Reactive,
            Spectrumcycling,
            Static,
            Wave,
            Invalid
        }
    }
}
