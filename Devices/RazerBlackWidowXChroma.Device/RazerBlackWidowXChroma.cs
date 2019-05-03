using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerBlackWidowXChroma.Device
{
    public class RazerBlackWidowXChromaDevice: ChromaDevice
    {
        public RazerBlackWidowXChromaDevice() : base("Razer BlackWidow X Chroma", "Exposed Metal Top Design Mechanical Keyboard", Guid.Parse("2EA1BB63-CA28-428D-9F06-196B88330BBB"), RazerBlackWidowXChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
