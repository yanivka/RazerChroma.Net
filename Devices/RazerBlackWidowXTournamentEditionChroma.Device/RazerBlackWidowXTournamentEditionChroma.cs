using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerBlackWidowXTournamentEditionChroma.Device
{
    public class RazerBlackWidowXTournamentEditionChromaDevice: ChromaDevice
    {
        public RazerBlackWidowXTournamentEditionChromaDevice() : base("Razer BlackWidow X Tournament Edition Chroma", "Tenkeyless Gaming Keyboard for Pro Playstyle", Guid.Parse("2D84DD51-3290-4AAC-9A89-D8AFDE38B57C"), RazerBlackWidowXTournamentEditionChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
