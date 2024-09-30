using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace cocosubbetaversion
{
    public partial class sub_dash : Form
    {
        public sub_dash()
        {
            InitializeComponent();
        }


        string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";


        private void sub_dash_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //MessageBox.Show($"User ID: {SessionManager.UserId}", "User ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //sub_plan_name.Text = SessionManager.UserId.ToString();



                    // 1. Retrieve subscription plan name from the 'menu' table
                    string menuQuery = @"
                    SELECT Menu_name 
                    FROM menu 
                    JOIN user ON user.Menuid = menu.Menuid
                    WHERE user.User_id = @userId";

                    MySqlCommand menuCommand = new MySqlCommand(menuQuery, connection);
                    menuCommand.Parameters.AddWithValue("@userId", SessionManager.UserId);

                    // Use ExecuteReader to retrieve the data
                    using (MySqlDataReader reader = menuCommand.ExecuteReader())
                    {
                        if (reader.Read()) // Check if the reader has any rows
                        {
                            string subPlanName = reader["Menu_name"].ToString(); // Get the 'Menu_name' value
                            sub_plan_name.Text = subPlanName;
                        }
                        else
                        {
                            // If no rows were returned, assign default "No Plan"
                            sub_plan_name.Text = "No Plan";
                        }
                    }

                    user_name.Text = SessionManager.UserName;



                    // 2. Retrieve the subscription expiry date from the 'user' table and calculate remaining days
                    string subDateQuery = @"
                    SELECT SubDate 
                    FROM user 
                    WHERE User_id = @userId";

                    MySqlCommand subDateCommand = new MySqlCommand(subDateQuery, connection);
                    subDateCommand.Parameters.AddWithValue("@userId", SessionManager.UserId);

                    using (MySqlDataReader dateReader = subDateCommand.ExecuteReader())
                    {
                        if (dateReader.Read())
                        {
                            DateTime subDate = Convert.ToDateTime(dateReader["SubDate"]);
                            DateTime today = DateTime.Now;
                            TimeSpan remainingDays = subDate.AddMonths(1) - today; // Assuming a 1-month subscription period
                            expiry_date.Text = remainingDays.Days > 0 ? $"{remainingDays.Days} days left" : "Expired";
                        }
                    }




                    // 3. Retrieve the total credit from the 'user' table
                    string creditQuery = @"
                    SELECT CreditsLeft 
                    FROM user 
                    WHERE User_id = @userId";

                    MySqlCommand creditCommand = new MySqlCommand(creditQuery, connection);
                    creditCommand.Parameters.AddWithValue("@userId", SessionManager.UserId);

                    using (MySqlDataReader creditReader = creditCommand.ExecuteReader())
                    {
                        if (creditReader.Read())
                        {
                            credit_left_label.Text = " left credits";
                            int totalCredit =  Convert.ToInt32(creditReader["CreditsLeft"]) ;
                            credit_left_label.Text = totalCredit.ToString();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


        }



        //private void label2_Click(object sender, EventArgs e)
        //{

        //}

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

        private void description_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
