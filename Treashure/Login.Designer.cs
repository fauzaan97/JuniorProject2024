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
            rightPanel.Margin = new Padding(4, 5, 4, 5);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1143, 750);
            rightPanel.TabIndex = 11;
            rightPanel.Paint += rightPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 22F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(254, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 51);
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
            leftPanel.Location = new Point(656, 0);
            leftPanel.Margin = new Padding(4, 5, 4, 5);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(487, 750);
            leftPanel.TabIndex = 8;
            leftPanel.Paint += leftPanel_Paint_1;
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
            pictureBox2.Location = new Point(349, 67);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(81, 72);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(89, 78);
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
            lblLogin.Click += lblLogin_Click;
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
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(214, 50);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(215, 51);
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
            btnLogin.Location = new Point(229, 623);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(171, 83);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(140, 323);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(355, 35);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(140, 407);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(355, 35);
            txtPassword.TabIndex = 4;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(rightPanel);
            Margin = new Padding(4, 5, 4, 5);
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