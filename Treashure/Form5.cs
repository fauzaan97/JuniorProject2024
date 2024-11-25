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
            LoadAdminData();
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

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }
        private void LoadAdminData()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";
            // Get the current session's email
            string sessionEmail = SessionManager.Email;

            if (string.IsNullOrEmpty(sessionEmail))
            {
                MessageBox.Show("User is not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query to fetch user details and admin ability
                    string query = @"
                    SELECT 
                        u.email, 
                        u.username,  
                        u.name, 
                        u.role, 
                        a.ability
                    FROM 
                        users u
                    LEFT JOIN 
                        admins a 
                    ON 
                        u.ID = a.user_id
                    WHERE 
                        u.email = @Email;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", sessionEmail);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the form fields with the data
                                label10.Text = reader["email"].ToString();
                                label2.Text = reader["username"].ToString();;
                                label6.Text = reader["name"].ToString();
                                label7.Text = reader["role"].ToString();

                                if (!reader.IsDBNull(reader.GetOrdinal("ability")))
                                {
                                    label8.Text = reader["ability"].ToString();
                                }
                                else
                                {
                                    label8.Text = "No Ability";
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the current user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
