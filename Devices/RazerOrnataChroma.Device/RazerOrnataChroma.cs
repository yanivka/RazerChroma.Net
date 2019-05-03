using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerOrnataChroma.Device
{
    public class RazerOrnataChromaDevice: ChromaDevice
    {
        public RazerOrnataChromaDevice() : base("Razer Ornata Chroma", "Soft Touch. Tactile Click Gaming Keyboard.", Guid.Parse("803378C1-CC48-4970-8539-D828CC1D420A"), RazerOrnataChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
