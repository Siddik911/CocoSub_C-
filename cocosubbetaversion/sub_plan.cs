using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class sub_plan : Form
    {
        private readonly string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";

        public sub_plan()
        {
            InitializeComponent();
        }

        private void plan_ent_button_Click(object sender, EventArgs e)
        {
            HandlePlanSelection(1);
        }

        private void plan_lover_button_Click(object sender, EventArgs e)
        {
            HandlePlanSelection(2);
        }

        private void plan_com_button_Click(object sender, EventArgs e)
        {
            HandlePlanSelection(3);
        }

        // Fetch menu details from the database and pass them to checkout_page
        private void HandlePlanSelection(int menuId)
        {
            if (menuId != null)
            {
                SessionManager.menu_id = menuId;
                
                this.Hide();
                checkout_page checkoutPage = new checkout_page();

                checkoutPage.Show();
            }
        }
    }
}
