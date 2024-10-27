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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            leftPanel = new Panel();
            welcomeLabel = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnSignIn = new Button();
            rightPanel = new Panel();
            lblLogo = new Label();
            btnSignUp = new Button();
            pictureBox1 = new PictureBox();
            lblNoAccount = new Label();
            btnLogIn = new Button();
            recycleLogo = new PictureBox();
            leftPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recycleLogo).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(157, 204, 57);
            leftPanel.Controls.Add(welcomeLabel);
            leftPanel.Controls.Add(txtUsername);
            leftPanel.Controls.Add(txtPassword);
            leftPanel.Controls.Add(btnSignIn);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(400, 455);
            leftPanel.TabIndex = 0;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Arial", 20F, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.Black;
            welcomeLabel.Location = new Point(57, 50);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(313, 46);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome Back!";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 14F);
            txtUsername.Location = new Point(75, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 40);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 14F);
            txtPassword.Location = new Point(75, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 40);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.White;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.Font = new Font("Arial", 14F);
            btnSignIn.ForeColor = Color.Black;
            btnSignIn.Location = new Point(125, 230);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(150, 49);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.White;
            rightPanel.BackgroundImage = Properties.Resources.Login__1_;
            rightPanel.BackgroundImageLayout = ImageLayout.Stretch;
            rightPanel.Controls.Add(lblLogo);
            rightPanel.Controls.Add(btnSignUp);
            rightPanel.Controls.Add(pictureBox1);
            rightPanel.Controls.Add(lblNoAccount);
            rightPanel.Controls.Add(btnLogIn);
            rightPanel.Controls.Add(recycleLogo);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(829, 455);
            rightPanel.TabIndex = 1;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblLogo.ForeColor = Color.Black;
            lblLogo.Location = new Point(436, 20);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(231, 51);
            lblLogo.TabIndex = 4;
            lblLogo.Text = "Treashure";
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Green;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(571, 200);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 50);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(676, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 72);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.BackColor = Color.Transparent;
            lblNoAccount.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblNoAccount.ForeColor = Color.Black;
            lblNoAccount.Location = new Point(436, 154);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(380, 33);
            lblNoAccount.TabIndex = 0;
            lblNoAccount.Text = "Don't have an account yet?";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(157, 204, 57);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Arial", 14F);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(100, 200);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(150, 40);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            // 
            // recycleLogo
            // 
            recycleLogo.Location = new Point(320, 20);
            recycleLogo.Name = "recycleLogo";
            recycleLogo.Size = new Size(50, 50);
            recycleLogo.SizeMode = PictureBoxSizeMode.Zoom;
            recycleLogo.TabIndex = 2;
            recycleLogo.TabStop = false;
            // 
            // Form2
            // 
            BackColor = Color.Black;
            ClientSize = new Size(829, 455);
            Controls.Add(leftPanel);
            Controls.Add(rightPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            Text = "Login Form";
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)recycleLogo).EndInit();
            ResumeLayout(false);
        }

        private Panel leftPanel;
        private Label welcomeLabel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignIn;
        private Panel rightPanel;
        private Label lblNoAccount;
        private Button btnLogIn;
        private PictureBox recycleLogo;
        private PictureBox pictureBox1;
        private Button btnSignUp;
        private Label lblLogo;
    }
}

       
        

    
