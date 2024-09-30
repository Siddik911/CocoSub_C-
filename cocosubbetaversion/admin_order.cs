using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics; // For Debugging

namespace cocosubbetaversion
{
    public partial class admin_order : Form
    {
        // Connection string to connect to the MySQL database
        static string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

        public admin_order()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.admin_order_Load);
        }

        // Load event for the form
        private void admin_order_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        // Method to load data from 'orders' table and bind to DataGridView
        private void LoadOrderData()
        {
            try
            {
                // Define the query to fetch data from the 'orders' table
                string query = "SELECT UId, OrderDate, MenuId, Oid FROM `orders`";

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    // Create a MySqlDataAdapter to execute the query
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, mySqlConnection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Open the connection before filling
                    mySqlConnection.Open();

                    // Fill the DataTable with data from the database
                    int rowsFetched = dataAdapter.Fill(dataTable);

                    // Debugging and information: Output row count
                    Debug.WriteLine("Rows fetched: " + rowsFetched);

                    // Bind the DataTable to the DataGridView
                    gridview_order_admin.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // If there's an error, show a message box with the error details
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Products button functionality
            //admin_products form = new admin_products();
            //form.Show();
            //this.Hide();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            // Navigate to admin_users form
            admin_users form = new admin_users();
            form.Show();
            this.Hide();
        }

        private void payment_button_Click(object sender, EventArgs e)
        {
            // Navigate to admin_payment form
            admin_payment form = new admin_payment();
            form.Show();
            this.Hide();
        }

        private void gridview_order_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
