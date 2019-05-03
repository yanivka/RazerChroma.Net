using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerNommoChroma.Device
{
    public class RazerNommoChromaDevice: ChromaDevice
    {
        public RazerNommoChromaDevice() : base("Razer Nommo Chroma", "2.0 PC Speakers with Full Range Sound", Guid.Parse("D527CBDC-EB0A-483A-9E89-66D50463EC6C"), RazerNommoChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
