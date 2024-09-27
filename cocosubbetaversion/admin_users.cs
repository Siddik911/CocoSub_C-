using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cocosubbetaversion
{
    public partial class admin_users : Form
    {
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
            admin_products adminProductsForm = new admin_products();
            adminProductsForm.Show();

            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //payments button

            admin_payment adminPaymentsForm = new admin_payment();
            adminPaymentsForm.Show();

            this.Hide();
        }
    }
}
