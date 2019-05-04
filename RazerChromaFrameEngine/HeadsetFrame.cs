using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChroma.Net;
using System.Drawing;

namespace RazerChromaFrameEngine
{
    public class HeadsetFrame
    {

        private NativeRazerApi _api;
        private RazerChroma.Net.HeadSet.Effects.Static rawEffect;
        private Effect lastEffect;

        public HeadsetFrame(NativeRazerApi api)
        {
            this._api = api;
            this.rawEffect = new RazerChroma.Net.HeadSet.Effects.Static(new NativeWin32.ColorRef(0,0,0,255));
            this.lastEffect = null;
        }
        


        public void Set(Color color)
        {
            Set(new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }

        public void Set(RazerChroma.Net.NativeWin32.ColorRef color)
        {
            rawEffect.Color.Add(color);
        }

 
        public void Update()
        {
            Effect newEffect = _api.CreateHeadSetEffect(rawEffect);
            newEffect.Set();
            lastEffect?.Delete();
            lastEffect = newEffect;
        }
    }
}
