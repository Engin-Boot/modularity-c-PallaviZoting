using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.MajorMinorColors;
using static TelCo.ColorCoder.ColorPair;

//print color manual with major minor colors and pair number

namespace TelCo.ColorCoder
{
    class ColorManual
    {
            public override string ToString() 
          {
            string majorminorcolorwithpairnumber = "";
            int majorcolorlength=colorMapMajor.Length;
            int minorcolorlength=colorMapMinor.Length;
            
            for(int pairNumber = 1; pairNumber <= majorcolorlength*minorcolorlength; pairNumber++)
            {
                ColorPair majorminorcolorpair = GetColor.GetColorFromPairNumber(pairNumber);
                Console.WriteLine("Pair Number: , Colors: \n", pairNumber, majorminorcolorpair);
                majorminorcolorwithpairnumber += "Pair Number : " + pairNumber +  "   Colors : " + majorminorcolorpair + "\n"; 
            }
            return majorminorcolorwithpairnumber;
        
        }
    }
}
