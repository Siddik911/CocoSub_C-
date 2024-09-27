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
    public partial class admin_order : Form
    {
        public admin_order()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Products button
            admin_products form = new admin_products();
            form.Show();
            this.Hide();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            admin_users form = new admin_users();
            form.Show();
            this.Hide();
        }

        private void payment_button_Click(object sender, EventArgs e)
        {
            admin_payment form = new admin_payment();
            form.Show();
            this.Hide();
        }
    }
}
