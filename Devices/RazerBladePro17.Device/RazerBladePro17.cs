using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerBladePro17.Device
{
    public class RazerBladePro17Device: ChromaDevice
    {
        public RazerBladePro17Device() : base("Razer Blade Pro 17", "Performance pushed to the edge", Guid.Parse("C83BDFE8-E7FC-40E0-99DB-872E23F19891"), RazerBladePro17.Device.Properties.Resources.DeviceImage) {}
    }
}
