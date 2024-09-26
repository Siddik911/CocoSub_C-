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
    public partial class welcomepage : Form
    {
        public welcomepage()
        {
            InitializeComponent();
        }

        private void newuser_Click(object sender, EventArgs e)
        {
            signup signupForm = new signup();
            signupForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alreadyuser_Click(object sender, EventArgs e)
        {
            loginPage loginForm = new loginPage();
            loginForm.Show();
            this.Hide();
        }
    }
}
