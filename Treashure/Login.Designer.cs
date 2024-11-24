namespace Treashure
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            rightPanel = new Panel();
            label2 = new Label();
            leftPanel = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblLogin = new Label();
            btnSignUp = new Button();
            lblWelcome = new Label();
            btnLogin = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            rightPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.FromArgb(170, 213, 108);
            rightPanel.Controls.Add(label2);
            rightPanel.Controls.Add(leftPanel);
            rightPanel.Controls.Add(lblWelcome);
            rightPanel.Controls.Add(btnLogin);
            rightPanel.Controls.Add(txtUsername);
            rightPanel.Controls.Add(txtPassword);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(800, 450);
            rightPanel.TabIndex = 11;
            rightPanel.Paint += rightPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(178, 65);
            label2.Name = "label2";
            label2.Size = new Size(92, 35);
            label2.TabIndex = 9;
            label2.Text = "back!";
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
            leftPanel.Location = new Point(459, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(341, 450);
            leftPanel.TabIndex = 8;
            leftPanel.Paint += leftPanel_Paint_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(45, 178);
            label3.Name = "label3";
            label3.Size = new Size(293, 58);
            label3.TabIndex = 9;
            label3.Text = "account yet?";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(244, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 71);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 47);
            label1.Name = "label1";
            label1.Size = new Size(159, 35);
            label1.TabIndex = 0;
            label1.Text = "Treashure";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.Black;
            lblLogin.Location = new Point(34, 129);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(307, 58);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Dont have an";
            lblLogin.Click += lblLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(170, 213, 108);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(124, 260);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(120, 50);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(150, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(146, 35);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(170, 213, 108);
            btnLogin.Location = new Point(160, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(98, 194);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 26);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(98, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 26);
            txtPassword.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rightPanel);
            Name = "Login";
            Text = "Treashure - Log In";
            Load += Login_Load;
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel rightPanel;
        private Label lblWelcome;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Panel leftPanel;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lblLogin;
        private Button btnLogin;
        private Label label2;
        private Label label3;
    }
}