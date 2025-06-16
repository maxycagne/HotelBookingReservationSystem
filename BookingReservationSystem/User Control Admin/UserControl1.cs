using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace BookingReservationSystem.User_Control
{
    public partial class UserControl1 : UserControl
    {
        // Connection string for connecting to the SQL Server database
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";

        public UserControl1()
        {
            InitializeComponent();
        }

        // Method to clear all input fields
        public void Clear()
        {
          
            usernameInput.Clear(); // Clear username input
            passwordInput.Clear(); // Clear password input
            Password.Clear(); // Clear password field
            Username.Clear(); // Clear username field
            addressInput.Clear(); // Clear address input
            address.Clear(); // Clear address field
            phoneNumberInput.Clear(); // Clear phone number input
            phoneNumber.Clear(); // Clear phone number field
            phoneNum.Clear(); // Clear phone number field
        }

        // Method to bind data to the grid view
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Client", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable(); // Create a data table to hold the data
                        adapter.Fill(dataTable); // Fill the data table with data from the database
                        dataGridView1.DataSource = dataTable; // Bind the data table to the grid view
                    }
                }
            }
        }

        // Event handler for hiding the password in passwordInput
        private void btnHidePassword_Click_1(object sender, EventArgs e)
        {
            if (passwordInput.PasswordChar == '\0')
            {
                btnShowPassword.BringToFront(); // Bring the show password button to the front
                passwordInput.PasswordChar = '●'; // Set the password character to a bullet
            }

        
        }

        // Event handler for showing the password in passwordInput
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (passwordInput.PasswordChar == '●')
            {
                btnHidePassword.BringToFront(); // Bring the hide password button to the front
                passwordInput.PasswordChar = '\0'; // Remove the password character

            }

        }

        // Event handler for showing the password in Password field
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '●')
            {
                btnHide.BringToFront(); // Bring the hide password button to the front
                Password.PasswordChar = '\0'; // Remove the password character
            }
        }

        // Event handler for hiding the password in Password field
        private void btnHide_Click_1(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '\0')
            {
                btnShow.BringToFront(); // Bring the show password button to the front
                Password.PasswordChar = '●'; // Set the password character to a bullet
            }
        }

        // Event handler for creating a new client
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (usernameInput.Text == "" || passwordInput.Text == "" || phoneNumberInput.Text == "" || addressInput.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if the password meets the requirements
            else if (!Regex.IsMatch(passwordInput.Text, @"^(?=.*[A-Z])(?=.*\d.*\d)[A-Za-z\d]{5,}$"))
            {
                MessageBox.Show("Your password must be atleast \n ● 5 character long.\n ● Include atleast 1 capital letter.\n ● Include atleast 2 numbers.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if the phone number meets the requirements
            else if (!Regex.IsMatch(phoneNumberInput.Text, @"^\+63\d{10}$"))
            {
                MessageBox.Show("● Limit the input to exactly 13 characters.\r\n ● Automatically insert \"+63\" at the beginning of the input field.\r\n ● Prevent the user from altering the \"+63\" part.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Open the connection if it is not already open
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();// Open the connection

                        // Check if the username already exists
                        string checkUsernameQuery = "SELECT * FROM Client WHERE ClientUsername = @ClientUsername";
                        using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, connect))
                        {
                            checkUsernameCmd.Parameters.AddWithValue("@ClientUsername", usernameInput.Text.Trim());
                            SqlDataReader reader = checkUsernameCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;// Exit the method if the username exists

                            }
                            else
                            {
                                reader.Close();// Close the reader if the username does not exist
                            }
                        }

                        // Check if the phone number already exists
                        string checkPhoneNumQuery = "SELECT * FROM Client WHERE ContactNum = @ContactNum";
                        using (SqlCommand checkPhoneNumCmd = new SqlCommand(checkPhoneNumQuery, connect))
                        {
                            checkPhoneNumCmd.Parameters.AddWithValue("@ContactNum", phoneNumberInput.Text.Trim());
                            SqlDataReader reader = checkPhoneNumCmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                MessageBox.Show(phoneNumberInput.Text + " is already in use", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;// Exit the method if the phone number exists
                            }
                            else 
                            {
                                reader.Close();// Close the reader if the phone number does not exist
                            }

                        }

                        // Insert the new client data into the database
                        string insertData = "INSERT INTO Client (ClientUsername, ClientPassword, ContactNum, Address) " +
                                            "VALUES (@ClientUsername, @ClientPassword, @ContactNum, @Address)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@ClientUsername", usernameInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@ClientPassword", passwordInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@ContactNum", phoneNumberInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", addressInput.Text.Trim());

                            cmd.ExecuteNonQuery(); // Execute the insert command

                            MessageBox.Show("Created Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
        }




        // Event handler for searching for a client by phone number
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Client WHERE ContactNum = @ContactNum", connection))
                    {
                        command.Parameters.AddWithValue("@ContactNum", phoneNumber.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable(); // Create a data table to hold the data
                            adapter.Fill(dataTable); // Fill the data table with data from the database
                            dataGridView1.DataSource = dataTable; // Bind the data table to the grid view
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabAddClient_Selected(object sender, TabControlEventArgs e)
        {
            this.BindGrid();// Bind the data to the grid view
        }

        // Event handler for deleting a client by phone number
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Define the query to delete a client record based on the contact number
                    string query = "DELETE FROM Client WHERE ContactNum = @ContactNum";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Add the contact number parameter to the query
                        cmd.Parameters.AddWithValue("@ContactNum", phoneNum.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected (i.e., record deleted)
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided contact number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input fields: check if any required fields are empty
            if (Username.Text == "" || Password.Text == "" || phoneNum.Text == "" || address.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate password: ensure it meets the specified criteria
            if (!Regex.IsMatch(Password.Text, @"^(?=.*[A-Z])(?=.*\d.*\d)[A-Za-z\d]{5,}$"))
            {
                MessageBox.Show("Your password must be atleast \n ● 5 character long.\n ● Include atleast 1 capital letter.\n ● Include atleast 2 numbers.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate phone number: ensure it matches the format +63 followed by 10 digits
            if (!Regex.IsMatch(phoneNum.Text, @"^\+63\d{10}$"))
            {
                MessageBox.Show("● Limit the input to exactly 13 characters.\r\n ● Automatically insert \"+63\" at the beginning of the input field.\r\n ● Prevent the user from altering the \"+63\" part.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "UPDATE Client SET ClientUsername = @ClientUsername, ClientPassword = @ClientPassword, ContactNum = @ContactNum, Address = @Address WHERE ContactNum = @ContactNum";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {

                        cmd.Parameters.AddWithValue("@ClientUsername", Username.Text);
                        cmd.Parameters.AddWithValue("@ClientPassword", Password.Text);
                        cmd.Parameters.AddWithValue("@ContactNum", phoneNum.Text);
                        cmd.Parameters.AddWithValue("@Address", address.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided contact number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addClient_Leave(object sender, EventArgs e)
        {
            // Clear method or reset state when the tab is left
            Clear();
        }

        private void searchClientUser_Leave(object sender, EventArgs e)
        {
            // Clear method or reset state when the tab is left
            Clear();
        }

        private void tabAddClient_Leave(object sender, EventArgs e)
        {
            // Clear method or reset state when the tab is left
            Clear();
        }

        private void phoneNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters in phoneNumberInput
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void phoneNumberInput_TextChanged(object sender, EventArgs e)
        {
            // Ensure phoneNumberInput starts with "+63"
            if (!phoneNumberInput.Text.StartsWith("+63"))
            {
                phoneNumberInput.Text = "+63";
                phoneNumberInput.SelectionStart = phoneNumberInput.Text.Length;// Set cursor to the end
            }

            // Limit the length of phoneNumberInput to 13 characters
            if (phoneNumberInput.Text.Length > 13)
            {
                phoneNumberInput.Text = phoneNumberInput.Text.Substring(0, 13);
                phoneNumberInput.SelectionStart = phoneNumberInput.Text.Length;
            }
        }

        private void phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters in phoneNum
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters in phoneNumber
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneNumber_TextChanged(object sender, EventArgs e)
        {
            // Ensure phoneNumber starts with "+63"
            if (!phoneNumber.Text.StartsWith("+63"))
            {
                phoneNumber.Text = "+63";
                phoneNumber.SelectionStart = phoneNumber.Text.Length;
            }

            // Limit the length of phoneNumber to 13 characters
            if (phoneNumber.Text.Length > 13)
            {
                phoneNumber.Text = phoneNumber.Text.Substring(0, 13);
                phoneNumber.SelectionStart = phoneNumber.Text.Length;
            }

        }

        private void phoneNum_TextChanged(object sender, EventArgs e)
        {
            // Ensure phoneNumber starts with "+63"
            if (!phoneNum.Text.StartsWith("+63"))
            {
                phoneNum.Text = "+63";
                phoneNum.SelectionStart = phoneNum.Text.Length;
            }

            // Limit the length of phoneNumber to 13 characters
            if (phoneNum.Text.Length > 13)
            {
                phoneNum.Text = phoneNum.Text.Substring(0, 13);
                phoneNum.SelectionStart = phoneNum.Text.Length;
            }
        }
    }
}
