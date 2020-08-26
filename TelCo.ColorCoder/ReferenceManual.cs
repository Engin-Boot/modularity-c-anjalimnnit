using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using static TelCo.ColorCoder.ColorList;
using static TelCo.ColorCoder.ColorPair;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color code manual
    /// </summary>
    class ReferenceManual
    {
        public override string ToString() //overrides the ToString() in ColorLists
        {
            string colorCodeWithColors = "";
            for(int pairNo = 1; pairNo<= colorMapMinor.Length*colorMapMajor.Length; pairNo++)
            {
                ColorPair pair = ColorPair.GetColorFromPairNumber(pairNo);
                colorCodeWithColors += "Pair Number : " + pairNo +  "   Colors : " + pair + "\n"; 

            }
            
             return colorCodeWithColors;
        }
    }
}

