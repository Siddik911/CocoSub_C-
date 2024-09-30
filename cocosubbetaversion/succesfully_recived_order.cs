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
    public partial class succesfully_recived_order : Form
    {
        public succesfully_recived_order()
        {
            InitializeComponent();
        }

        private void GO_HOMRPAGE_BUTTON_Click(object sender, EventArgs e)
        {
            sub_dash sub_Dash = new sub_dash();
            sub_Dash.Show();
            this.Hide();
        }
    }
}
