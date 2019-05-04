using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerNagaChroma.Device
{
    public class RazerNagaChromaDevice: ChromaDevice
    {
        public RazerNagaChromaDevice() : base("Razer Naga Chroma", "19 programmable buttons and customizable lightning", Guid.Parse("18C5AD9B-4326-4828-92C4-2669A66D2283"), RazerNagaChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
