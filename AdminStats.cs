using Npgsql;
using System;
using System.Collections.Generic;

namespace Treashure
{
    public class AdminStats : IStats
    {
        public Dictionary<string, decimal> CollectionAmounts { get; private set; }

        // Constructor
        public AdminStats()
        {
            CollectionAmounts = new Dictionary<string, decimal>();
        }

        // Update collection amounts for the current month for all users
        public void UpdateCollectionAmountsForThisMonth()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get sums of amounts for all users in the current month
                    string query = @"
                    SELECT collection, SUM(amount) AS total_amount
                    FROM transactions
                    WHERE EXTRACT(MONTH FROM date) = @Month
                    AND EXTRACT(YEAR FROM date) = @Year
                    GROUP BY collection;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
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
                    throw new Exception($"Error updating admin collection amounts for this month: {ex.Message}");
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

                    // Query to get sums of amounts for all users in the current month
                    string query = @"
                    SELECT collection, SUM(amount) AS total_amount
                    FROM transactions
                    GROUP BY collection;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
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
                    throw new Exception($"Error updating collection amounts for all users in this month: {ex.Message}");
                }
            }
        }
        // Update the newest transactions for all users
        public void UpdateNewestTransactions()
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to get the most recent transactions for all users
                    string query = @"
                    SELECT collection, amount, date
                    FROM transactions
                    ORDER BY date DESC
                    LIMIT 4;
                ";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Month", DateTime.Now.Month);
                        cmd.Parameters.AddWithValue("Year", DateTime.Now.Year);

                        using (var reader = cmd.ExecuteReader())
                        {
                            // Process the newest transactions
                            while (reader.Read())
                            {
                                string collection = reader["collection"].ToString();
                                decimal amount = reader.IsDBNull(reader.GetOrdinal("amount")) ? 0 : reader.GetDecimal(reader.GetOrdinal("amount"));
                                DateTime date = reader.GetDateTime(reader.GetOrdinal("date"));

                                // You can store or process these results as needed
                                Console.WriteLine($"Collection: {collection}, Amount: {amount}, Date: {date}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error updating newest transactions: {ex.Message}");
                }
            }
        }
    }
}
