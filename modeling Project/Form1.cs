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

        //************************* intial value *****************

        Color _Color = Color.FromArgb(79, 193, 242);
        int operation=1;
        TR t = new TR();
        MSM msm =   new MSM();
        ICG icg =   new ICG();
        LFG lfg = new LFG();
        MRG mrg = new MRG();
        double [] random_numbers=new double[100];
        int [] Seeds_list=new int[100];
        double [] Seeds_arr=new double[100];
        
        

      // *********************** radio buutons *********************

        private void msm_radio_CheckedChanged(object sender, EventArgs e)
        {
            if(msm_radio.Checked==true)
            {
                multiplier_lbl.Visible = false;
                multiplier_txt.Visible = false;
                modulus_lbl.Visible = false;
                modulus_txt.Visible = false;

            }
        }

        private void icg_radio_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Visible = true;
            }
        }

        private void lfg_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (lfg_radio.Checked == true)
            {
                multiplier_lbl.Visible = false;
                multiplier_txt.Visible = false;
                
            }
        }
        private void mrg_radio_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Visible = true;
            }
        }


        //*************************** program *************************
        private void random_btn_Click(object sender, EventArgs e)
        {
            random_txt.Text = "";
            seeds_list_txt.Text = "";
            try
            {
                if (msm_radio.Checked==true)
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
                        seeds_list_txt.Text += "X" + (i+1).ToString() + ": " + Seeds_arr[i+1].ToString("F3") + "\r\n";
                        
                    }
                }
                if (lfg_radio.Checked==true)
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
                    lfg = new LFG(Seeds_arr, int.Parse(modulus_txt.Text),loop,operation,count);
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

                    
                    if(substrings.Length==substrings1.Length)
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

        private void divide_4_Click(object sender, EventArgs e)
        {
            operation = 4;
            plus_1.BackColor = SystemColors.Control;
            multiplication_2.BackColor = SystemColors.Control;
            substract_3.BackColor = SystemColors.Control;
            divide_4.BackColor = _Color;
        }

        private void substract_3_Click(object sender, EventArgs e)
        {
            operation = 3;
            plus_1.BackColor = SystemColors.Control;
            multiplication_2.BackColor = SystemColors.Control;
            substract_3.BackColor =_Color;
            divide_4.BackColor = SystemColors.Control;
        }

        private void multiplication_2_Click(object sender, EventArgs e)
        {
            operation = 2;
            plus_1.BackColor = SystemColors.Control;
            multiplication_2.BackColor = _Color;
            substract_3.BackColor = SystemColors.Control;
            divide_4.BackColor = SystemColors.Control;
        }

        private void plus_1_Click(object sender, EventArgs e)
        {
            operation = 1;
            plus_1.BackColor = _Color;
            multiplication_2.BackColor = SystemColors.Control;
            substract_3.BackColor = SystemColors.Control;
            divide_4.BackColor = SystemColors.Control;

        }

        
    }
}
