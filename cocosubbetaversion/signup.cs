using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class signup : Form
    {
        // Connection string to your MySQL database
        string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

        public signup()
        {
            InitializeComponent();
        }

        // Event for when the signup button is clicked
        private void signup_Click(object sender, EventArgs e)
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
                    string query = "INSERT INTO user (Name, Email, Pass) VALUES (@name, @email, @password)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    command.ExecuteNonQuery();

                    MessageBox.Show("User registered successfully!");
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

        // Checkbox event handler for password visibility toggle
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
        }
    }
}
