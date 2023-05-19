using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_Project
{
    class MSM
    {
        private int seed;
        private int loop;
        double[] RNG;
        int[] S_array;
        public MSM()
        {
            seed = 1234;
            loop = 5;
        }
        public MSM(int s, int itr)
        {
            seed = s % 10000;
            loop = itr;
            RNG = new double[loop];
            S_array = new int[loop+1];
            S_array[0] = seed;
        }
        public double[] RandomNumber()
        {
            
            string temp_seed;
            for (int i = 0; i < loop; i++)
            {
                temp_seed = (seed * seed).ToString("D8");
                temp_seed = temp_seed.Substring(temp_seed.Length - 6, 4);
                seed = int.Parse(temp_seed);
                S_array[i+1] = seed;
                RNG[i] = seed / 10000.0;
            }
            return RNG;
        }
        public int[] Seedslist()
        {
            
            return S_array;
        }

        }
}









/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_Project
{
    internal class MSM
    {
        private int seed;
        private int nextseed;
        private double RN;

        public MSM(int s)
        {
            seed = s;
            Nextseed();
        }
        public void set_seed(int s)
        {
            seed = s;
        }
        public int get_next_seed()
        {
            return nextseed;
        }
        public int Nextseed()
        {
            string ns = ((seed * seed).ToString());
            ns = ns.Substring(ns.Length - 6, 4);
            nextseed=int.Parse(ns);
            seed= nextseed;
            return nextseed;

        }
        public double MSM_RNG()
        {
            string temp=seed.ToString();
            temp = "0." + temp;
            RN = double.Parse(temp);
            return RN;
        }
    }
}
*/