using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceInfoType
    {
        public enum DeviceType
        {
            Keyboard = 1,
            Mouse = 2,
            Headset = 3,
            MousePad = 4,
            KeyPad = 5,
            System = 6,
            Speakers = 7,
            Invaild
        }

        public DeviceType Type;
        public uint Connected;
    }
 
}
