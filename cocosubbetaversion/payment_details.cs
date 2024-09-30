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
    public partial class payment_details : Form
    {

        private decimal subCost;
        public payment_details(decimal cost)
        {
            InitializeComponent();
            subCost = cost; // Assign subCost passed from checkout_page
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void payment_details_Load(object sender, EventArgs e)
        {
            total_amount.Text = this.subCost.ToString("C"); // Format as currency
        }

        private void cancel_payment_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sub_plan subPlanForm = new sub_plan();
            subPlanForm.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void pay_now_button_Click(object sender, EventArgs e)
        {
            // Validate card information before proceeding
            if (ValidatePaymentDetails())
            {
                // Save payment details to the database
                SavePaymentDetails();
            }
            else
            {
                // Show error message if payment details are not valid
                MessageBox.Show("Please enter valid payment details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePaymentDetails()
        {
            //// Example basic validation - you can add more robust checks for credit card info
            //if (string.IsNullOrWhiteSpace(name_on_card_text.Text) ||
            //    string.IsNullOrWhiteSpace(cardNo_text.Text) ||
            //    string.IsNullOrWhiteSpace(expiry_text.Text) ||
            //    string.IsNullOrWhiteSpace(cvv_text.Text))
            //{
            //    return false;
            //}

            //// Validate card number length (example assumes a 16-digit card number)
            //if (cardNo_text.Text.Length != 16 || !cardNo_text.Text.All(char.IsDigit))
            //{
            //    MessageBox.Show("Card number must be 16 digits.", "Invalid Card Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //// Validate expiry (example assumes format MM/YY)
            //if (!DateTime.TryParseExact(expiry_text.Text, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expiryDate))
            //{
            //    MessageBox.Show("Expiry date must be in MM/YY format.", "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //// Check if the expiry date is in the past
            //if (expiryDate < DateTime.Today)
            //{
            //    MessageBox.Show("The expiry date cannot be in the past.", "Invalid Expiry Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            //// Validate CVV (example assumes a 3-digit CVV)
            //if (cvv_text.Text.Length != 3 || !cvv_text.Text.All(char.IsDigit))
            //{
            //    MessageBox.Show("CVV must be 3 digits.", "Invalid CVV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return false;
            //}

            return true;
        }

        private void SavePaymentDetails()
        {
            decimal totalCredit = 0;
            string connectionString = "Server=localhost;Database=cocodb;Uid=root;Pwd=admin;";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction(); // Using transaction for multiple queries

                    try
                    {
                        //// Step 1: Insert into the payment table
                        //string paymentQuery = "INSERT INTO payment (amount, Payment_date, User_id, Menuid) VALUES (@amount, @paymentDate, @userId, @menuId)";
                        //using (MySqlCommand paymentCommand = new MySqlCommand(paymentQuery, connection, transaction))
                        //{
                        //    paymentCommand.Parameters.AddWithValue("@amount", subCost);
                        //    paymentCommand.Parameters.AddWithValue("@paymentDate", DateTime.Today);
                        //    paymentCommand.Parameters.AddWithValue("@userId", SessionManager.UserId); // Assuming this is the logged-in user's ID
                        //    paymentCommand.Parameters.AddWithValue("@menuId", SessionManager.menu_id); // Assuming this is the current menu ID
                        //    paymentCommand.ExecuteNonQuery();
                        //}

                        // Step 2: Fetch Total_credit from the menu table based on menuId
                        string totalCreditQuery = "SELECT Total_credit FROM menu WHERE Menuid = @menuId";
                        using (MySqlCommand creditCommand = new MySqlCommand(totalCreditQuery, connection, transaction))
                        {
                            creditCommand.Parameters.AddWithValue("@menuId", SessionManager.menu_id); // Assuming SessionManager.menu_id contains the menu ID
                            totalCredit = Convert.ToDecimal(creditCommand.ExecuteScalar());
                        }

                        // Step 3: Update the user table with menuId, SubDate, and credits_left
                        string userUpdateQuery = "UPDATE user SET Menuid = @menuId, SubDate = @subDate, CreditsLeft = @creditsLeft WHERE User_id = @userId";
                        using (MySqlCommand userCommand = new MySqlCommand(userUpdateQuery, connection, transaction))
                        {
                            userCommand.Parameters.AddWithValue("@menuId", SessionManager.menu_id);
                            userCommand.Parameters.AddWithValue("@subDate", DateTime.Today); // Storing current date as SubDate
                            userCommand.Parameters.AddWithValue("@creditsLeft", totalCredit); // Credits fetched from the menu table
                            userCommand.Parameters.AddWithValue("@userId", SessionManager.UserId); // Assuming this is the logged-in user's ID
                            userCommand.ExecuteNonQuery();
                        }

                        // Step 4: Update user subscription status
                        string updateUserMenuQuery = "UPDATE user SET is_subbed = 1 WHERE User_id = @userId AND Menuid = @menuId";
                        using (MySqlCommand updateUserMenuCommand = new MySqlCommand(updateUserMenuQuery, connection, transaction))
                        {
                            updateUserMenuCommand.Parameters.AddWithValue("@userId", SessionManager.UserId);
                            updateUserMenuCommand.Parameters.AddWithValue("@menuId", SessionManager.menu_id);
                            updateUserMenuCommand.ExecuteNonQuery();
                        }

                        // Commit transaction if all queries succeed
                        transaction.Commit();

                        // If successful, open the success form
                        succesful_subscriber subSuccess = new succesful_subscriber();
                        subSuccess.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        // Rollback transaction if any query fails
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //MessageBox.Show($"User ID: {SessionManager.UserId}\nMenu ID: {SessionManager.menu_id}\nCredits Left: {totalCredit}", "User Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void name_on_card_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void cardNo_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void expiry_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void cvv_text_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
