using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerBlackWidowChromaV2.Device
{
    public class RazerBlackWidowChromaV2Device: ChromaDevice
    {
        public RazerBlackWidowChromaV2Device() : base("Razer BlackWidow Chroma V2", "Most Advanced Mechanical Gaming Keyboard", Guid.Parse("5AF60076-ADE9-43D4-B574-52599293B554"), RazerBlackWidowChromaV2.Device.Properties.Resources.DeviceImage) {}
    }
}
