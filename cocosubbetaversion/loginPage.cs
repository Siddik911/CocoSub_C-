using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class loginPage : Form
    {
        // Connection string to your MySQL database
        private readonly string connectionString = "Server=192.168.0.121;Database=cocodb;Uid=rafid;Pwd=admin;";

        public loginPage()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            // Initialization logic if needed when the form loads
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            // Get the email and password from the input fields
            string email = login_name_text.Text.Trim();
            string password = login_pass_text.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Call the method to check login credentials
            if (ValidateLogin(email, password))
            {
                // Open the sub_dash form directly after successful login
                sub_dash dashboard = new sub_dash();
                this.Hide();  // Hide the login page
                dashboard.Show();  // Show the sub_dash form
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate login credentials from the database
        private bool ValidateLogin(string email, string password)
        {
            // Query to check if the user exists with the given email and password
            string query = "SELECT COUNT(*) FROM user WHERE email = @Email AND pass = @Password";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Execute the query and get the result
                        int result = Convert.ToInt32(cmd.ExecuteScalar());

                        // If the result is 1, login is successful
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void login_name_text_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling text change in email field, if needed
        }

        private void login_pass_text_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling text change in password field, if needed
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If you want to implement "show password" functionality, you can do it here
            login_pass_text.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
