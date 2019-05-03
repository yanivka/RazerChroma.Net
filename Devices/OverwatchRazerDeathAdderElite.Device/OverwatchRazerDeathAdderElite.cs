using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace OverwatchRazerDeathAdderElite.Device
{
    public class OverwatchRazerDeathAdderEliteDevice: ChromaDevice
    {
        public OverwatchRazerDeathAdderEliteDevice() : base("Overwatch Razer DeathAdder Elite", "Officially Licensed Gaming Mouse for Overwatch", Guid.Parse("872AB2A9-7959-4478-9FED-15F6186E72E4"), OverwatchRazerDeathAdderElite.Device.Properties.Resources.DeviceImage) {}
    }
}
