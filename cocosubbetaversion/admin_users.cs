using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class admin_users : Form
    {
        static string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

        public admin_users()
        {
            InitializeComponent();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            admin_order adminOrderForm = new admin_order();
            adminOrderForm.Show();
            this.Hide();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            //admin_products adminProductsForm = new admin_products();
            //adminProductsForm.Show();
            //this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            admin_payment adminPaymentsForm = new admin_payment();
            adminPaymentsForm.Show();
            this.Hide();
        }

        private void admin_users_Load(object sender, EventArgs e)
        {
            
            try
            {
                // Define the query to fetch data from the 'user' table
                string query = "SELECT User_id, Uname, Uemail, Upass, Urole, Menuid, SubDate, creditsLeft, is_subbed FROM `user`";

                // Create a connection to MySQL
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    // Create a MySqlDataAdapter to execute the query
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, mySqlConnection);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    mySqlConnection.Open(); // Open the connection before filling
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    datagrid_user_admin.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void datagrid_user_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
