namespace modeling_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.random_btn = new System.Windows.Forms.Button();
            this.multiplier_txt = new System.Windows.Forms.TextBox();
            this.modulus_txt = new System.Windows.Forms.TextBox();
            this.seed_txt = new System.Windows.Forms.TextBox();
            this.loop_txt = new System.Windows.Forms.TextBox();
            this.modulus_lbl = new System.Windows.Forms.Label();
            this.multiplier_lbl = new System.Windows.Forms.Label();
            this.seed_lbl = new System.Windows.Forms.Label();
            this.loop_lbl = new System.Windows.Forms.Label();
            this.random_txt = new System.Windows.Forms.TextBox();
            this.random_lbl = new System.Windows.Forms.Label();
            this.icg_radio = new System.Windows.Forms.RadioButton();
            this.mrg_radio = new System.Windows.Forms.RadioButton();
            this.lfg_radio = new System.Windows.Forms.RadioButton();
            this.msm_radio = new System.Windows.Forms.RadioButton();
            this.logo_lbl = new System.Windows.Forms.Label();
            this.seeds_list_txt = new System.Windows.Forms.TextBox();
            this.seeds_list_lbl = new System.Windows.Forms.Label();
            this.plus_1 = new System.Windows.Forms.Button();
            this.multiplication_2 = new System.Windows.Forms.Button();
            this.substract_3 = new System.Windows.Forms.Button();
            this.divide_4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.select_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // random_btn
            // 
            this.random_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.random_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.random_btn.ForeColor = System.Drawing.Color.White;
            this.random_btn.Location = new System.Drawing.Point(374, 441);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(225, 46);
            this.random_btn.TabIndex = 7;
            this.random_btn.Text = "Random";
            this.random_btn.UseVisualStyleBackColor = false;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // multiplier_txt
            // 
            this.multiplier_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.multiplier_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiplier_txt.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.multiplier_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.multiplier_txt.Location = new System.Drawing.Point(230, 82);
            this.multiplier_txt.MaxLength = 20;
            this.multiplier_txt.Multiline = true;
            this.multiplier_txt.Name = "multiplier_txt";
            this.multiplier_txt.Size = new System.Drawing.Size(369, 30);
            this.multiplier_txt.TabIndex = 0;
            this.multiplier_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpaceAllowed_KeyPress);
            // 
            // modulus_txt
            // 
            this.modulus_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.modulus_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modulus_txt.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.modulus_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.modulus_txt.Location = new System.Drawing.Point(230, 124);
            this.modulus_txt.MaxLength = 5;
            this.modulus_txt.Multiline = true;
            this.modulus_txt.Name = "modulus_txt";
            this.modulus_txt.Size = new System.Drawing.Size(369, 30);
            this.modulus_txt.TabIndex = 1;
            this.modulus_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // seed_txt
            // 
            this.seed_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.seed_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seed_txt.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.seed_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.seed_txt.Location = new System.Drawing.Point(230, 168);
            this.seed_txt.MaxLength = 20;
            this.seed_txt.Multiline = true;
            this.seed_txt.Name = "seed_txt";
            this.seed_txt.Size = new System.Drawing.Size(369, 30);
            this.seed_txt.TabIndex = 2;
            this.seed_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SpaceAllowed_KeyPress);
            // 
            // loop_txt
            // 
            this.loop_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.loop_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loop_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loop_txt.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.loop_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.loop_txt.Location = new System.Drawing.Point(230, 210);
            this.loop_txt.MaxLength = 2;
            this.loop_txt.Multiline = true;
            this.loop_txt.Name = "loop_txt";
            this.loop_txt.Size = new System.Drawing.Size(369, 30);
            this.loop_txt.TabIndex = 3;
            this.loop_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumOnly_KeyPress);
            // 
            // modulus_lbl
            // 
            this.modulus_lbl.AutoSize = true;
            this.modulus_lbl.Font = new System.Drawing.Font("MV Boli", 12F);
            this.modulus_lbl.ForeColor = System.Drawing.Color.White;
            this.modulus_lbl.Location = new System.Drawing.Point(116, 126);
            this.modulus_lbl.Name = "modulus_lbl";
            this.modulus_lbl.Size = new System.Drawing.Size(88, 26);
            this.modulus_lbl.TabIndex = 2;
            this.modulus_lbl.Text = "Modulus";
            // 
            // multiplier_lbl
            // 
            this.multiplier_lbl.AutoSize = true;
            this.multiplier_lbl.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplier_lbl.ForeColor = System.Drawing.Color.White;
            this.multiplier_lbl.Location = new System.Drawing.Point(116, 84);
            this.multiplier_lbl.Name = "multiplier_lbl";
            this.multiplier_lbl.Size = new System.Drawing.Size(103, 26);
            this.multiplier_lbl.TabIndex = 2;
            this.multiplier_lbl.Text = "Multiplier";
            // 
            // seed_lbl
            // 
            this.seed_lbl.AutoSize = true;
            this.seed_lbl.Font = new System.Drawing.Font("MV Boli", 12F);
            this.seed_lbl.ForeColor = System.Drawing.Color.White;
            this.seed_lbl.Location = new System.Drawing.Point(116, 170);
            this.seed_lbl.Name = "seed_lbl";
            this.seed_lbl.Size = new System.Drawing.Size(55, 26);
            this.seed_lbl.TabIndex = 2;
            this.seed_lbl.Text = "Seed";
            // 
            // loop_lbl
            // 
            this.loop_lbl.AutoSize = true;
            this.loop_lbl.BackColor = System.Drawing.Color.Transparent;
            this.loop_lbl.Font = new System.Drawing.Font("MV Boli", 12F);
            this.loop_lbl.ForeColor = System.Drawing.Color.White;
            this.loop_lbl.Location = new System.Drawing.Point(116, 212);
            this.loop_lbl.Name = "loop_lbl";
            this.loop_lbl.Size = new System.Drawing.Size(65, 26);
            this.loop_lbl.TabIndex = 2;
            this.loop_lbl.Text = "count";
            // 
            // random_txt
            // 
            this.random_txt.BackColor = System.Drawing.Color.White;
            this.random_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.random_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.random_txt.Location = new System.Drawing.Point(416, 272);
            this.random_txt.Multiline = true;
            this.random_txt.Name = "random_txt";
            this.random_txt.ReadOnly = true;
            this.random_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.random_txt.Size = new System.Drawing.Size(183, 146);
            this.random_txt.TabIndex = 4;
            // 
            // random_lbl
            // 
            this.random_lbl.AutoSize = true;
            this.random_lbl.BackColor = System.Drawing.Color.Transparent;
            this.random_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Italic);
            this.random_lbl.ForeColor = System.Drawing.Color.White;
            this.random_lbl.Location = new System.Drawing.Point(467, 247);
            this.random_lbl.Name = "random_lbl";
            this.random_lbl.Size = new System.Drawing.Size(74, 22);
            this.random_lbl.TabIndex = 2;
            this.random_lbl.Text = "Random";
            // 
            // icg_radio
            // 
            this.icg_radio.AutoSize = true;
            this.icg_radio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.icg_radio.ForeColor = System.Drawing.Color.White;
            this.icg_radio.Location = new System.Drawing.Point(306, 441);
            this.icg_radio.Name = "icg_radio";
            this.icg_radio.Size = new System.Drawing.Size(50, 20);
            this.icg_radio.TabIndex = 5;
            this.icg_radio.Text = "ICG";
            this.icg_radio.UseVisualStyleBackColor = false;
            this.icg_radio.CheckedChanged += new System.EventHandler(this.icg_radio_CheckedChanged);
            // 
            // mrg_radio
            // 
            this.mrg_radio.AutoSize = true;
            this.mrg_radio.ForeColor = System.Drawing.Color.White;
            this.mrg_radio.Location = new System.Drawing.Point(230, 441);
            this.mrg_radio.Name = "mrg_radio";
            this.mrg_radio.Size = new System.Drawing.Size(59, 20);
            this.mrg_radio.TabIndex = 5;
            this.mrg_radio.Text = "MRG";
            this.mrg_radio.UseVisualStyleBackColor = true;
            this.mrg_radio.CheckedChanged += new System.EventHandler(this.mrg_radio_CheckedChanged_1);
            // 
            // lfg_radio
            // 
            this.lfg_radio.AutoSize = true;
            this.lfg_radio.ForeColor = System.Drawing.Color.White;
            this.lfg_radio.Location = new System.Drawing.Point(306, 467);
            this.lfg_radio.Name = "lfg_radio";
            this.lfg_radio.Size = new System.Drawing.Size(53, 20);
            this.lfg_radio.TabIndex = 5;
            this.lfg_radio.Text = "LFG";
            this.lfg_radio.UseVisualStyleBackColor = true;
            this.lfg_radio.CheckedChanged += new System.EventHandler(this.lfg_radio_CheckedChanged);
            // 
            // msm_radio
            // 
            this.msm_radio.AutoSize = true;
            this.msm_radio.ForeColor = System.Drawing.Color.White;
            this.msm_radio.Location = new System.Drawing.Point(230, 467);
            this.msm_radio.Name = "msm_radio";
            this.msm_radio.Size = new System.Drawing.Size(59, 20);
            this.msm_radio.TabIndex = 5;
            this.msm_radio.Text = "MSM";
            this.msm_radio.UseVisualStyleBackColor = true;
            this.msm_radio.CheckedChanged += new System.EventHandler(this.msm_radio_CheckedChanged);
            // 
            // logo_lbl
            // 
            this.logo_lbl.AutoSize = true;
            this.logo_lbl.Font = new System.Drawing.Font("Chiller", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logo_lbl.Location = new System.Drawing.Point(191, 9);
            this.logo_lbl.Name = "logo_lbl";
            this.logo_lbl.Size = new System.Drawing.Size(422, 54);
            this.logo_lbl.TabIndex = 2;
            this.logo_lbl.Text = "Random Number Generators";
            // 
            // seeds_list_txt
            // 
            this.seeds_list_txt.BackColor = System.Drawing.Color.White;
            this.seeds_list_txt.Cursor = System.Windows.Forms.Cursors.No;
            this.seeds_list_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(33)))), ((int)(((byte)(86)))));
            this.seeds_list_txt.Location = new System.Drawing.Point(230, 272);
            this.seeds_list_txt.Multiline = true;
            this.seeds_list_txt.Name = "seeds_list_txt";
            this.seeds_list_txt.ReadOnly = true;
            this.seeds_list_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.seeds_list_txt.Size = new System.Drawing.Size(183, 146);
            this.seeds_list_txt.TabIndex = 4;
            // 
            // seeds_list_lbl
            // 
            this.seeds_list_lbl.AutoSize = true;
            this.seeds_list_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Italic);
            this.seeds_list_lbl.ForeColor = System.Drawing.Color.White;
            this.seeds_list_lbl.Location = new System.Drawing.Point(289, 247);
            this.seeds_list_lbl.Name = "seeds_list_lbl";
            this.seeds_list_lbl.Size = new System.Drawing.Size(54, 22);
            this.seeds_list_lbl.TabIndex = 2;
            this.seeds_list_lbl.Text = "Seeds";
            // 
            // plus_1
            // 
            this.plus_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.plus_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plus_1.ForeColor = System.Drawing.Color.White;
            this.plus_1.Location = new System.Drawing.Point(230, 509);
            this.plus_1.Name = "plus_1";
            this.plus_1.Size = new System.Drawing.Size(67, 40);
            this.plus_1.TabIndex = 8;
            this.plus_1.Text = "+";
            this.plus_1.UseVisualStyleBackColor = false;
            this.plus_1.Visible = false;
            this.plus_1.Click += new System.EventHandler(this.plus_1_Click);
            // 
            // multiplication_2
            // 
            this.multiplication_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.multiplication_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiplication_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.multiplication_2.ForeColor = System.Drawing.Color.White;
            this.multiplication_2.Location = new System.Drawing.Point(333, 509);
            this.multiplication_2.Name = "multiplication_2";
            this.multiplication_2.Size = new System.Drawing.Size(67, 40);
            this.multiplication_2.TabIndex = 8;
            this.multiplication_2.Text = "X";
            this.multiplication_2.UseVisualStyleBackColor = false;
            this.multiplication_2.Visible = false;
            this.multiplication_2.Click += new System.EventHandler(this.multiplication_2_Click);
            // 
            // substract_3
            // 
            this.substract_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.substract_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.substract_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.substract_3.ForeColor = System.Drawing.Color.White;
            this.substract_3.Location = new System.Drawing.Point(429, 509);
            this.substract_3.Name = "substract_3";
            this.substract_3.Size = new System.Drawing.Size(67, 40);
            this.substract_3.TabIndex = 8;
            this.substract_3.Text = "-";
            this.substract_3.UseVisualStyleBackColor = false;
            this.substract_3.Visible = false;
            this.substract_3.Click += new System.EventHandler(this.substract_3_Click);
            // 
            // divide_4
            // 
            this.divide_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.divide_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.divide_4.ForeColor = System.Drawing.Color.White;
            this.divide_4.Location = new System.Drawing.Point(532, 509);
            this.divide_4.Name = "divide_4";
            this.divide_4.Size = new System.Drawing.Size(67, 40);
            this.divide_4.TabIndex = 8;
            this.divide_4.Text = "÷";
            this.divide_4.UseVisualStyleBackColor = false;
            this.divide_4.Visible = false;
            this.divide_4.Click += new System.EventHandler(this.divide_4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Chiller", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(765, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // select_lbl
            // 
            this.select_lbl.AutoSize = true;
            this.select_lbl.Font = new System.Drawing.Font("Chiller", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(125)))));
            this.select_lbl.Location = new System.Drawing.Point(145, 510);
            this.select_lbl.Name = "select_lbl";
            this.select_lbl.Size = new System.Drawing.Size(521, 54);
            this.select_lbl.TabIndex = 2;
            this.select_lbl.Text = " ↑Don\'t Forget to select Method ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(823, 573);
            this.ControlBox = false;
            this.Controls.Add(this.divide_4);
            this.Controls.Add(this.substract_3);
            this.Controls.Add(this.multiplication_2);
            this.Controls.Add(this.plus_1);
            this.Controls.Add(this.msm_radio);
            this.Controls.Add(this.lfg_radio);
            this.Controls.Add(this.mrg_radio);
            this.Controls.Add(this.icg_radio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_lbl);
            this.Controls.Add(this.logo_lbl);
            this.Controls.Add(this.multiplier_lbl);
            this.Controls.Add(this.random_lbl);
            this.Controls.Add(this.loop_lbl);
            this.Controls.Add(this.seeds_list_lbl);
            this.Controls.Add(this.seed_lbl);
            this.Controls.Add(this.modulus_lbl);
            this.Controls.Add(this.seeds_list_txt);
            this.Controls.Add(this.random_txt);
            this.Controls.Add(this.loop_txt);
            this.Controls.Add(this.seed_txt);
            this.Controls.Add(this.modulus_txt);
            this.Controls.Add(this.multiplier_txt);
            this.Controls.Add(this.random_btn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RNG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button random_btn;
        private System.Windows.Forms.TextBox multiplier_txt;
        private System.Windows.Forms.TextBox modulus_txt;
        private System.Windows.Forms.TextBox seed_txt;
        private System.Windows.Forms.Label modulus_lbl;
        private System.Windows.Forms.Label multiplier_lbl;
        private System.Windows.Forms.Label seed_lbl;
        private System.Windows.Forms.Label loop_lbl;
        private System.Windows.Forms.TextBox random_txt;
        private System.Windows.Forms.Label random_lbl;
        private System.Windows.Forms.RadioButton icg_radio;
        private System.Windows.Forms.RadioButton mrg_radio;
        private System.Windows.Forms.RadioButton lfg_radio;
        private System.Windows.Forms.RadioButton msm_radio;
        private System.Windows.Forms.Label logo_lbl;
        public System.Windows.Forms.TextBox loop_txt;
        private System.Windows.Forms.TextBox seeds_list_txt;
        private System.Windows.Forms.Label seeds_list_lbl;
        private System.Windows.Forms.Button plus_1;
        private System.Windows.Forms.Button multiplication_2;
        private System.Windows.Forms.Button substract_3;
        private System.Windows.Forms.Button divide_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label select_lbl;
    }
}

