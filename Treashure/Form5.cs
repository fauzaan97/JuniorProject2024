using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;

namespace Treashure
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            LoadProfile();
        }
        private void LoadProfile()
        {
            // String koneksi ke database PostgreSQL (ganti dengan koneksi yang sesuai)
            using (var conn = new NpgsqlConnection(DatabaseConfig.ConnectionString))

            {
                conn.Open();
                string query = "SELECT name, email FROM Account WHERE id = @userID";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("userID", 1);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNama.Text = $"Nama: {reader["name"]}";
                            lblEmail.Text = $"Email: {reader["email"]}";
                        }
                    }
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
            Login form2 = new Login();
            form2.Show();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
