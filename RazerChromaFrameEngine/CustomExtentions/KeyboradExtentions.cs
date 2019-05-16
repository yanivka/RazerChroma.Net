using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazerChroma.Net;

namespace RazerChromaFrameEngine.CustomExtentions
{
    public static class KeyboradExtentions
    {

        public static readonly double sqrt2 = Math.Sqrt(2);
        public const int SingleLightSize = 1;


        public static double Distance(double x1, double y1, double x2, double y2) => Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y2) * (y2 - y2)));

        public static int LimitInput(int input, int minVal, int maxVal) => (input < minVal) ? minVal : ((input > maxVal) ? maxVal : input);


        public static void DrawWave(this KeyboradFrame frame, double centerRow, double centerCol, NativeWin32.ColorRef color, double startWaveRad, double endWaveRad)
        {

            int outerStartRow = LimitInput((int)Math.Floor(centerRow - endWaveRad), 0, (int)RazerChroma.Net.Keyboard.Definitions.MaxRow - 1);
            int outerEndRow = LimitInput((int)Math.Ceiling(centerRow + endWaveRad), 0, (int)RazerChroma.Net.Keyboard.Definitions.MaxRow - 1);
            int outerStartCol = LimitInput((int)Math.Floor(centerCol - endWaveRad), 0, (int)RazerChroma.Net.Keyboard.Definitions.MaxCol - 1);
            int outerEndCol = LimitInput((int)Math.Ceiling(centerCol + endWaveRad), 0, (int)RazerChroma.Net.Keyboard.Definitions.MaxCol - 1);

            int innerStartRow = (int)Math.Ceiling(centerRow - ((sqrt2 * startWaveRad) / 2));
            int innerEndRow = (int)Math.Floor(centerRow + ((sqrt2 * startWaveRad) / 2));
            int innerStartCol = (int)Math.Ceiling(centerCol - ((sqrt2 * startWaveRad) / 2));
            int innerEndCol = (int)Math.Floor(centerCol + ((sqrt2 * startWaveRad) / 2));

            for (int row = outerStartRow; row <= innerStartRow; row ++)
            {
                for (int col = outerStartCol; col <= outerEndCol; col++)
                {
                    frame.SetKeySafe(row, col, color);
                }
            }
            for (int row = innerEndRow; row <= outerEndRow; row++)
            {
                for (int col = outerStartCol; col <= outerEndCol; col++)
                {
                    frame.SetKeySafe(row, col, color);
                }
            }
            for (int row = innerStartRow ; row <= outerEndRow; row++)
            {
                for (int col = outerStartCol ; col <= innerStartCol; col++)
                {
                    frame.SetKeySafe(row, col, color);
                }
            }
            for (int row = innerStartRow; row <= outerEndRow; row++)
            {
                for (int col = innerEndCol ; col <= outerEndCol; col++)
                {
                    frame.SetKeySafe(row, col, color);
                }
            }
        }



    }
}
