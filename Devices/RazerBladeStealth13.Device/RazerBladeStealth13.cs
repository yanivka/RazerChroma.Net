using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerBladeStealth13.Device
{
    public class RazerBladeStealth13Device: ChromaDevice
    {
        public RazerBladeStealth13Device() : base("Razer Blade Stealth 13", "All Mobility. All Power.", Guid.Parse("47DB1FA7-6B9B-4EE6-B6F4-4071A3B2053B"), RazerBladeStealth13.Device.Properties.Resources.DeviceImage) {}
    }
}
