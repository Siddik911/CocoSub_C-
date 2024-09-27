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
        private int menu_id_num; // Declare a private field to store the menu_id

        public sub_plan()
        {
            InitializeComponent();
        }

        private void plan_ent_button_Click(object sender, EventArgs e)
        {
            menu_id_num = 1; // Assign the menu_id value to the field
            
           
            SubPlanSession(menu_id_num); // Call the method to set the session value

            checkout_page checkout_PageForm = new checkout_page();
            checkout_PageForm.ShowDialog();

            this.Hide();
        }

        private void plan_lover_button_Click(object sender, EventArgs e)
        {
            menu_id_num = 2; // Assign the menu_id value to the field

            SubPlanSession(menu_id_num); // Call the method to set the session value

            checkout_page checkout_PageForm = new checkout_page();
            checkout_PageForm.ShowDialog();


            this.Hide();
        }

        private void plan_com_button_Click(object sender, EventArgs e)
        {
            menu_id_num = 3; // Assign the menu_id value to the field
            SubPlanSession(menu_id_num); // Call the method to set the session value

            checkout_page checkout_PageForm = new checkout_page();
            checkout_PageForm.ShowDialog();

            this.Hide();
        }

        private void SubPlanSession(int menu_id_num)
        {
            // Assuming userName and email are obtained after successful login/signup
            SessionManager.menu_id = menu_id_num;
        }
    }
}
