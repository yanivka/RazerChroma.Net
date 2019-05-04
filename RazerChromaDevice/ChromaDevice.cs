using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RazerChromaDevice
{
    public abstract class ChromaDevice
    {
        public readonly string Name;
        public readonly string Description;
        public readonly Guid id;
        public readonly Image Cover;

        public ChromaDevice(string name, string description, Guid id, Image cover)
        {
            this.id = id;
            this.Cover = cover;
            this.Description = description;
            this.Name = name;
        }
    }
}
