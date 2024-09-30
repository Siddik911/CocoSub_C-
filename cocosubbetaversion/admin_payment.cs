using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class admin_payment : Form
    {
        public admin_payment()
        {
            InitializeComponent();

            this.Load += new System.EventHandler(this.admin_payment_Load);
        }



        private void user_button_Click(object sender, EventArgs e)
        {
            admin_users form = new admin_users();
            form.Show();
            this.Hide();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            admin_order form = new admin_order();
            form.Show();
            this.Hide();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            //admin_products form = new admin_products();
            //form.Show();
            //this.Hide();
        }

        private void admin_payment_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

            string query = "SELECT User_id, Amount, Payment_date, Menuid, Payment_id FROM payment";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridview_payment_admin.DataSource = dataTable;
            }
        }


        private void payment_button_Click(object sender, EventArgs e)
        {

        }
    }
}
