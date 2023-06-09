﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modeling_Project
{
    internal class MRG
    {
        private double[] seeds;
        private double[] a; //multiplier
        private double m;           //moduls
        private int loop;
        double[] RNG;
        int count;

        public MRG()
        {

        }
        public MRG(double[] seed, double[] multiplier, int modulas, int itr, int c)
        {
            m = modulas;
            loop = itr;
            count = c;
            RNG = new double[loop];
            seeds = new double[loop];
            a= new double[count];
            for (int i = 0; i < c; i++)
            {
                seeds[i] = seed[i];
                a[i] = multiplier[i];
            }
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
          
            {
                for (int idx = count; idx < loop; idx++)
                {
                    for (int j = 0,k=1; j < count; j++,k++)
                    {
                        seeds[idx] += a[j] * seeds[idx-k];
                    }

                }
                return seeds;
            }
        }
    }
}
