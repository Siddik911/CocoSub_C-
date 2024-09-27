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
            // Subscribe to the KeyPress event for Enter key handling
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(loginPage_KeyPress);
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            // Initialization logic if needed when the form loads
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        // Event handler for the Enter key press
        private void loginPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
            }
        }

        // Method to handle the login logic
        private void PerformLogin()
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
            if (ValidateLogin(email, password, out int isSubbed, out int role))
            {
                if (role == 1)
                {
                    // Redirect to admin_users form
                    admin_users adminDashboard = new admin_users();
                    this.Hide();  // Hide the login page
                    adminDashboard.Show();  // Show the admin_users form
                }
                else
                {
                    // Proceed with regular redirection based on is_subbed value
                    if (isSubbed == 1)
                    {
                        sub_dash subDashboard = new sub_dash();
                        this.Hide();
                        subDashboard.Show();
                    }
                    else
                    {
                        sub_plan subPlan = new sub_plan();
                        this.Hide();
                        subPlan.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to validate login credentials from the database
        private bool ValidateLogin(string email, string password, out int isSubbed, out int role)
        {
            isSubbed = 0;
            role = 0;

            // Query to check the user data from the database, including role and subscription status
            string query = "SELECT is_subbed, Role FROM user WHERE email = @Email AND pass = @Password";

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
                                // Retrieve the is_subbed and Role values
                                isSubbed = reader.GetInt32("is_subbed");
                                role = reader.GetInt32("Role");
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
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
