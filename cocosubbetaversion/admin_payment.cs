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
    public partial class admin_payment : Form
    {
        public admin_payment()
        {
            InitializeComponent();
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
            admin_products form = new admin_products();
            form.Show();
            this.Hide();
        }
    }
}
