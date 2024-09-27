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
    public partial class redeem_credit : Form
    {
        public redeem_credit()
        {
            InitializeComponent();
        }

        private void submit_order_Click(object sender, EventArgs e)
        {

        }

        private void go_home_screen_Click(object sender, EventArgs e)
        {
            sub_dash subDashForm = new sub_dash();
            subDashForm.Show();
            this.Hide();
        }
    }
}
