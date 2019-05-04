using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerNagaEpicChroma.Device
{
    public class RazerNagaEpicChromaDevice: ChromaDevice
    {
        public RazerNagaEpicChromaDevice() : base("Razer Naga Epic Chroma", "19 Buttons for Spellbinding Action", Guid.Parse("D714C50B-7158-4368-B99C-601ACB985E98"), RazerNagaEpicChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
