using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class signup : Form
    {
        // Connection string to your MySQL database
        string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

        // Variable to store the role based on the checkbox state
        int role = 0;

        public signup()
        {
            InitializeComponent();
            // Subscribe to the KeyPress event for Enter key handling
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(signup_KeyPress);
        }

        // Event handler for the Enter key press
        private void signup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformSignup();
            }
        }

        // After successful sign up, open either admin_users or sub_plan form
        private void signup_Click(object sender, EventArgs e)
        {
            PerformSignup();
        }

        // Method to handle the signup logic
        private void PerformSignup()
        {
            // Retrieve user inputs from text boxes
            string name = nametext.Text;
            string email = emailtext.Text;
            string password = passwordtext.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            // Insert user data into the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Optional: custom logic for name validation can be added here
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        MessageBox.Show("Name cannot be empty.");
                        return;
                    }

                    // Optional: add custom validation for the password
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Password must be at least 6 characters long.");
                        return;
                    }

                    // Optional: email validation (basic format check)
                    if (!email.Contains("@") || !email.Contains("."))
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }

                    connection.Open();
                    string query = "INSERT INTO user (Uname, Uemail, Upass) VALUES (@name, @email, @password)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();

                    // Retrieve the last added User_id
                    string selectQuery = "SELECT MAX(User_id) FROM user";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    int userId = Convert.ToInt32(selectCommand.ExecuteScalar());

                    // Update the user table column Role of the last added User_id based on the checkbox
                    string updateQuery = "UPDATE user SET Urole = @role WHERE User_id = @userId";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@role", role);
                    updateCommand.Parameters.AddWithValue("@userId", userId);
                    updateCommand.ExecuteNonQuery();

                    // Set the UserId in the SessionManager
                    SessionManager.UserId = userId;

                    SignupUser(name, email);

                    // Redirect to the appropriate form based on role
                    if (role == 1)
                    {
                        // Open the admin_users form if the role is 1 (admin)
                        admin_users adminForm = new admin_users();
                        adminForm.Show();
                    }
                    else
                    {
                        // Open the sub_plan form if the role is 0 (normal user)
                        sub_plan subPlanForm = new sub_plan();
                        subPlanForm.Show();
                    }

                    // Hide the current signup form
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        // Password text change event handler
        private void passwordtext_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;
            string password = textBox.Text;
        }

        // Email text change event handler
        private void emailtext_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;
            string email = textBox.Text;
        }

        // Name text change event handler
        private void nametext_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;
            string name = textBox.Text;
        }

        // Checkbox event handler for password visibility toggle and role assignment
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            // If checkbox is checked, set role to 1, otherwise set to 0
            role = checkBox.Checked ? 1 : 0;
        }

        private void SignupUser(string userName, string email)
        {
            // Assuming userName and email are obtained after successful login/signup
            SessionManager.UserName = userName;
            SessionManager.Email = email;

            //// Optionally, navigate to the main form
            //var mainForm = new MainForm();
            //mainForm.Show();
            //this.Hide();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {

        }
    }
}
