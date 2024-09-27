using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class admin_products : Form
    {
        private readonly string connectionString = "Server=192.168.0.121;Database=cocodb;Uid=rafid;Pwd=admin;";

        public admin_products()
        {
            InitializeComponent();
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            DataTable paymentTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM payment";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(paymentTable);
                }
            }

            dataGridView1.DataSource = paymentTable;
        }
    }
}
