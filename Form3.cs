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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form3 = new Form2();
            form3.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim(); // Admin inputs the user's email
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string collectionType = GetSelectedCollectionType();
            if (string.IsNullOrEmpty(collectionType))
            {
                MessageBox.Show("Please select a collection type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int amount;
            if (!int.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int total;
            if (!int.TryParse(txtTotal.Text, out total) || total <= 0)
            {
                MessageBox.Show("Invalid total. Please enter a positive number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get the User ID based on the email
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
                            MessageBox.Show("Email not found. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Step 2: Insert the transaction
                    string insertTransactionQuery = @"
                    INSERT INTO transactions (user_id, date, collection, amount, total) 
                    VALUES (@UserID, CURRENT_DATE, @Collection, @Amount, @Total)";
                    using (var cmd = new NpgsqlCommand(insertTransactionQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("UserID", userId);
                        cmd.Parameters.AddWithValue("Collection", collectionType);
                        cmd.Parameters.AddWithValue("Amount", amount);
                        cmd.Parameters.AddWithValue("Total", total);
                        cmd.ExecuteNonQuery();
                    }

                    // Step 3: Update the user's balance
                    string updateBalanceQuery = "UPDATE balance SET total = total + @Total WHERE user_id = @UserID";
                    using (var cmd = new NpgsqlCommand(updateBalanceQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("UserID", userId);
                        cmd.Parameters.AddWithValue("Total", total);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Transaction added and balance updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetSelectedCollectionType()
        {
            if (radioButton1.Checked) return "PET";
            if (radioButton2.Checked) return "LDPE";
            if (radioButton3.Checked) return "PP";
            if (radioButton4.Checked) return "HDPE";
            if (radioButton5.Checked) return "SUP";
            return null;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
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
    }
}
