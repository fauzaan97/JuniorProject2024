using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Npgsql;

namespace Treashure
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int rBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, 30, 30));
            btnSignUp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp.Width, btnSignUp.Height, 30, 30));
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text; // Password yang dimasukkan oleh pengguna

            string role = IsValidLogin(username, password);

            if (role != null)
            {
                SessionManager.Email = username;
                SessionManager.Role = role;

                if (role == "admin")
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Menyembunyikan form login
                    Form2 mainForm = new Form2();
                    mainForm.Show();
                }
                else if (role == "user")
                {
                    MessageBox.Show("Selamat datang!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Menyembunyikan form login
                    Home homePage = new Home(); // Assuming HomePage is the main page for regular users
                    homePage.Show();
                }
            }
            else
            {
                MessageBox.Show("Email atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string IsValidLogin(string email, string password)
        {
            string role = null;

            // Connection string from DatabaseConfig
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";
            string query = "SELECT password, role FROM users WHERE email = @Email";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Get the stored password and role from the database
                                string storedPassword = reader["password"].ToString();
                                role = reader["role"].ToString();

                                // Check if the entered password matches the stored password
                                if (password == storedPassword)
                                {
                                    return role; // Return the role if credentials are valid
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null; // Return null if login is invalid or an error occurs
        }





        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Visible = false;
        }

        private void leftPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
