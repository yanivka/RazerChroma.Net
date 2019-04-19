using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net
{
    public class Effect : IDisposable
    {
        private bool isDisposed;
        private Guid id;
        private NativeRazerApi api;

        internal Effect (NativeRazerApi api, Guid id)
        {
            this.isDisposed = false;
            this.id = id;
            this.api = api;
        }

        public void Set()
        {
            api.SetEffect(this.id);
        }
        public void Delete()
        {
            if(!isDisposed)
            {
                isDisposed = true;
                api.DeleteEffect(this.id);
            }
        }

        public void Dispose()
        {
            this.Delete();
        }
    }
}
