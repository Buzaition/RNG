using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_Project
{
    internal class ICG
    {
        private double seed;        //x0
        private double a;           //mulltipler
        private double m;           //moduls
        private int loop;
        double[] RNG;
        double[] S_array;
        public ICG()
        {
            seed = 123;
            a = 50;
            m = 120;
            loop = 5;
        }
        public ICG(int multiplier, int modulus, double s, int itr)
        {
            seed = s;
            a = multiplier;
            m = modulus;
            loop = itr;
            RNG = new double[loop];
            S_array = new double[loop + 1];
            S_array[0] = seed;
        }
        public double[] RandomNumber()
        {
            for (int i = 0; i < loop; i++)
            {
                S_array[i + 1] = (a / S_array[i]) % m;
                RNG[i]=S_array[i+1]/m;
                
            }
            return RNG;
        }
        public double[] Seedslist()
        {

            return S_array;
        }
    }
}
