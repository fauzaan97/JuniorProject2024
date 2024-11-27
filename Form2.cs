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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateCollectionAmountsForThisMonth();
            UpdateNewestTransactions();
            UpdateCollectionAmounts();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form4 = new Form2();
            form4.Show();
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            Visible = false;
        }
        private void UpdateCollectionAmountsForThisMonth()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Get the current month and year
                    var currentMonth = DateTime.Now.Month;
                    var currentYear = DateTime.Now.Year;

                    // Query to get the sum of amounts for each collection type for the current month
                    string query = @"
                SELECT collection, SUM(amount) AS total_amount
                FROM transactions
                WHERE EXTRACT(MONTH FROM date) = @CurrentMonth
                AND EXTRACT(YEAR FROM date) = @CurrentYear
                GROUP BY collection;
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("CurrentMonth", currentMonth);
                        cmd.Parameters.AddWithValue("CurrentYear", currentYear);

                        using (var reader = cmd.ExecuteReader())
                        {
                            // Reset labels first
                            ResetLabels();

                            // Update labels with sums for each collection type
                            while (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("total_amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("total_amount"));

                                switch (collection)
                                {
                                    case "PET":
                                        label10.Text = $"{totalAmount}kg";
                                        break;
                                    case "LDPE":
                                        label14.Text = $"{totalAmount}kg";
                                        break;
                                    case "PP":
                                        label13.Text = $"{totalAmount}kg";
                                        break;
                                    case "HDPE":
                                        label12.Text = $"{totalAmount}kg";
                                        break;
                                    case "SUP":
                                        label11.Text = $"{totalAmount}kg";
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
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get the sum of amounts for each collection type across all transactions
                    string query = @"
            SELECT collection, SUM(amount) AS total_amount
            FROM transactions
            GROUP BY collection;
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            // Reset the labels before updating
                            ResetLabels();

                            // Update the labels with the sums for each collection type
                            while (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("total_amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("total_amount"));

                                switch (collection)
                                {
                                    case "PET":
                                        label16.Text = $"{totalAmount}kg";
                                        break;
                                    case "LDPE":
                                        label1.Text = $"{totalAmount}kg";
                                        break;
                                    case "PP":
                                        label2.Text = $"{totalAmount}kg";
                                        break;
                                    case "HDPE":
                                        label3.Text = $"{totalAmount}kg";
                                        break;
                                    case "SUP":
                                        label15.Text = $"{totalAmount}kg";
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

        private void ResetLabels()
        {
            label16.Text = "0kg";
            label1.Text = "0kg";
            label2.Text = "0kg";
            label3.Text = "0kg";
            label15.Text = "0kg";
        }

        private void UpdateNewestTransactions()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get the 4 newest transactions
                    string query = @"
                SELECT amount, collection, date
                FROM transactions
                ORDER BY date DESC
                LIMIT 4;
            ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            int count = 0;

                            // Reset transaction labels first
                            ResetTransactionLabels();

                            while (reader.Read())
                            {
                                decimal amount = reader.IsDBNull(reader.GetOrdinal("amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("amount"));
                                string collection = reader["collection"].ToString();
                                string transactionText = $"{collection} - {amount}kg";

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
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetTransactionLabels()
        {
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
        }

    }
}
