using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.MajorMinorColors;

//gives manual of major minor color list from pair number

namespace TelCo.ColorCoder
{
    class ColorPair
    {
            internal Color majorColor;
            internal Color minorColor;
           // public override string ToString()
            //{
            //    return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            //}
        
           public override string ToString() //overrides the ToString() in ColorLists
          {
            string majorminorcolorwithpairnumber = "";
            int majorcolorlength=colorMapMajor.Length;
            int minorcolorlength=colorMapMinor.Length;
            
            for(int pairNumber = 1; pairNumber <= majorcolorlength*minorcolorlength; pairNumber++)
            {
                colorPair majorminorcolorpair = GetColor.GetColorFromPairNumber(pairNumber);
                Console.WriteLine("Pair Number: , Colors: \n", pairNumber, majorminorcolorpai);
                majorminorcolorwithpairnumber += "Pair Number : " + pairNumber +  "   Colors : " + majorminorcolorpair + "\n"; 
            }
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
             return majorminorcolorwithpairnumber;
        }
    }
}
