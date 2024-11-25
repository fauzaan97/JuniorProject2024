using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treashure
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeft,
            int nTop,
            int nRight,
            int rBottom,
            int nWidthEllipse,
            int nHeightEllipse
            );
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=Postgres;Password=52442006;Database=Treashure";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private void Signup_Load(object sender, EventArgs e)
        {
            btnSignUp2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp2.Width, btnSignUp2.Height, 30, 30));
            btnLogin2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSignUp.Width, btnSignUp.Height, 30, 30));
            conn = new NpgsqlConnection(connstring);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Visible = false;
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;         // Name from textBox2
            string email = textBox1.Text;        // Email from textBox1
            string username = txtUsername.Text;  // Username from txtUsername
            string password = txtPassword.Text;  // Password from txtPassword
            string confirmPassword = textBox3.Text; // Confirm Password from textBox3

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Password doesn't match.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if username already exists
            else if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already taken.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If validations passed, proceed to insert the new user
            else if (CreateUser(name, email, username, password))
            {
                MessageBox.Show("User created successfully!", "Sign Up Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, clear the fields or redirect to login form
            }
            else
            {
                MessageBox.Show("There was an error creating the user.", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsUsernameTaken(string username)
        {
            bool isTaken = false;
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";
            string query = "SELECT COUNT(*) FROM users WHERE username = @Username";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Username", username);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            isTaken = true; // Username is already taken
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isTaken;
        }

        // Create a new user in the database
        private bool CreateUser(string name, string email, string username, string password)
        {
            string connectionString = "Host=treashuredb.c304g4oao6vf.ap-southeast-2.rds.amazonaws.com;Port=5432;Database=TreashureDB;Username=postgres;Password=postgres;SSL Mode=Require;Trust Server Certificate=true;";

            // First, check if the username is already taken
            string checkUsernameQuery = "SELECT COUNT(*) FROM users WHERE username = @Username";
            int usernameCount = 0;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the username is already taken
                    using (var cmd = new NpgsqlCommand(checkUsernameQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("Username", username);
                        usernameCount = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // If the username already exists, show an error and return false
                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Step 2: Insert the new user into the 'users' table
                    string insertUserQuery = "INSERT INTO users (name, email, username, password, role) VALUES (@Name, @Email, @Username, @Password, 'user')";
                    using (var cmd = new NpgsqlCommand(insertUserQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("Name", name);
                        cmd.Parameters.AddWithValue("Email", email);
                        cmd.Parameters.AddWithValue("Username", username);
                        cmd.Parameters.AddWithValue("Password", password);
                        cmd.ExecuteNonQuery();
                    }

                    // Step 3: After the user is created, get their user_id
                    string getUserIdQuery = "SELECT ID FROM users WHERE email = @Email";
                    int userId = 0;
                    using (var cmd = new NpgsqlCommand(getUserIdQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("Email", email);
                        var result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                    // Step 4: Insert initial balance for the newly created user
                    bool balanceInserted = InsertInitialBalancesForUsers(userId, conn);

                    if (!balanceInserted)
                    {
                        MessageBox.Show("Error setting initial balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Return false in case of any exception
                }
            }
        }

        private bool InsertInitialBalancesForUsers(int userId, NpgsqlConnection conn)
        {
            try
            {
                string insertBalanceQuery = "INSERT INTO balance (user_id, total) VALUES (@UserId, 0)";
                using (var cmd = new NpgsqlCommand(insertBalanceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("UserId", userId);
                    cmd.ExecuteNonQuery();
                }
                return true; // Balance inserted successfully
            }
            catch (Exception)
            {
                return false; // Return false if balance insertion fails
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
