namespace Treashure
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
            rightPanel = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            btnLogin2 = new Button();
            lblWelcome = new Label();
            btnSignUp2 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            leftPanel = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblLogin = new Label();
            btnSignUp = new Button();
            rightPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(170, 213, 108);
            rightPanel.Controls.Add(textBox3);
            rightPanel.Controls.Add(textBox2);
            rightPanel.Controls.Add(textBox1);
            rightPanel.Controls.Add(panel1);
            rightPanel.Controls.Add(lblWelcome);
            rightPanel.Controls.Add(btnSignUp2);
            rightPanel.Controls.Add(txtUsername);
            rightPanel.Controls.Add(txtPassword);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Margin = new Padding(4, 5, 4, 5);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1143, 750);
            rightPanel.TabIndex = 12;
            rightPanel.Paint += rightPanel_Paint;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F);
            textBox3.Location = new Point(663, 490);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "Confirm Password";
            textBox3.Size = new Size(355, 35);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F);
            textBox2.Location = new Point(663, 165);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Name";
            textBox2.Size = new Size(355, 35);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(663, 245);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email";
            textBox1.Size = new Size(355, 35);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLogin2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 750);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(23, 312);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(319, 87);
            label4.TabIndex = 9;
            label4.Text = "account?";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(37, 55);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 78);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 22F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(149, 72);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(231, 51);
            label5.TabIndex = 0;
            label5.Text = "Treashure";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 215);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(553, 87);
            label6.TabIndex = 1;
            label6.Text = "Already have an";
            label6.Click += label6_Click;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = Color.FromArgb(170, 213, 108);
            btnLogin2.FlatAppearance.BorderSize = 0;
            btnLogin2.FlatStyle = FlatStyle.Flat;
            btnLogin2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin2.ForeColor = Color.White;
            btnLogin2.Location = new Point(177, 433);
            btnLogin2.Margin = new Padding(4, 5, 4, 5);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(171, 83);
            btnLogin2.TabIndex = 7;
            btnLogin2.Text = "Log In";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(737, 55);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(229, 51);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // btnSignUp2
            // 
            btnSignUp2.BackColor = Color.White;
            btnSignUp2.FlatAppearance.BorderSize = 0;
            btnSignUp2.FlatStyle = FlatStyle.Flat;
            btnSignUp2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp2.ForeColor = Color.FromArgb(170, 213, 108);
            btnSignUp2.Location = new Point(751, 628);
            btnSignUp2.Margin = new Padding(4, 5, 4, 5);
            btnSignUp2.Name = "btnSignUp2";
            btnSignUp2.Size = new Size(171, 83);
            btnSignUp2.TabIndex = 2;
            btnSignUp2.Text = "Sign Up";
            btnSignUp2.UseVisualStyleBackColor = false;
            btnSignUp2.Click += btnSignUp2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(663, 328);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(355, 35);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(663, 410);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(355, 35);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            leftPanel.BackColor = Color.Transparent;
            leftPanel.BackgroundImage = (Image)resources.GetObject("leftPanel.BackgroundImage");
            leftPanel.Controls.Add(label3);
            leftPanel.Controls.Add(pictureBox2);
            leftPanel.Controls.Add(label1);
            leftPanel.Controls.Add(lblLogin);
            leftPanel.Controls.Add(btnSignUp);
            leftPanel.Location = new Point(1513, 583);
            leftPanel.Margin = new Padding(4, 5, 4, 5);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(487, 750);
            leftPanel.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(64, 297);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(434, 87);
            label3.TabIndex = 9;
            label3.Text = "account yet?";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(324, 45);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 117);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(74, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 51);
            label1.TabIndex = 0;
            label1.Text = "Treashure";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(49, 215);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(453, 87);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Dont have an";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(170, 213, 108);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(177, 433);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(171, 83);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Signup";
            Load += Signup_Load;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel rightPanel;
        private Panel leftPanel;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lblLogin;
        private Button btnSignUp;
        private Label lblWelcome;
        private Button btnSignUp2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Button btnLogin2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}