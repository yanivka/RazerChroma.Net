using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChroma.Net;
using System.Drawing;

namespace RazerChromaFrameEngine
{
    public class MousepadFrame
    {

        private NativeRazerApi _api;
        private RazerChroma.Net.MousePad.Effects.Custom rawEffect;
        private Effect lastEffect;

        public MousepadFrame(NativeRazerApi api)
        {
            this._api = api;
            this.rawEffect = new RazerChroma.Net.MousePad.Effects.Custom(new NativeWin32.ColorRef[RazerChroma.Net.MousePad.Definitions.MaxLeds]);
            this.lastEffect = null;
            for (int i = 0; i < RazerChroma.Net.MousePad.Definitions.MaxLeds; i++)
            {
                    this.rawEffect.Color[i].A = 255;
                    this.rawEffect.Color[i].R = 0;
                    this.rawEffect.Color[i].G = 0;
                    this.rawEffect.Color[i].B = 0;
            }
        }
        

        public void SetKey(int index, Color color)
        {
            SetKey(index, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }

        public void SetKey(int index,  RazerChroma.Net.NativeWin32.ColorRef color)
        {
            rawEffect.Color[index].Add(color);
        }


        public void SetKeys(int index1, int index2, Color color)
        {
            SetKeys(index1, index2, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKeys(int index1, int index2, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            int minIndex = (index1 > index2) ? index2 : index1;
            int maxIndex = (index1 > index2) ? index1 : index2;
            for (int i = index1; i <= index2; i++)
                rawEffect.Color[i].Add(color);
        }


        public void Clear()
        {
            Clear(new NativeWin32.ColorRef(0, 0, 0, 255));
        }
        public void Clear(RazerChroma.Net.NativeWin32.ColorRef color)
        {
            SetKeys(0, (int)RazerChroma.Net.MousePad.Definitions.MaxLeds - 1, color);
        }
        public void Clear(Color color)
        {
            SetKeys(0, (int)RazerChroma.Net.MousePad.Definitions.MaxLeds - 1, color);
        }

        public void Update()
        {
            Effect newEffect = _api.CreateMousepadEffect(rawEffect);
            newEffect.Set();
            lastEffect?.Delete();
            lastEffect = newEffect;
        }
    }
}
