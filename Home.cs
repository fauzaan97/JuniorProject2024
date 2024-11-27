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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void Home_Load(object sender, EventArgs e)
        {
            if (SessionManager.IsLoggedIn())
            {
                // Fetch the user's full name from the database based on the username
                string name = GetUserFullName(SessionManager.GetEmail());

                // If a valid name is retrieved, update the label
                if (!string.IsNullOrEmpty(name))
                {
                    label1.Text = "Welcome, " + name + "!";
                    decimal balance = GetUserBalanceByUsername(SessionManager.GetEmail());

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

        private string GetUserFullName(string username)
        {
            UpdateCollectionAmounts();
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

        private void UpdateCollectionAmounts()
        {
            // Get the current session's email
            string email = SessionManager.GetEmail();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("User is not logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Get user_id based on the current session email
                    string getUserIdQuery = "SELECT ID FROM users WHERE email = @Email";
                    int userId = 0;

                    using (var cmd = new NpgsqlCommand(getUserIdQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", email);
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Query to get the sum of amounts for each collection type for the current user
                    string query = @"
                    SELECT collection, SUM(amount) AS total_amount
                    FROM transactions
                    WHERE user_id = @UserId
                    GROUP BY collection;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("UserId", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Set the labels to display the sum of amounts for each collection type
                            while (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("total_amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("total_amount"));

                                // Update the corresponding label based on the collection type
                                switch (collection)
                                {
                                    case "PET":
                                        label10.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "LDPE":
                                        label11.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "PP":
                                        label12.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "HDPE":
                                        label13.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "SUP":
                                        label14.Text = totalAmount.ToString() + "kg";
                                        break;
                                    default:
                                        break;
                                }
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Claim claim = new Claim();
            claim.Show();
            Visible = false;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.Show();
            Visible = false;
        }
    }
}
