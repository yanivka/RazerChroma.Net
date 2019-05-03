using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace TheNewRazerBlade15.Device
{
    public class TheNewRazerBlade15Device: ChromaDevice
    {
        public TheNewRazerBlade15Device() : base("The New Razer Blade 15", "The World’s Smallest 15.6” Gaming Laptop", Guid.Parse("F2BEDFAF-A0FE-4651-9D41-B6CE603A3DDD"), TheNewRazerBlade15.Device.Properties.Resources.DeviceImage) {}
    }
}
