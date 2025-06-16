using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingReservationSystem
{
    public partial class AdminChangePass : Form
    {
        public AdminChangePass()
        {
            InitializeComponent();
        }

        // Connection string to connect to the database
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";
        // Event handler for the Change Password button click
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Extracting input values
            string username = inputUsernameAdmin.Text.Trim();
            string newPassword = inputPasswordAdmin.Text.Trim();
            string contact = contactNum.Text.Trim();

            // Checking if any field is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Establishing connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL query to update password in Admin table
                    string queryUpdate = "UPDATE Admin SET AdminPassword = @NewPassword WHERE AdminUsername = @Username AND ContactNum = @ContactNum";
                    using (SqlCommand commandUpdate = new SqlCommand(queryUpdate, connection))
                    {
                        // Adding parameters to the command
                        commandUpdate.Parameters.AddWithValue("@Username", username);
                        commandUpdate.Parameters.AddWithValue("@NewPassword", newPassword);
                        commandUpdate.Parameters.AddWithValue("@ContactNum", contact);

                        // Executing the command and getting the number of rows affected
                        int rowsAffected = commandUpdate.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password.\nCheck your Username or Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for mouse click on username input field
        private void inputUsernameAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            // Clearing default text when clicked
            if (inputUsernameAdmin.Text == "Enter Username")
            {
                inputUsernameAdmin.Text = "";
                inputUsernameAdmin.ForeColor = Color.Black;
            }

        }
        // Event handler for mouse click on contact number input field
        private void contactNum_MouseClick(object sender, MouseEventArgs e)
        {
            // Clearing default text when clicked
            if (contactNum.Text == "Enter Phone Number")
            {
                contactNum.Text = "";  
                contactNum.ForeColor = Color.Black;
            }
        }

        // Event handler for mouse click on password input field
        private void inputPasswordAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            // Clearing default text when clicked
            if (inputPasswordAdmin.Text == "Enter New Password")
            {
                inputPasswordAdmin.Text = "";
                inputPasswordAdmin.ForeColor = Color.Black;

            }

        }

        // Event handler for exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }

        // Event handler for key press on contact number input field
        private void contactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing only digits and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Event handler for text change in contact number input field
        private void contactNum_TextChanged(object sender, EventArgs e)
        {
            // Prepending country code if not already present
            if (!contactNum.Text.StartsWith("+63"))
            {
                contactNum.Text = "+63";
                contactNum.SelectionStart = contactNum.Text.Length;
            }

            // Limiting the length of contact number input to 13 characters
            if (contactNum.Text.Length > 13)
            {
                contactNum.Text = contactNum.Text.Substring(0, 13);
                contactNum.SelectionStart = contactNum.Text.Length;
            }
        }

       

       
    }
}
