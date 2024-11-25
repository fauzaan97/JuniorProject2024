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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            UpdateCollectionAmountsForThisMonth();
            UpdateCollectionAmounts();
            UpdateNewestTransactions();
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

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCollectionAmountsForThisMonth()
        {
            // Get the current session's email
            string email = SessionManager.Email;

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

                    // Get the current month and year
                    var currentMonth = DateTime.Now.Month;
                    var currentYear = DateTime.Now.Year;

                    // Query to get the sum of amounts for each collection type for the current user in the current month
                    string query = @"
                    SELECT collection, SUM(amount) AS total_amount
                    FROM transactions
                    WHERE user_id = @UserId
                    AND EXTRACT(MONTH FROM date) = @CurrentMonth
                    AND EXTRACT(YEAR FROM date) = @CurrentYear
                    GROUP BY collection;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("UserId", userId);
                        cmd.Parameters.AddWithValue("CurrentMonth", currentMonth);
                        cmd.Parameters.AddWithValue("CurrentYear", currentYear);

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
                                        label14.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "PP":
                                        label13.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "HDPE":
                                        label12.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "SUP":
                                        label11.Text = totalAmount.ToString() + "kg";
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
        private void UpdateCollectionAmounts()
        {
            // Get the current session's email
            string email = SessionManager.Email;

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
                                        label16.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "LDPE":
                                        label1.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "PP":
                                        label2.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "HDPE":
                                        label3.Text = totalAmount.ToString() + "kg";
                                        break;
                                    case "SUP":
                                        label15.Text = totalAmount.ToString() + "kg";
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
        private void UpdateNewestTransactions()
        {
            // Get the current session's email
            string email = SessionManager.Email;

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

                    // Query to get the 4 newest transactions for the current user
                    string query = @"
                    SELECT amount, collection, date
                    FROM transactions
                    WHERE user_id = @UserId
                    ORDER BY date DESC
                    LIMIT 4;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("UserId", userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;

                            // Check if there are results and fill the labels with the latest transactions
                            while (reader.Read())
                            {
                                decimal amount = reader.IsDBNull(reader.GetOrdinal("amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("amount"));
                                string collection = reader["collection"].ToString();
                                string transactionText = $"{collection} - {amount.ToString()}kg";

                                // Fill the labels from newest (label24) to oldest (label27)
                                switch (count)
                                {
                                    case 0:
                                        label24.Text = transactionText;
                                        break;
                                    case 1:
                                        label25.Text = transactionText;
                                        break;
                                    case 2:
                                        label26.Text = transactionText;
                                        break;
                                    case 3:
                                        label27.Text = transactionText;
                                        break;
                                    default:
                                        break;
                                }

                                count++;
                            }

                            // If there are less than 4 transactions, the remaining labels will be empty
                            while (count < 4)
                            {
                                switch (count)
                                {
                                    case 0:
                                        label24.Text = "";
                                        break;
                                    case 1:
                                        label25.Text = "";
                                        break;
                                    case 2:
                                        label26.Text = "";
                                        break;
                                    case 3:
                                        label27.Text = "";
                                        break;
                                    default:
                                        break;
                                }

                                count++;
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
