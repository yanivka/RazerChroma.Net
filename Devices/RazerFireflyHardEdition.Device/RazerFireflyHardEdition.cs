using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerFireflyHardEdition.Device
{
    public class RazerFireflyHardEditionDevice: ChromaDevice
    {
        public RazerFireflyHardEditionDevice() : base("Razer Firefly Hard Edition", "The Original RGB Mouse Mat", Guid.Parse("80F95A94-73D2-48CA-AE9A-0986789A9AF2"), RazerFireflyHardEdition.Device.Properties.Resources.DeviceImage) {}
    }
}
