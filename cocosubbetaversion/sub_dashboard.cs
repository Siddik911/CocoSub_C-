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
    public partial class sub_dash : Form
    {
        public sub_dash()
        {
            InitializeComponent();
        }

        private void sub_dash_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void log_out_button_Click(object sender, EventArgs e)
        {
            // Redirect to WelcomePage form
            welcomepage welcomePage = new welcomepage();
            welcomePage.Show();
            this.Hide();
        }

        private void redeem_button_Click(object sender, EventArgs e)
        {
            // Create an instance of the RedeemCredit form
            redeem_credit redeem_credit = new redeem_credit();

            // Show the RedeemCredit form
            redeem_credit.Show();

            // Hide the current form
            this.Hide();
        }
    }
}
