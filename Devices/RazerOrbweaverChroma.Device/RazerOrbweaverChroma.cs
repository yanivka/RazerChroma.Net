using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerOrbweaverChroma.Device
{
    public class RazerOrbweaverChromaDevice: ChromaDevice
    {
        public RazerOrbweaverChromaDevice() : base("Razer Orbweaver Chroma", "Enhanced Ergonomics. Mechanical Precision.", Guid.Parse("DF3164D7-5408-4A0E-8A7F-A7412F26BEBF"), RazerOrbweaverChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
