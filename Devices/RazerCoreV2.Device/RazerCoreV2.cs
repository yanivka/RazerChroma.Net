using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerCoreV2.Device
{
    public class RazerCoreV2Device: ChromaDevice
    {
        public RazerCoreV2Device() : base("Razer Core V2", "Plug in for Full Desktop Power", Guid.Parse("0201203B-62F3-4C50-83DD-598BABD208E0"), RazerCoreV2.Device.Properties.Resources.DeviceImage) {}
    }
}
