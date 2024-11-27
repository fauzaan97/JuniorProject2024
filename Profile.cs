using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treashure
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string email = SessionManager.GetEmail(); // Get the session email

            // Retrieve user information from the database based on the email
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            string query = "SELECT name, username, email FROM users WHERE email = @Email";

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
                                // Get the user information from the database
                                string name = reader["name"].ToString();
                                string username = reader["username"].ToString();
                                string userEmail = reader["email"].ToString();

                                // Update the Labels with the user's information
                                label4.Text = name;
                                label5.Text = username;
                                label6.Text = userEmail;
                            }
                            else
                            {
                                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Collection_Points collection_points = new Collection_Points();
            collection_points.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Claim claim = new Claim();
            claim.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_Profile edit_Profile = new Edit_Profile();
            edit_Profile.Show();
            Visible = false;
        }
    }
}
