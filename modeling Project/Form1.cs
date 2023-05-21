using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //====================== intial values =========================

        Color _Color = Color.FromArgb(28, 107, 191);
        Color _btncolor = Color.FromArgb(65, 205, 125);
        int operation = 1;
        MSM msm = new MSM();
        ICG icg = new ICG();
        LFG lfg = new LFG();
        MRG mrg = new MRG();
        bool first_msm = true;
        bool first_icg = true;
        bool first_lfg = true;
        bool first_mrg = true;
        double[] random_numbers = new double[100];
        int[] Seeds_list = new int[100];
        double[] Seeds_arr = new double[100];
        private bool isDragging = false;
        private Point lastLocation;
        string pattern = "\\s+";
        string replacement = " ";






        //*************************** program *************************
        private void random_btn_Click(object sender, EventArgs e)
        {
            random_txt.Text = "";
            seeds_list_txt.Text = "";
            if (string.IsNullOrWhiteSpace(loop_txt.Text) &&
                string.IsNullOrWhiteSpace(modulus_txt.Text)
                 && string.IsNullOrWhiteSpace(multiplier_txt.Text) &&
                string.IsNullOrWhiteSpace(seed_txt.Text))
            {
                MessageBox.Show("You Should Enter Any Value to Aplly Methods");
            }
            else if (!icg_radio.Checked && !mrg_radio.Checked && !lfg_radio.Checked && !msm_radio.Checked)
            {
                MessageBox.Show("Please Select Any Method");
            }
            else
            {
                try
                {
                    // ============  First Algorithem By Fadu Sameh 42010294    ==============

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

                    // ============ Second Algorithem By Mohamed Qadry 42010629 ==============

                    if (mrg_radio.Checked == true)
                    {
                        int loop = int.Parse(loop_txt.Text);
                        //*******seeds convert***********
                        string mul_txt= Regex.Replace(multiplier_txt.Text, pattern, replacement).Trim();
                        string[] sub_a = mul_txt.Split(' ');
                        double[] arr_a = new double[sub_a.Length];

                        for (int i = 0; i < sub_a.Length; i++)
                        {
                            arr_a[i] = double.Parse(sub_a[i]);
                        }
                        string seed_sub = Regex.Replace(seed_txt.Text, pattern, replacement).Trim();
                        string[] sub_s = seed_sub.Split(' ');
                        Seeds_arr = new double[sub_s.Length];

                        for (int i = 0; i < sub_s.Length; i++)
                        {
                            Seeds_arr[i] = double.Parse(sub_s[i]);
                        }


                        if (sub_a.Length == sub_s.Length)
                        {

                            mrg = new MRG(Seeds_arr, arr_a, int.Parse(modulus_txt.Text), loop, sub_a.Length);
                            Seeds_arr = mrg.Seedslist();
                            random_numbers = mrg.RandomNumber();
                            for (int i = 0; i < loop; i++)
                            {
                                random_txt.Text += "R" + (i + 1).ToString() + ": " + random_numbers[i].ToString("F4") + "\r\n";
                                seeds_list_txt.Text += "X" + (i).ToString() + ": " + Seeds_arr[i].ToString("F3") + "\r\n";

                            }
                        }
                    }

                    // ============    Third Algorithem By Abuzaid 42010650     ==============

                    if (lfg_radio.Checked == true)
                    {
                        int loop = int.Parse(loop_txt.Text);
                        //*******seeds convert***********
                        string seed_sub= Regex.Replace(seed_txt.Text, pattern, replacement).Trim();
                        string[] substrings = seed_sub.Split(' ');
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

                    // ============ Forth Algorithem By Ahmed Albaz 42010427 ==============

                    if (msm_radio.Checked == true)
                    {
                        if (seed_txt.Text.Length == 4 && int.Parse(seed_txt.Text) > 999)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


  //=============================== Handling ======================================
        private void Form1_Load(object sender, EventArgs e)
        {
            Control[] controls = { multiplier_txt, modulus_txt, seed_txt, loop_txt, random_btn, plus_1, multiplication_2, substract_3, divide_4 };

            foreach (Control control in controls)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, control.Height, control.Height, 90, 180);
                path.AddLine(control.Height / 2, 0, control.Width - control.Height / 2, 0);
                path.AddArc(control.Width - control.Height, 0, control.Height, control.Height, 300, 180);
                path.AddLine(control.Width - control.Height / 2, control.Height, control.Height / 2, control.Height);
                control.Region = new Region(path);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Radio Button Handling
        private void icg_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (icg_radio.Checked == true)
            {
                
                foreach (Control control in Controls)
                {
                    control.Visible = true;
                }
                plus_1.Visible = false;
                multiplication_2.Visible = false;
                substract_3.Visible = false;
                divide_4.Visible = false;
                select_lbl.Visible = false;
                if (first_icg == true)
                {
                    MessageBox.Show("INPUT SHOULD BE: ↓\n" +
                       "one seed\none multiplier\nint number for modulus\n" +
                       "Number of 'Random numbers' do you want");
                    first_icg = false;
                }
            }
        }
        private void mrg_radio_CheckedChanged_1(object sender, EventArgs e)
        {
            

            foreach (Control control in Controls)
            {
                control.Visible = true;
            }
            if (mrg_radio.Checked)
            {
                select_lbl.Visible = false;
                plus_1.Visible = false;
                multiplication_2.Visible = false;
                substract_3.Visible = false;
                divide_4.Visible = false;
                if (first_mrg == true)
                {
                    MessageBox.Show("INPUT SHOULD BE: ↓:\n" +
                         "more than one seed\nmore than one multiplier\nint number for modulus\n" +
                         "Number of 'Random numbers' do you want\n" +
                         "Note: You can enter More than one seed or multiplier\n" +
                         "by enter space between every 2 seed or multiplier ");
                    first_mrg = false;

                }
            }


        }
        private void lfg_radio_CheckedChanged(object sender, EventArgs e)
        {
            
            foreach (Control control in Controls)
            {
                control.Visible = true;
            }
            if (lfg_radio.Checked == true)
            {
                select_lbl.Visible = false;
                multiplier_lbl.Visible = false;
                multiplier_txt.Visible = false;
                plus_1.Visible = true;
                multiplication_2.Visible = true;
                substract_3.Visible = true;
                divide_4.Visible = true;
                if (first_lfg == true)
                {
                    MessageBox.Show("INPUT SHOULD BE: ↓\n" +
                       "more than one seed\nint number for modulus\n" +
                       "Number of 'Random numbers' do you want" +
                       "Note: You can enter More than one seed \n" +
                       "by enter space between every 2 seed or multiplier ");
                    first_lfg = false;
                }
            }
            if (lfg_radio.Checked == false)
            {
                multiplier_lbl.Visible = true;
                multiplier_txt.Visible = true;
                plus_1.Visible = false;
                multiplication_2.Visible = false;
                substract_3.Visible = false;
                divide_4.Visible = false;
            }

        }
        private void msm_radio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (msm_radio.Checked == true)
            {
                select_lbl.Visible = false;
                multiplier_lbl.Visible = false;
                multiplier_txt.Visible = false;
                modulus_lbl.Visible = false;
                modulus_txt.Visible = false;
                if (first_msm == true)
                {
                    MessageBox.Show("INPUT SHOULD BE: ↓\n" +
                       "4 Digit seed\n" + "Number of 'Random numbers' do you want");
                    first_msm = false;
                }

            }
        }

        //KeyBoard And Mouse Handling
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        //Opration Buttons
        private void divide_4_Click(object sender, EventArgs e)
        {
            operation = 4;
            plus_1.BackColor = _btncolor;
            multiplication_2.BackColor = _btncolor;
            substract_3.BackColor = _btncolor;
            divide_4.BackColor = _Color;
        }
        private void substract_3_Click(object sender, EventArgs e)
        {
            operation = 3;
            plus_1.BackColor = _btncolor;
            multiplication_2.BackColor = _btncolor;
            substract_3.BackColor = _Color;
            divide_4.BackColor = _btncolor;
        }
        private void multiplication_2_Click(object sender, EventArgs e)
        {
            operation = 2;
            plus_1.BackColor = _btncolor;
            multiplication_2.BackColor = _Color;
            substract_3.BackColor = _btncolor;
            divide_4.BackColor = _btncolor;
        }
        private void plus_1_Click(object sender, EventArgs e)
        {
            operation = 1;
            plus_1.BackColor = _Color;
            multiplication_2.BackColor = _btncolor;
            substract_3.BackColor = _btncolor;
            divide_4.BackColor = _btncolor;

        }
        private void NumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;

            }
        }
        private void SpaceAllowed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (icg_radio.Checked || msm_radio.Checked)
               /* || string.IsNullOrWhiteSpace(multiplier_txt.Text)||
                string.IsNullOrWhiteSpace(seed_txt.Text))*/
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                {
                    e.Handled = true;

                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;

            }
        }
        

    }
}
