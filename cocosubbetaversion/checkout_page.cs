using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class checkout_page : Form
    {
        protected decimal subCost;
        // Connection string for MySQL database
        string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";
        MySqlConnection connection;
        MySqlCommand command;

        public checkout_page()
        {
            InitializeComponent();
            // Fetch the menu name when the form loads
            //UpdateSubPlanName();
        }



        // Event handler for clicking the sub_plan_name (if still needed)
        public void sub_plan_nameClick(object sender, EventArgs e)
        {
            //UpdateSubPlanName(); // Fetch the menu name again if clicked
        }

        // Event handler for applying the discount
        private void apply_button_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the discount code is correct
                if (discount_text.Text == "shaikat24")
                {
                    // Apply a $5 discount
                    decimal discountAmount = 5;
                    decimal totalPrice = decimal.Parse(total_amount.Text.TrimStart('$'));
                    decimal newTotalPrice = totalPrice - discountAmount;

                    // Update discount and total amount on the U
                    // 

                    discount_amont.Text = discountAmount.ToString("C");
                    total_amount.Text = newTotalPrice.ToString("C");
                }
                else
                {
                    MessageBox.Show("Invalid discount code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying discount: {ex.Message}");
            }
        }

        // Event handler for navigating to the payment details form
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Pass the subCost to the payment_details form
            payment_details paymentDetailsForm = new payment_details(subCost);
            this.Hide();
            paymentDetailsForm.Show();
        }


        private void checkout_page_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null; // Declare the reader variable outside the try block

            try
            {
                // Open the database connection
                connection = new MySqlConnection(connectionString);
                connection.Open();

                int menuId = SessionManager.menu_id;

                // Create a SQL query to fetch the menu name and sub_cost
                string query = $"SELECT Menu_name, price FROM menu WHERE Menuid = {menuId}";

                command = new MySqlCommand(query, connection);

                // Execute the query and retrieve the menu name and sub_cost
                reader = command.ExecuteReader(); // Assign the reader variable here

                if (reader.Read())
                {
                    string menuName = reader.GetString("Menu_name");
                    subCost = reader.GetDecimal("price");

                    // Set the fetched menu name and sub_cost to the labels
                    sub_plan_name.Text = menuName;
                    sub_cost.Text = subCost.ToString();
                }

                // Close the reader and the connection
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching menu name: {ex.Message}");
            }
            finally
            {
                // Close the reader and the connection in the finally block
                if (reader != null)
                {
                    reader.Close();
                }

                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // You can add other event handlers or methods here as necessary
    }
}
