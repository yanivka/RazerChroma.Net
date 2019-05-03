using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerBlackWidowTournamentEditionChroma.Device
{
    public class RazerBlackWidowTournamentEditionChromaDevice: ChromaDevice
    {
        public RazerBlackWidowTournamentEditionChromaDevice() : base("Razer BlackWidow Tournament Edition Chroma", "", Guid.Parse("ED1C1B82-BFBE-418F-B49D-D03F05B149DF"), RazerBlackWidowTournamentEditionChroma.Device.Properties.Resources.DeviceImage) {}
    }
}
