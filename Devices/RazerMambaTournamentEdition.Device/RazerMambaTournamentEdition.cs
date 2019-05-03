using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChromaDevice;

namespace RazerMambaTournamentEdition.Device
{
    public class RazerMambaTournamentEditionDevice: ChromaDevice
    {
        public RazerMambaTournamentEditionDevice() : base("Razer Mamba Tournament Edition", "Extreme Personalization", Guid.Parse("7EC00450-E0EE-4289-89D5-0D879C19061A"), RazerMambaTournamentEdition.Device.Properties.Resources.DeviceImage) {}
    }
}
