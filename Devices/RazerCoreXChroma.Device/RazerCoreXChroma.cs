using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerCoreXChroma.Device
{
    public class RazerCoreXChromaDevice: ChromaDevice
    {
        public RazerCoreXChromaDevice() : base("Razer Core X Chroma", "External graphics enclosure with gaming-grade desktop power, ports, and Razer Chroma.", Guid.Parse("FF8A5929-4512-4257-8D59-C647BF9935D0"), RazerCoreXChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
