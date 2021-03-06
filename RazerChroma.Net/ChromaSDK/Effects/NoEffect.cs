﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK.Effects
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NoEffect
    {
        public uint Size;
        public uint Param;

        public NoEffect(uint size, uint param)
        {
            Size = size;
            Param = param;
        }
    }

}
