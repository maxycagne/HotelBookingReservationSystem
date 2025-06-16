

using BookingReservationSystem.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookingReservationSystem.User_Control_Client
{
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        // SQL connection string to connect to the database
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");
        UserControl5 user5 = new UserControl5(); // Instance of another user control for refreshing names

        // Method to clear input fields
        public void Clear()
        {
            customerName.Clear(); // Clear the customer name field
            contactNum.Clear(); // Clear the contact number field
            nameCustomerUpdate.Clear(); // Clear the customer update name field
            nameCustumerSearch.Clear(); // Clear the customer search name field
            contactNumUpdate.Clear(); // Clear the contact number update field
            gender.Text = ""; // Reset the gender selection
            genderUpdate.Text = ""; // Reset the gender update selection
        }

        // Method to refresh names in UserControl5
        public void RefreshName()
        {
            user5.RefreshName();// Call RefreshName method in UserControl5
        }

        // Event handler for Add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (customerName.Text == "" || gender.SelectedItem == null || contactNum.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Open the SQL connection if it is not already open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Check if the customer name already exists in the database
                    string checkRoomNum = "SELECT * FROM Customer WHERE Name = @name";
                    using (SqlCommand checkRoomNumCmd = new SqlCommand(checkRoomNum, connect))
                    {
                        checkRoomNumCmd.Parameters.AddWithValue("@name", customerName.Text.Trim());
                        SqlDataReader reader = checkRoomNumCmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Name already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            reader.Close();
                        }
                    }

                    // Insert the new customer data into the database
                    string insertData = "INSERT INTO Customer (Name, ContactNum,Gender) " +
                                        "VALUES (@name, @contactNum,  @gender)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@name", customerName.Text.Trim()); // Add parameter for customer name, trimming any leading or trailing whitespace
                        cmd.Parameters.AddWithValue("@contactNum", contactNum.Text); // Add parameter for contact number
                        cmd.Parameters.AddWithValue("@gender", gender.Text); // Add parameter for gender


                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Created Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    RefreshName();// Refresh names in UserControl5
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        // Connection string for SQL database
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";
        
        // Method to bind data to the grid view
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable(); // Create a new DataTable
                        adapter.Fill(dataTable); // Fill the DataTable with data from the database
                        dataGridView2.DataSource = dataTable; // Bind data to the grid view
                    }
                }
            }
        }

        // Event handler for Update button click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                using (SqlConnection connect = new SqlConnection(connectionString))
                {

                    connect.Open();// Open the database connection
                    // Update customer data in the database
                    string query = "UPDATE Customer SET Name = @name, ContactNum = @contactNum, Gender = @gender WHERE Name = @name";


                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@name", nameCustomerUpdate.Text);
                        cmd.Parameters.AddWithValue("@contactNum", contactNumUpdate.Text);
                        cmd.Parameters.AddWithValue("@gender", genderUpdate.Text);


                        int rowsAffected = cmd.ExecuteNonQuery();// Execute the update command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");  // Show success message if rows were updated
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided room number."); // Show error message if no rows were affected
                        }
                    }
                    RefreshName();// Refresh names in UserControl5
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Event handler for Delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Delete customer data from the database
                    string query = "DELETE FROM Customer WHERE Name = @name";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@name", nameCustomerUpdate.Text); // Set the parameter for the name
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");// Show success message if rows were deleted
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided room number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();// Open the database connection
                    // Search for customer data in the database
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE Name = @name", connection))
                    {
                        command.Parameters.AddWithValue("@name", nameCustumerSearch.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable(); // Create a new DataTable
                            adapter.Fill(dataTable); // Fill the DataTable with data from the database
                            dataGridView2.DataSource = dataTable; // Bind search results to the grid view
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for tab selection to bind grid data
        private void tabAddClient_Selected(object sender, TabControlEventArgs e)
        {
            this.BindGrid();// Bind data to the grid view when the tab is selected
        }

        // Event handler to ensure only digits are entered for contact number
        private void contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is not a digit or control key
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Event handler to ensure only digits are entered for contact number update
        private void contactNumUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Event handler to clear fields when tab is left
        private void tabPage1_Leave(object sender, EventArgs e)
        {
            Clear(); // Clear input fields when leaving the tab
        }

        // Event handler to clear fields when tab is left
        private void addClient_Leave(object sender, EventArgs e)
        {
            Clear(); // Clear input fields when leaving the tab
        }
        // Event handler to clear fields when tab is left
        private void searchClientUser_Leave(object sender, EventArgs e)
        {
            Clear();// Clear input fields when leaving the tab
        }

        private void contactNum_TextChanged(object sender, EventArgs e)
        {
            // Ensure contact number starts with "+63"
            if (!contactNum.Text.StartsWith("+63"))
            {
                contactNum.Text = "+63"; // Prepend "+63" to the contact number
                contactNum.SelectionStart = contactNum.Text.Length; // Move cursor to the end
            }

            // Limit the length of the contact number to 13 characters
            if (contactNum.Text.Length > 13)
            {
                contactNum.Text = contactNum.Text.Substring(0, 13); // Trim excess characters
                contactNum.SelectionStart = contactNum.Text.Length; // Move cursor to the end
            }
        }

        private void contactNumUpdate_TextChanged(object sender, EventArgs e)
        {
            if (!contactNumUpdate.Text.StartsWith("+63"))
            {
                contactNumUpdate.Text = "+63";
                contactNumUpdate.SelectionStart = contactNumUpdate.Text.Length;
            }


            if (contactNumUpdate.Text.Length > 13)
            {
                contactNumUpdate.Text = contactNumUpdate.Text.Substring(0, 13);
                contactNumUpdate.SelectionStart = contactNumUpdate.Text.Length;
            }
        }
    }
}