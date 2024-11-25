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
    public partial class Claim : Form
    {
        public Claim()
        {
            InitializeComponent();
        }

        private decimal GetUserBalanceByUsername(string email)
        {
            decimal balance = 0;

            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";
            string query = "SELECT total FROM balance WHERE user_id = (SELECT id FROM users WHERE email = @email)";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", email);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            balance = Convert.ToDecimal(result);
                        }
                        else
                        {
                            MessageBox.Show("Balance not found for the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return balance;
        }
        private string GetUserFullName(string username)
        {
            string fullName = string.Empty;

            // Connection string to your PostgreSQL database
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            // Query to get the full name based on the username
            string query = "SELECT name FROM users WHERE email = @Username";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Add the parameter for username
                        cmd.Parameters.AddWithValue("Username", username);

                        // Execute the query and read the result
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Get the full name from the database
                                fullName = reader["name"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return fullName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Claim_Load(object sender, EventArgs e)
        {

            if (SessionManager.IsLoggedIn())
            {
                string name = GetUserFullName(SessionManager.Email);

                // If a valid name is retrieved, update the label
                if (!string.IsNullOrEmpty(name))
                {
                    decimal balance = GetUserBalanceByUsername(SessionManager.Email);

                    // Display the balance in Label15
                    label15.Text = "Rp " + balance.ToString();
                }
                else
                {
                    label1.Text = "Welcome, User!";
                }
            }
            else
            {
                MessageBox.Show("No user is logged in.");
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number number = new Number();
            number.Show();
            Visible = false;
        }
    }
}
