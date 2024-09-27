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
    public partial class payment_details : Form
    {
        public payment_details()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void payment_details_Load(object sender, EventArgs e)
        {

        }

        private void cancel_payment_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sub_plan subPlanForm = new sub_plan();
            subPlanForm.Show();
            this.Hide();
        }
    }
}
