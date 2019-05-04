using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerTartarusV2.Device
{
    public class RazerTartarusV2Device: ChromaDevice
    {
        public RazerTartarusV2Device() : base("Razer Tartarus V2", "Ergonomic Mecha-Membrane Keypad", Guid.Parse("00F0545C-E180-4AD1-8E8A-419061CE505E"), RazerTartarusV2.Device.Properties.Resources.DeviceImage) {}
    }
}
