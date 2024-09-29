using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class loginPage : Form
    {
        // Connection string to your MySQL database
        private readonly string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

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
            PerformLogin();
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
                // Fetch UserName and UserId
                if (LoginUser(email))
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
                        // Proceed with regular redirection based on isSubbed value
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
                    MessageBox.Show("Unable to fetch user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string query = "SELECT is_subbed, URole FROM user WHERE Uemail = @Email AND Upass = @Password";

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
                                // Retrieve the isSubbed and role values
                                isSubbed = reader.GetInt32("is_subbed");
                                role = reader.GetInt32("URole");
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

        // Method to login the user and set SessionManager variables
        private bool LoginUser(string email)
        {
            // Query to fetch User_id and Uname based on the email
            string query = "SELECT User_id, Uname FROM user WHERE Uemail = @Uemail";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Uemail", email);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set UserId and UserName in SessionManager
                                SessionManager.UserId = reader.GetInt32("User_id");
                                SessionManager.UserName = reader.GetString("Uname");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("User not found. Please check the email.");
                                return false; // Exit if user not found
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching User ID or UserName: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
