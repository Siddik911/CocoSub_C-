using System;
using System.Data;
using MySql.Data.MySqlClient; // Make sure you are using this library
using System.Windows.Forms;

namespace cocosubbetaversion
{
    public partial class redeem_credit : Form
    {
        // Connection string for MySQL
        string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

        public redeem_credit()
        {
            InitializeComponent();
            LoadDrinkList(); // Load drink list when the form is initialized
        }

        private void LoadDrinkList()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT FoodId, FoodName FROM food"; // Assuming 'food' is the table for drinks
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Assuming drink_list is a ListBox or ComboBox
                        drink_list.Items.Add(new { Text = reader["FoodName"].ToString(), Value = reader["FoodId"].ToString() });
                    }
                    drink_list.DisplayMember = "Text"; // Set the display member for the list
                    drink_list.ValueMember = "Value";   // Set the value member for the list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading drinks: " + ex.Message);
                }
            }
        }

        private void submit_order_Click(object sender, EventArgs e)
        {
            if (drink_list.SelectedItem != null)
            {
                var selectedDrink = drink_list.SelectedItem;
                string selectedDrinkId = selectedDrink.GetType().GetProperty("Value").GetValue(selectedDrink).ToString();



                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Transaction to handle both insert and update together
                    MySqlTransaction transaction = null;

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Begin transaction
                        transaction = connection.BeginTransaction();

                        // Insert the order into the orders table
                        string insertQuery = "INSERT INTO orders (UId, OrderDate, MenuId) VALUES (@UId, @OrderDate, @MenuId)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection, transaction);

                        // Set the parameters for the insert query
                        insertCommand.Parameters.AddWithValue("@UId", SessionManager.UserId);
                        insertCommand.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                        insertCommand.Parameters.AddWithValue("@MenuId", selectedDrinkId);

                        // Execute the insert command
                        insertCommand.ExecuteNonQuery();

                        // Update CreditsLeft in the user table, reducing it by 1
                        string updateCreditsQuery = "UPDATE user SET CreditsLeft = CreditsLeft - 1 WHERE User_id = @UserId";
                        MySqlCommand updateCreditsCommand = new MySqlCommand(updateCreditsQuery, connection, transaction);

                        // Set the parameter for the update query
                        updateCreditsCommand.Parameters.AddWithValue("@UserId", SessionManager.UserId);

                        // Execute the update command
                        updateCreditsCommand.ExecuteNonQuery();

                        // Commit the transaction
                        transaction.Commit();

                        // Show success form
                        succesfully_recived_order succesfully_recived_order = new succesfully_recived_order();
                        succesfully_recived_order.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        // Rollback the transaction in case of an error
                        if (transaction != null)
                        {
                            transaction.Rollback();
                        }

                        // Show the error message
                        MessageBox.Show("Error submitting order: " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a drink to order.");
            }
        }

        private void go_home_screen_Click(object sender, EventArgs e)
        {
            sub_dash subDashForm = new sub_dash();
            subDashForm.Show();
            this.Hide();
        }

        private void drink_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // You can implement additional logic when the drink selection changes
        }

        private void special_instraction_TextChanged(object sender, EventArgs e)
        {
            // Logic for handling special instructions can be added here
        }
    }
}
