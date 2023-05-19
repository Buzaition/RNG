using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_Project
{
    internal class TR
    {
        public int i;

        public string tstr = DateTime.Now.ToString("mmss");
        public string Gen(int s_range, int e_range)
        {
            
            string mmss = DateTime.Now.ToString("mmss");
            char[] mmssChars = mmss.ToCharArray();
            char temp = mmssChars[0];
            mmssChars[0] = mmssChars[2];
            mmssChars[2] = temp;
            mmss = new string(mmssChars);
            double ran=int.Parse(mmss);
            ran = Math.Pow(ran, 1.28649)*Math.Log10(3);
            mmss= ((ran / 978.53791246) * s_range ).ToString();
            int l=mmss.Length;
            //Swap
            //return mmss;

            i=(i+3)%l;
            return ("0." + mmss[(i+1)%l] + mmss[(i+3)%l] + mmss[ (i+5) %l]);

            



        }


    }
}
