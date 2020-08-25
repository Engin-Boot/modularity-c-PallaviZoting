using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class MajorMinorColors
    {
        private static Color[] colorMapMajor;
        private static Color[] colorMapMinor;

        static MajorMinorColors()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
