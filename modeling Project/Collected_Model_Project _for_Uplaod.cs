/*//=========================| classes |================================

//================ 1_Inversive Congruentail generator ================
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
            RNG[i] = S_array[i + 1] / m;

        }
        return RNG;
    }
    public double[] Seedslist()
    {

        return S_array;
    }
}




//================== 2_Multiple recursive generator ==================

internal class MRG
{
    private double[] seeds;
    private double[] a; //multiplier
    private double m;           //moduls
    private int numOfRN;
    double[] RNG;
    int count;

    public MRG()
    {

    }
    public MRG(double[] seed, double[] multiplier, int modulas, int itr, int c)
    {
        m = modulas;
        numOfRN = itr;
        count = c;
        RNG = new double[numOfRN];
        seeds = new double[numOfRN];
        a = new double[count];
        for (int i = 0; i < c; i++)
        {
            seeds[i] = seed[i];
            a[i] = multiplier[i];
        }
    }

    public double[] RandomNumber()
    {

        for (int j = 0; j < numOfRN; j++)
        {
            RNG[j] = (seeds[j] / m);
        }


        return RNG;
    }

    public double[] Seedslist()
    {

        {
            for (int idx = count; idx < numOfRN; idx++)
            {
                for (int j = 0, k = 1; j < count; j++, k++)
                {
                    seeds[idx] += a[j] * seeds[idx - k];
                }

            }
            return seeds;
        }
    }
}


//================== 3_Lagged Fibonacci generator  ===================


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
        count = 0;
        operation = 1;

    }
    public LFG(double[] s, int modulus, int itr, int op, int c)
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
        count = c;
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


//====================== 4_Mid-Square method  ========================


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
        S_array = new int[loop + 1];
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
            S_array[i + 1] = seed;
            RNG[i] = seed / 10000.0;
        }
        return RNG;
    }
    public int[] Seedslist()
    {

        return S_array;
    }

}
// *+*+*+*+*+*+* main without control code (tools|GUI) *+*+*+*+*+*+*+*+*+*+
//=========================================================================
//************************* intial value *****************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modeling_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color _Color = Color.FromArgb(79, 193, 242);
        int operation = 1;
        MSM msm = new MSM();
        ICG icg = new ICG();
        LFG lfg = new LFG();
        MRG mrg = new MRG();
        double[] random_numbers = new double[100];
        int[] Seeds_list = new int[100];
        double[] Seeds_arr = new double[100];

        private void random_btn_Click(object sender, EventArgs e)
        {
            random_txt.Text = "";
            seeds_list_txt.Text = "";
            try
            {
                if (msm_radio.Checked == true)
                {
                    if (seed_txt.Text.Length == 4)
                    {
                        int loop = int.Parse(loop_txt.Text);
                        msm = new MSM(int.Parse(seed_txt.Text), loop);
                        random_numbers = msm.RandomNumber();
                        Seeds_list = msm.Seedslist();
                        for (int i = 0; i < loop; i++)
                        {
                            random_txt.Text += "R" + (i + 1).ToString() + ": " + random_numbers[i].ToString("F4") + "\r\n";
                            seeds_list_txt.Text += "X" + (i).ToString() + ": " + Seeds_list[i].ToString("D4") + "\r\n";
                        }
                    }


                    else
                    {
                        MessageBox.Show("seed chould be 4 digit");
                    }
                }

                if (icg_radio.Checked == true)
                {
                    int loop = int.Parse(loop_txt.Text);
                    icg = new ICG(int.Parse(multiplier_txt.Text), int.Parse(modulus_txt.Text), double.Parse(seed_txt.Text), loop);
                    Seeds_arr = icg.Seedslist();
                    random_numbers = icg.RandomNumber();

                    seeds_list_txt.Text += "X" + (0).ToString() + ": " + Seeds_arr[0].ToString("F4") + "\r\n";
                    for (int i = 0; i < loop; i++)
                    {
                        random_txt.Text += "R" + (i + 1).ToString() + ": " + random_numbers[i].ToString("F4") + "\r\n";
                        seeds_list_txt.Text += "X" + (i + 1).ToString() + ": " + Seeds_arr[i + 1].ToString("F3") + "\r\n";

                    }
                }
                if (lfg_radio.Checked == true)
                {
                    int loop = int.Parse(loop_txt.Text);
                    //*******seeds convert***********
                    string[] substrings = seed_txt.Text.Split(' ');
                    Seeds_arr = new double[substrings.Length];

                    for (int i = 0; i < substrings.Length; i++)
                    {
                        Seeds_arr[i] = double.Parse(substrings[i]);
                    }

                    int count = substrings.Length;
                    lfg = new LFG(Seeds_arr, int.Parse(modulus_txt.Text), loop, operation, count);
                    Seeds_arr = lfg.Seedslist();
                    random_numbers = lfg.RandomNumber();
                    for (int i = 0; i < loop; i++)
                    {
                        random_txt.Text += "R" + (i + 1).ToString() + ": " + random_numbers[i].ToString("F4") + "\r\n";
                        seeds_list_txt.Text += "X" + (i).ToString() + ": " + Seeds_arr[i].ToString("F3") + "\r\n";

                    }



                }

                if (mrg_radio.Checked == true)
                {

                    int loop = int.Parse(loop_txt.Text);
                    //*******seeds convert***********
                    string[] substrings = multiplier_txt.Text.Split(' ');
                    double[] numbers = new double[substrings.Length];

                    for (int i = 0; i < substrings.Length; i++)
                    {
                        numbers[i] = double.Parse(substrings[i]);
                    }

                    string[] substrings1 = seed_txt.Text.Split(' ');
                    Seeds_arr = new double[substrings1.Length];

                    for (int i = 0; i < substrings1.Length; i++)
                    {
                        Seeds_arr[i] = double.Parse(substrings1[i]);
                    }


                    if (substrings.Length == substrings1.Length)
                    {
                        int count = substrings.Length;
                        mrg = new MRG(Seeds_arr, numbers, int.Parse(modulus_txt.Text), loop, count);
                        Seeds_arr = mrg.Seedslist();
                        random_numbers = mrg.RandomNumber();
                        for (int i = 0; i < loop; i++)
                        {
                            random_txt.Text += "R" + (i + 1).ToString() + ": " + random_numbers[i].ToString("F4") + "\r\n";
                            seeds_list_txt.Text += "X" + (i).ToString() + ": " + Seeds_arr[i].ToString("F3") + "\r\n";

                        }

                    }


                }


            }



            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

*/