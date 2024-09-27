﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cocosubbetaversion
{
    public partial class admin_products : Form
    {
        // Define your connection string to MySQL database
        private readonly string connectionString = "Server=192.168.0.121;Database=cocodb;Uid=rafid;Pwd=admin;";

        public admin_products()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            LoadPaymentData(); // Load the data from the payment table
        }

        // Event handler for cell content click in the DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events here if needed
        }

        // Method to load data from the 'payment' table and bind it to the DataGridView
        private void LoadPaymentData()
        {
            try
            {
                // Create a connection to the MySQL database
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Define the query to select all data from the 'payment' table
                    string query = "SELECT * FROM payment";

                    // Create a MySQL command to execute the query
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Create a DataAdapter to fetch the data
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                        // Create a DataTable to hold the data
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with data fetched by the adapter
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the data retrieval
                MessageBox.Show("An error occurred while fetching the payment data: " + ex.Message);
            }
        }
    }
}
