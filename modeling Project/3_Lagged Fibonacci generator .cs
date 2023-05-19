using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_Project
{
    internal class LFG
    {
        private double[] seeds;
        private double m;           //moduls
        private int loop;
        double[] RNG;
        int operation;
        int count;
        
        

        public LFG()
        {
            count=0;
            operation = 1;
            
        }
        public LFG(double[] s,int modulus, int itr, int op,int c)
        {
            loop = itr;
            RNG = new double[loop];
            seeds = new double[loop];
            for (int i = 0; i < s.Length; i++)
            {
                seeds[i] = s[i];
            }
            m = double.Parse(modulus.ToString());
            operation = op;
            count= c;
        }

        public double[] RandomNumber()
        {
           
            for (int j = 0; j < loop; j++)
            {
                RNG[j] = (seeds[j] / m);
            }


            return RNG;
        }
        public double[] Seedslist()
        {
            
            if (operation == 1)
            {
                for (int i = count; i < loop; i++)
                {
                    seeds[i] = (seeds[i - 1] + seeds[i - 2]) % m;
                    
                }
            }
            else if (operation == 2)
            {
                for (int i = count; i < loop; i++)
                {
                    seeds[i] = (seeds[i - 1] * seeds[i - 2]) % m;

                }
            }
            else if (operation == 3)
            {
                for (int i = count; i < loop; i++)
                {
                    seeds[i] = (seeds[i - 1] - seeds[i - 2]) % m;

                }
            }
            else if (operation == 4)
            {
                for (int i = count; i < loop; i++)
                {
                    seeds[i] = (seeds[i - 1] / seeds[i - 2]) % m;

                }
            }
            return seeds;
        }
    }
}
