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

            // Call the method to check login credentials and handle redirection
            var loginResult = ValidateLogin(email, password);
            if (loginResult.isValid)
            {
                // Redirect based on the role and subscription status
                if (loginResult.role == 1)
                {
                    // Redirect to admin dashboard
                    admin_users adminDashboard = new admin_users();
                    this.Hide();
                    adminDashboard.Show();
                }
                else
                {
                    if (loginResult.isSubbed == 1)
                    {
                        // Redirect to subscription dashboard
                        sub_dash dashboard = new sub_dash();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        // Redirect to subscription plan page
                        sub_plan subscriptionPlan = new sub_plan();
                        this.Hide();
                        subscriptionPlan.Show();
                    }
                }

                // Assuming userName is retrieved from the database after successful login
                string userName = "User"; // Replace with actual userName retrieval logic
                LoginUser(userName, email);
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate login credentials from the database
        private (bool isValid, int role, int isSubbed) ValidateLogin(string email, string password)
        {
            // Query to retrieve role and subscription status based on email and password
            string query = "SELECT Role, is_subbed FROM user WHERE email = @Email AND pass = @Password";

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

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Retrieve the role and subscription status
                                int role = reader.GetInt32("Role");
                                int isSubbed = reader.GetInt32("is_subbed");
                                return (true, role, isSubbed); // Login successful
                            }
                            else
                            {
                                // No user found with given email and password
                                return (false, 0, 0); // Login failed
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, 0, 0); // Login failed due to error
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
            // Toggle password visibility based on checkbox state
            login_pass_text.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void LoginUser(string userName, string email)
        {
            // Assuming userName and email are obtained after successful login/signup
            SessionManager.UserName = userName;
            SessionManager.Email = email;

            //// Optionally, navigate to the main form
            //var mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
        }
    }
}
