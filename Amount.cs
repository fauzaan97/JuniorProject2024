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
    public partial class Amount : Form
    {
        public Amount()
        {
            InitializeComponent();
        }

        private decimal GetUserBalanceByUsername(string username)
        {
            decimal balance = 0;

            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";
            string query = "SELECT total FROM balance WHERE user_id = (SELECT ID FROM users WHERE email = @Username)";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Username", username);
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


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Amount_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = SessionManager.GetEmail(); // Get the logged-in user's username
            decimal enteredAmount;

            // Ensure the amount entered in the TextBox is a valid decimal
            if (!decimal.TryParse(textBox1.Text, out enteredAmount))
            {
                MessageBox.Show("Please enter a valid amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the current balance of the user
            decimal currentBalance = GetUserBalanceByUsername(username);

            // Check if the entered amount is less than or equal to the balance
            if (enteredAmount > currentBalance)
            {
                MessageBox.Show("Your balance is not enough for this transaction.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // If the balance is sufficient, update the balance in the database
                string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

                string updateBalanceQuery = "UPDATE balance SET total = total - @Amount WHERE user_id = (SELECT ID FROM users WHERE email = @Username)";

                using (var conn = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (var cmd = new NpgsqlCommand(updateBalanceQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("Amount", enteredAmount);
                            cmd.Parameters.AddWithValue("Username", username);
                            cmd.ExecuteNonQuery();
                        }

                        Success successForm = new Success(enteredAmount);
                        successForm.Show();
                        Visible = false;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
