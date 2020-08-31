using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.MajorMinorColors;

namespace TelCo.ColorCoder
{ 
    class GetPairNumber
    {
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                index3 = colorMapMajor[i] == pair.majorColor;
                if (index3)
                {
                    majorIndex = i;
                    break;
                }
            }
            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                index2 = colorMapMinor[i] == pair.minorColor;
                if (index2)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            index1 = majorIndex == -1 || minorIndex == -1
            if (index1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
