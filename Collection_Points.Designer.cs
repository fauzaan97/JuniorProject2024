namespace Treashure
{
    partial class Collection_Points
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Collection_Points));
            splitter1 = new Splitter();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1 = new Panel();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            MapButton = new Button();
            tbCity = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.OliveDrab;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(127, 600);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.OliveDrab;
            pictureBox1.BackgroundImage = Properties.Resources.Vector;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(11, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 105);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.OliveDrab;
            pictureBox2.BackgroundImage = Properties.Resources.material_symbols_home;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Location = new Point(27, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 67);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Green;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(27, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 73);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.OliveDrab;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(27, 292);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 82);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.OliveDrab;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(27, 380);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(66, 82);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.OliveDrab;
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(27, 468);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(66, 72);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(webView21);
            panel1.Controls.Add(MapButton);
            panel1.Controls.Add(tbCity);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(134, 53);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 547);
            panel1.TabIndex = 8;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 53);
            webView21.Name = "webView21";
            webView21.Size = new Size(779, 494);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            // 
            // MapButton
            // 
            MapButton.Location = new Point(351, 11);
            MapButton.Name = "MapButton";
            MapButton.Size = new Size(112, 34);
            MapButton.TabIndex = 3;
            MapButton.Text = "Search";
            MapButton.UseVisualStyleBackColor = true;
            MapButton.Click += MapButton_Click;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(94, 16);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(226, 31);
            tbCity.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 1;
            label2.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(716, 48);
            label1.TabIndex = 0;
            label1.Text = "Checkout Your Nearest Collection Point!";
            // 
            // Collection_Points
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login__1_;
            ClientSize = new Size(926, 600);
            Controls.Add(panel1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Name = "Collection_Points";
            Text = "Collection_Points";
            Load += Collection_Points_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel1;
        private Label label1;
        private Button MapButton;
        private TextBox tbCity;
        private Label label2;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}