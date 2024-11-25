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
            splitter1.BackColor = Color.FromArgb(147, 188, 63);
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(4, 4, 4, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(165, 814);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(147, 188, 63);
            pictureBox1.BackgroundImage = Properties.Resources.Vector;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(14, 23);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 134);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(147, 188, 63);
            pictureBox2.BackgroundImage = Properties.Resources.material_symbols_home;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Location = new Point(35, 177);
            pictureBox2.Margin = new Padding(4, 4, 4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 86);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(89, 114, 38);
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(35, 271);
            pictureBox3.Margin = new Padding(4, 4, 4, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(86, 93);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(147, 188, 63);
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(35, 374);
            pictureBox4.Margin = new Padding(4, 4, 4, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(86, 105);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(147, 188, 63);
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Center;
            pictureBox5.Location = new Point(35, 486);
            pictureBox5.Margin = new Padding(4, 4, 4, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(86, 105);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(147, 188, 63);
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Center;
            pictureBox6.Location = new Point(35, 599);
            pictureBox6.Margin = new Padding(4, 4, 4, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(86, 92);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(202, 220, 191);
            panel1.Controls.Add(webView21);
            panel1.Controls.Add(MapButton);
            panel1.Controls.Add(tbCity);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(233, 108);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 652);
            panel1.TabIndex = 8;
            panel1.Paint += this.panel1_Paint;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 68);
            webView21.Margin = new Padding(4, 4, 4, 4);
            webView21.Name = "webView21";
            webView21.Size = new Size(1013, 584);
            webView21.TabIndex = 4;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click_1;
            // 
            // MapButton
            // 
            MapButton.Location = new Point(456, 14);
            MapButton.Margin = new Padding(4, 4, 4, 4);
            MapButton.Name = "MapButton";
            MapButton.Size = new Size(146, 44);
            MapButton.TabIndex = 3;
            MapButton.Text = "Search";
            MapButton.UseVisualStyleBackColor = true;
            MapButton.Click += MapButton_Click;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(122, 20);
            tbCity.Margin = new Padding(4, 4, 4, 4);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(293, 39);
            tbCity.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 1;
            label2.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(1137, 93);
            label1.TabIndex = 0;
            label1.Text = "Checkout Your Nearest Collection Point!";
            // 
            // Collection_Points
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login__1_;
            ClientSize = new Size(1323, 814);
            Controls.Add(panel1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Margin = new Padding(4, 4, 4, 4);
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