
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;


namespace TelCo.ColorCoder
{
    /// <summary>
    /// This class provides the color code manual
    /// </summary>
    class CodeManual
    {
        public override string ToString() //overrides the ToString() in ColorLists
        {
   return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
