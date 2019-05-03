using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace NAMENOSPACE.Device
{
    public class NAMENOSPACE2: ChromaDevice
    {
        public NAMENOSPACE2() : base("NAME", "INFO", Guid.Parse("GUID"), NAMENOSPACE.Device.Properties.Resources.DeviceImage) {}
    }
}
