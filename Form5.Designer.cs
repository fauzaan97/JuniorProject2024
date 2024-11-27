namespace Treashure
{
    partial class Form5
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
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            splitter1 = new Splitter();
            lblNama = new Label();
            lblEmail = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.MidnightBlue;
            pictureBox6.BackgroundImage = Properties.Resources.iconamoon_exit_light;
            pictureBox6.Location = new Point(4, 224);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 38);
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Aqua;
            pictureBox5.Image = Properties.Resources.Vector1;
            pictureBox5.Location = new Point(10, 136);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 33);
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MidnightBlue;
            pictureBox3.BackgroundImage = Properties.Resources.mdi_report_bar;
            pictureBox3.Location = new Point(15, 94);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 29);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.BackgroundImage = Properties.Resources.material_symbols_home;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Location = new Point(10, 54);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.BackgroundImage = Properties.Resources.Vector;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 44);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.MidnightBlue;
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(56, 270);
            splitter1.TabIndex = 15;
            splitter1.TabStop = false;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Georgia", 9F);
            lblNama.ForeColor = Color.Black;
            lblNama.Location = new Point(16, 100);
            lblNama.Margin = new Padding(2, 0, 2, 0);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(42, 15);
            lblNama.TabIndex = 23;
            lblNama.Text = "Name";
            lblNama.Click += lblNama_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Georgia", 9F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(16, 75);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 15);
            lblEmail.TabIndex = 24;
            lblEmail.Text = "Username";
            lblEmail.Click += lblEmail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 9F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(102, 75);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 26;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNama);
            panel1.Font = new Font("Georgia", 9F);
            panel1.ForeColor = Color.Khaki;
            panel1.Location = new Point(91, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 195);
            panel1.TabIndex = 27;
            panel1.Paint += panel1_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 9F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(102, 50);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 34;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Georgia", 9F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(16, 50);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 33;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Georgia", 9F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(102, 150);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 32;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 9F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(102, 125);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 31;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 9F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(102, 100);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 30;
            label6.Text = "label6";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SkyBlue;
            label3.Location = new Point(0, 5);
            label3.Name = "label3";
            label3.Size = new Size(336, 28);
            label3.TabIndex = 29;
            label3.Text = "User Details and Previleges";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 9F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 150);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 28;
            label5.Text = "Ability";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 27;
            label4.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cascadia Code", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(164, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 46);
            label1.TabIndex = 28;
            label1.Text = "User Details";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TPS_Manager;
            ClientSize = new Size(560, 270);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Margin = new Padding(2);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Label lblNama;
        private Label lblEmail;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
    }
}