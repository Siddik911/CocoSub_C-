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
                    string insertQuery = "INSERT INTO orders (UId, OrderDate, MenuId) VALUES (@UId, @OrderDate, @MenuId)";
                    MySqlCommand command = new MySqlCommand(insertQuery, connection);

                    // Set the parameters for the query
                    command.Parameters.AddWithValue("@UId", 1); // Replace with actual user ID
                    command.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    command.Parameters.AddWithValue("@MenuId", selectedDrinkId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        succesfully_recived_order succesfully_recived_order = new succesfully_recived_order();
                        succesfully_recived_order.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
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
