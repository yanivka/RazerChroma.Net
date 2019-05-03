using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerCynosaChroma.Device
{
    public class RazerCynosaChromaDevice: ChromaDevice
    {
        public RazerCynosaChromaDevice() : base("Razer Cynosa Chroma", "Gaming Keyboard with Soft Cushioned Keys", Guid.Parse("F1876328-6CA4-46AE-BE04-BE812B414433"), RazerCynosaChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
