using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerGoliathusChroma.Device
{
    public class RazerGoliathusChromaDevice: ChromaDevice
    {
        public RazerGoliathusChromaDevice() : base("Razer Goliathus Chroma", "Soft Gaming Mouse Mat Powered by Razer Chroma", Guid.Parse("52C15681-4ECE-4DD9-8A52-A1418459EB34"), RazerGoliathusChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
