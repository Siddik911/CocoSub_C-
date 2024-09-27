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
    public partial class sub_plan : Form
    {
        public sub_plan()
        {
            InitializeComponent();
        }

        private void plan_ent_button_Click(object sender, EventArgs e)
        {
            payment_details paymentDetailsForm = new payment_details();
            paymentDetailsForm.ShowDialog();

            this.Hide();

        }

        private void plan_lover_button_Click(object sender, EventArgs e)
        {
            payment_details paymentDetailsForm = new payment_details();
            paymentDetailsForm.ShowDialog();

            // Get data from SessionManager and show in the dialog box
            string data = SessionManager.Email;
            MessageBox.Show(data);

            this.Hide();
        }

        private void plan_com_button_Click(object sender, EventArgs e)
        {
            payment_details paymentDetailsForm = new payment_details();
            paymentDetailsForm.ShowDialog();

            // Get data from SessionManager and show in the dialog box
            string data = SessionManager.Email;
            MessageBox.Show(data);

            this.Hide();
        }
    }
}
