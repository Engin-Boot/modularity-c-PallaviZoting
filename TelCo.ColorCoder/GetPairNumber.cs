using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.MajorMinorColors;

namespace TelCo.ColorCoder
{ 
    class GetPairNumber
    {
        //seperate class for major index, minor index and to get pair number
            // Find the major color in the array and get the index
            public static int MajorIndexGet(ColorPair pair)
            {
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
                return majorIndex;
            }
       
            // Find the minor color in the array and get the index
            public static int MinorIndexGet(ColorPair pair)
            {
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                if (colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
                return minorIndex;
            }
        
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex= MajorIndexGet(pair);
            int minorIndex= MinorIndexGet(pair);
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }

            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
