using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerCynosaChromaPro.Device
{
    public class RazerCynosaChromaProDevice: ChromaDevice
    {
        public RazerCynosaChromaProDevice() : base("Razer Cynosa Chroma Pro", "Gaming Keyboard with Razer Chroma™ Underglow", Guid.Parse("CD1E09A5-D5E6-4A6C-A93B-E6D9BF1D2092"), RazerCynosaChromaPro.Device.Properties.Resources.DeviceImage) {}
    }
}
