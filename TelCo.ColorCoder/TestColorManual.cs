using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorManual;

namespace TelCo.ColorCoder
{
    class TestColorManual
    {
        private static void Main(string[] args)
        {
            ColorManual testcolormanual=new ColorManual();
            Console.WriteLine(testcolormanual.ToString());
        }
    }
}
