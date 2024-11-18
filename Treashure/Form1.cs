using Npgsql;
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

namespace Treashure
{
    public partial class Form1 : Form
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
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=Postgres;Password=52442006;Database=Treashure";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private void Signup_Load(object sender, EventArgs e)
        {
            btnSignUp2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp2.Width, btnSignUp2.Height, 30, 30));
            btnLogin2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp.Width, btnSignUp.Height, 30, 30));
            conn = new NpgsqlConnection(connstring);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from user_insert (:_name, :_username, :_email, :_password";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", textBox2.Text);
                cmd.Parameters.AddWithValue("_username", textBox1.Text);
                cmd.Parameters.AddWithValue("_email", txtUsername.Text);
                cmd.Parameters.AddWithValue("_password", txtPassword.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Sign Up berhasil harap kembali ke halaman login", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    txtUsername.Text = txtPassword.Text = textBox2.Text = textBox1.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
