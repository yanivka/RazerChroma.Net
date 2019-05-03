using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerLaptopStandChroma.Device
{
    public class RazerLaptopStandChromaDevice: ChromaDevice
    {
        public RazerLaptopStandChromaDevice() : base("Razer Laptop Stand Chroma", "", Guid.Parse("9D24B0AB-0162-466C-9640-7A924AA4D9FD"), RazerLaptopStandChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
