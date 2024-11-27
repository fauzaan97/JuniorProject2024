using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Treashure
{
    class UserStats : IStats
    {
        // Email specific to the user
        private string _email;
        public Dictionary<string, decimal> CollectionAmounts { get; private set; }

        // Constructor
        public UserStats(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            _email = email;
            CollectionAmounts = new Dictionary<string, decimal>();
        }

        // Update collection amounts for the current month (user-specific)
        public void UpdateCollectionAmountsForThisMonth()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string getUserIdQuery = "SELECT ID FROM users WHERE email = @Email";
                    int userId = 0;

                    using (var cmd = new NpgsqlCommand(getUserIdQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", SessionManager.GetEmail());
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

                    // Query to get sums of amounts for the user in the current month
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
                        cmd.Parameters.AddWithValue("Email", _email);
                        cmd.Parameters.AddWithValue("Month", DateTime.Now.Month);
                        cmd.Parameters.AddWithValue("Year", DateTime.Now.Year);

                        using (var reader = cmd.ExecuteReader())
                        {
                            CollectionAmounts.Clear(); // Clear previous data

                            while (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("total_amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("total_amount"));
                                CollectionAmounts[collection] = totalAmount;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating user collection amounts for this month: {ex.Message}");
                }
            }
        }
        public void UpdateCollectionAmounts()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get sums of amounts for the user without time constraint
                    string query = @"
                    SELECT collection, SUM(amount) AS total_amount
                    FROM transactions
                    WHERE email = @Email
                    GROUP BY collection;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", _email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            CollectionAmounts.Clear(); // Clear previous data

                            while (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal totalAmount = reader.IsDBNull(reader.GetOrdinal("total_amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("total_amount"));
                                CollectionAmounts[collection] = totalAmount;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating user collection amounts: {ex.Message}");
                }
            }
        }

        // Update the most recent transaction for the user (user-specific)
        public void UpdateNewestTransactions()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get the most recent transaction for the user
                    string query = @"
                    SELECT collection, amount, date
                    FROM transactions
                    WHERE email = @Email
                    ORDER BY date DESC
                    LIMIT 4;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", _email);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal amount = reader.IsDBNull(reader.GetOrdinal("amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("amount"));
                                DateTime date = reader.IsDBNull(reader.GetOrdinal("date")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("date"));

                                // You could store this in a class property, print it, or display it in a label, depending on your needs.
                                Console.WriteLine($"Most recent transaction: Collection: {collection}, Amount: {amount}kg, Date: {date}");
                            }
                            else
                            {
                                Console.WriteLine("No transactions found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating the newest transaction for user: {ex.Message}");
                }
            }
        }
    }

}
