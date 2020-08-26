using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.GetColor;
using static TelCo.ColorCoder.GetPairNumber;
using static TelCo.ColorCoder.ColorManual;

namespace TelCo.ColorCoder
{
    class TestColorManual
    {
        private static void Main(string[] args)
        {
            ColorManual testcolormanual=new ColorManual();
            testcolormanual = ColorManual.ToString();
            Console.WriteLine(testcolormanual);
        }
    }
}
