using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerDeathAdderElite.Device
{
    public class RazerDeathAdderEliteDevice: ChromaDevice
    {
        public RazerDeathAdderEliteDevice() : base("Razer DeathAdder Elite", "Gaming Mouse Favored by Top Esports Pros", Guid.Parse("AEC50D91-B1F1-452F-8E16-7B73F376FDF3"), RazerDeathAdderElite.Device.Properties.Resources.DeviceImage) {}
    }
}
