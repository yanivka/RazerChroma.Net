using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace TheNewRazerBladeStealth13.Device
{
    public class TheNewRazerBladeStealth13Device: ChromaDevice
    {
        public TheNewRazerBladeStealth13Device() : base("The New Razer Blade Stealth 13", "Move With Power", Guid.Parse("35F6F18D-1AE5-436C-A575-AB44A127903A"), TheNewRazerBladeStealth13.Device.Properties.Resources.DeviceImage) {}
    }
}
