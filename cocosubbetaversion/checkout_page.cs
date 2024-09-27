using System;
using System.Windows.Forms;

namespace cocosubbetaversion
{
    public partial class checkout_page : Form
    {
        private readonly string _menuName;
        private readonly decimal _price;

        public checkout_page(string menuName, decimal price)
        {
            InitializeComponent();
            _menuName = menuName;
            _price = price;
        }

        private void checkout_page_Load(object sender, EventArgs e)
        {
            // Set the values to the respective UI elements when the page loads
            sub_plan_name.Text = _menuName;
            sub_cost.Text = _price.ToString("C"); // Format as currency
            sub_total_cost.Text = _price.ToString("C"); // Format as currency
            total_amount.Text = _price.ToString("C"); // Format as currency
        }
         
        private void apply_button_Click(object sender, EventArgs e)
        {
            if (discount_text.Text == "shaikat24")
            {
                decimal discountAmount = 5;
                decimal totalPrice = decimal.Parse(total_amount.Text.TrimStart('$'));
                decimal newTotalPrice = totalPrice - discountAmount;
                discount_amont.Text = discountAmount.ToString("C");
                total_amount.Text = newTotalPrice.ToString("C");
            }
            else
            {
                // Add logic to handle other cases or display an error message
            }
        }

        // Other event handlers can go here

        private void fullname_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_number_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void adress_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub_plan_nameClick(object sender, EventArgs e)
        {
            // This method can be used to handle click events on the plan name if needed
        }

        private void sub_cost_Click(object sender, EventArgs e)
        {
        }

        private void sub_total_cost_Click(object sender, EventArgs e)
        {

        }

        private void discount_amont_Click(object sender, EventArgs e)
        {
        }

        private void total_amount_Click(object sender, EventArgs e)
        {

        }

        private void back_buton_Click(object sender, EventArgs e)
        {
        }

        private void discount_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
