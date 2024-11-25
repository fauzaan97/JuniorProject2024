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
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string email = SessionManager.Email; // Get the session email
            string newName = textBox1.Text; // New name from TextBox1
            string newUsername = textBox2.Text; // New username from TextBox2

            // Validate input: Check if name or username is empty
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Name and username cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with updating the database
            if (UpdateUserProfile(email, newName, newUsername))
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home home = new Home();
                home.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Failed to update profile. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool UpdateUserProfile(string email, string newName, string newUsername)
        {
            bool isUpdated = false;

            // Database connection string
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            // SQL query to update the name and username based on the email
            string updateQuery = "UPDATE users SET name = @Name, username = @Username WHERE email = @Email";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        // Adding parameters to the query to prevent SQL injection
                        cmd.Parameters.AddWithValue("Name", newName);
                        cmd.Parameters.AddWithValue("Username", newUsername);
                        cmd.Parameters.AddWithValue("Email", email);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // If one row was affected, it means the update was successful
                        if (rowsAffected > 0)
                        {
                            isUpdated = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isUpdated;
        }
    }
}
