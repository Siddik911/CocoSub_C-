using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class sub_plan : Form
    {
        private readonly string connectionString = "Server=192.168.0.121;Database=cocodb;Uid=rafid;Pwd=admin;";

        public sub_plan()
        {
            InitializeComponent();
        }

        private void plan_ent_button_Click(object sender, EventArgs e)
        {
            HandlePlanSelection(1);
        }

        private void plan_lover_button_Click(object sender, EventArgs e)
        {
            HandlePlanSelection(2);
        }

        private void plan_com_button_Click(object sender, EventArgs e)
        {
            HandlePlanSelection(3);
        }

        // Fetch menu details from the database and pass them to checkout_page
        private void HandlePlanSelection(int menuId)
        {
            var menuDetails = GetMenuDetails(menuId);

            if (menuDetails != null)
            {
                checkout_page checkoutPageForm = new checkout_page(menuDetails.Value.menuName, menuDetails.Value.price);
                checkoutPageForm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error fetching menu details.");
            }
        }

        // Pure function to fetch menu details from the database
        private (string menuName, decimal price)? GetMenuDetails(int menuId)
        {
            string query = "SELECT menu_name, price FROM menu WHERE menu_id = @menuId";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@menuId", menuId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string menuName = reader.GetString("menu_name");
                                decimal price = reader.GetDecimal("price");
                                return (menuName, price);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }
            return null;
        }
    }
}
