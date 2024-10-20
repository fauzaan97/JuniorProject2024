namespace Treashure
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            leftPanel = new Panel();
            pictureBox1 = new PictureBox();
            lblLogo = new Label();
            lblLogin = new Label();
            btnLogin = new Button();
            rightPanel = new Panel();
            lblWelcome = new Label();
            this.txtName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtUsername = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            chkAgree = new CheckBox();
            btnSignUp = new Button();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            rightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Transparent;
            leftPanel.BackgroundImage = (Image)resources.GetObject("leftPanel.BackgroundImage");
            leftPanel.Controls.Add(pictureBox1);
            leftPanel.Controls.Add(lblLogo);
            leftPanel.Controls.Add(lblLogin);
            leftPanel.Controls.Add(btnLogin);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(414, 493);
            leftPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(30, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 70);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.Black;
            lblLogo.Location = new Point(118, 30);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(231, 51);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "Treashure";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(12, 197);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(364, 33);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Already have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(118, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(170, 213, 108);
            rightPanel.Controls.Add(lblWelcome);
            rightPanel.Controls.Add(txtName);
            rightPanel.Controls.Add(txtEmail);
            rightPanel.Controls.Add(txtUsername);
            rightPanel.Controls.Add(txtPassword);
            rightPanel.Controls.Add(txtConfirmPassword);
            rightPanel.Controls.Add(chkAgree);
            rightPanel.Controls.Add(btnSignUp);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(414, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(464, 493);
            rightPanel.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(150, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(229, 51);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome!";
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 12F);
            txtName.Location = new Point(150, 100);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(250, 35);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F);
            txtEmail.Location = new Point(150, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(250, 35);
            txtEmail.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(150, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 35);
            txtUsername.TabIndex = 3;
            
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(150, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 35);
            txtPassword.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial", 12F);
            txtConfirmPassword.Location = new Point(150, 260);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(250, 35);
            txtConfirmPassword.TabIndex = 5;
            // 
            // chkAgree
            // 
            chkAgree.AutoSize = true;
            chkAgree.Font = new Font("Arial", 10F);
            chkAgree.Location = new Point(150, 300);
            chkAgree.Name = "chkAgree";
            chkAgree.Size = new Size(423, 27);
            chkAgree.TabIndex = 6;
            chkAgree.Text = "With this, I Consent of The Data Being Used";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Green;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(200, 330);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 50);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            ClientSize = new Size(878, 493);
            Controls.Add(rightPanel);
            Controls.Add(leftPanel);
            Name = "Form1";
            Text = "Treashure - Login & Sign Up";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel leftPanel;
        private Label lblLogo;
        private Label lblLogin;
        private Button btnLogin;
        private Panel rightPanel;
        private Label lblWelcome;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private CheckBox chkAgree;
        private Button btnSignUp;
        private PictureBox pictureBox1;
    }
}
