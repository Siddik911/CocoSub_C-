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
    public partial class succesful_subscriber : Form
    {
        public succesful_subscriber()
        {
            InitializeComponent();
        }

        private void succesful_subscriber_Load(object sender, EventArgs e)
        {

        }

        private void redeem_button_Click(object sender, EventArgs e)
        {
            sub_dash sub_dashboard = new sub_dash();
            sub_dashboard.Show();
            this.Hide();
        }
    }
}
