namespace Treashure
{
    partial class Form2
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
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.MidnightBlue;
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(2);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(56, 270);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.BackgroundImage = Properties.Resources.Vector;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 41);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Aquamarine;
            pictureBox2.BackgroundImage = Properties.Resources.material_symbols_home;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Location = new Point(8, 54);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MidnightBlue;
            pictureBox3.BackgroundImage = Properties.Resources.mdi_report_bar;
            pictureBox3.Location = new Point(13, 94);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 29);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.MidnightBlue;
            pictureBox4.BackgroundImage = Properties.Resources.ion_binoculars;
            pictureBox4.Location = new Point(8, 127);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 33);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.MidnightBlue;
            pictureBox5.Image = Properties.Resources.Vector1;
            pictureBox5.Location = new Point(7, 164);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(43, 31);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.MidnightBlue;
            pictureBox6.BackgroundImage = Properties.Resources.iconamoon_exit_light;
            pictureBox6.Location = new Point(2, 224);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 38);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login__1_;
            ClientSize = new Size(560, 270);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Splitter splitter1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}