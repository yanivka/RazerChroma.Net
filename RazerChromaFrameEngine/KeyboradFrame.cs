using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChroma.Net;
using System.Drawing;

namespace RazerChromaFrameEngine
{
    public class KeyboradFrame
    {

        private NativeRazerApi _api;
        private RazerChroma.Net.Keyboard.Effects.Custom rawEffect;
        private Effect lastEffect;

        public KeyboradFrame(NativeRazerApi api)
        {
            this._api = api;
            this.rawEffect = new RazerChroma.Net.Keyboard.Effects.Custom(new NativeWin32.ColorRef[RazerChroma.Net.Keyboard.Definitions.MaxRow, RazerChroma.Net.Keyboard.Definitions.MaxCol]);
            this.lastEffect = null;
            for (int row = 0; row < RazerChroma.Net.Keyboard.Definitions.MaxRow; row++)
            {
                for (int col = 0; col < RazerChroma.Net.Keyboard.Definitions.MaxCol; col++)
                {
                    this.rawEffect.Color[row, col].A = 255;
                    this.rawEffect.Color[row, col].R = 0;
                    this.rawEffect.Color[row, col].G = 0;
                    this.rawEffect.Color[row, col].B = 0;
                }
            }
                    

        }
        
        public void SetKey(RazerChroma.Net.Keyboard.Definitions.RzKey key ,RazerChroma.Net.NativeWin32.ColorRef color)
        {
            SetKey(((int)key & 0xff00) >> 8, (int)key & 0xff, color);
        }
        public void SetKey(RazerChroma.Net.Keyboard.Definitions.RzKey key, Color color)
        {
            SetKey(((int)key & 0xff00) >> 8, (int)key & 0xff, color);
        }
        public void SetKey(Point point, Color color)
        {
            SetKey(point.Y, point.X, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKey(int row, int col, Color color)
        {
            SetKey(row, col, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKey(Point point, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            rawEffect.Color[point.Y, point.X].Add(color);
        }
        public void SetKey(int row, int col, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            rawEffect.Color[row,col].Add(color);
        }

        public void SetKeys(IEnumerable<RazerChroma.Net.Keyboard.Definitions.RzKey> keys, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            foreach (RazerChroma.Net.Keyboard.Definitions.RzKey singleKey in keys)
                rawEffect.Color[((int)singleKey & 0xff00) >> 8, (int)singleKey & 0xff].Add(color);
        }
        public void SetKeys(IEnumerable<RazerChroma.Net.Keyboard.Definitions.RzKey> keys, Color color)
        {
            SetKeys(keys, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKeys(IEnumerable<Point> point, Color color)
        {
            SetKeys(point, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKeys(IEnumerable<Point> points, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            foreach(Point singlePoint in points)
                rawEffect.Color[singlePoint.Y, singlePoint.X].Add(color);         
        }
        public void SetKeys(int row1, int col1, int row2, int col2, Color color)
        {
            SetKeys(row1, col1, row2, col2, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKeys(int row1, int col1, int row2, int col2, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            int minCol = (col1 > col2) ? col2 : col1;
            int minRow = (row1 > row2) ? row2 : row1;
            int MaxCol = (col1 > col2) ? col1 : col2;
            int MaxRow = (row1 > row2) ? row1 : row2;
            for(int currentRow = minRow; currentRow <= MaxRow; currentRow++)
                for(int currentCol = minCol; currentCol <= MaxCol; currentCol ++)
                    rawEffect.Color[currentRow, currentCol].Add(color);
        }
        public void SetKeys(Point p1, Point p2, Color color)
        {
            SetKeys(p1.Y, p1.X, p2.Y, p2.X, new RazerChroma.Net.NativeWin32.ColorRef(color.R, color.G, color.B, color.A));
        }
        public void SetKeys(Point p1, Point p2, RazerChroma.Net.NativeWin32.ColorRef color)
        {
            SetKeys(p1.Y, p1.X, p2.Y, p2.X, color);
        }

        public void Clear()
        {
            Clear(new NativeWin32.ColorRef(0, 0, 0, 255));
        }
        public void Clear(RazerChroma.Net.NativeWin32.ColorRef color)
        {
            SetKeys(0, 0, (int)RazerChroma.Net.Keyboard.Definitions.MaxRow - 1, (int)RazerChroma.Net.Keyboard.Definitions.MaxCol - 1, color);
        }
        public void Clear(Color color)
        {
            SetKeys(0, 0, (int)RazerChroma.Net.Keyboard.Definitions.MaxRow - 1, (int)RazerChroma.Net.Keyboard.Definitions.MaxCol - 1, color);
        }

        public void Update()
        {
            Effect newEffect = _api.CreateKeyboardEffect(rawEffect);
            newEffect.Set();
            lastEffect?.Delete();
            lastEffect = newEffect;
        }
    }
}
