using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerNagaHexV2.Device
{
    public class RazerNagaHexV2Device: ChromaDevice
    {
        public RazerNagaHexV2Device() : base("Razer Naga Hex V2", "7 Button Thumbwheel MOBA Gaming Mouse", Guid.Parse("195D70F5-F285-4CFF-99F2-B8C0E9658DB4"), RazerNagaHexV2.Device.Properties.Resources.DeviceImage) {}
    }
}
