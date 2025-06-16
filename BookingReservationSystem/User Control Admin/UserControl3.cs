using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace BookingReservationSystem.User_Control
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
           
        }

        // Method to clear input fields
        public void Clear()
        {
            roomNum.Clear(); // Clears the room number textbox
            roomnumberInput.Clear(); // Clears the room number input textbox
            roomNumInput.Clear(); // Clears the room number input textbox
            descriptionInput.Clear(); // Clears the description input textbox
            descriptions.Clear(); // Clears the descriptions textbox
            Costs.Clear(); // Clears the costs textbox
            costInput.Clear(); // Clears the cost input textbox
            roomtypeinputs.Text = ""; // Clears the room type inputs combo box
            roomTypeinput.Text = ""; // Clears the room type input combo box

        }

        // SQL connection string
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");
        private void UserControl3_Load(object sender, EventArgs e)
        {
            RefreshRoomTypes(); // Calls method to refresh room types
        }

        // Method to refresh room types in combo boxes
        public void RefreshRoomTypes()
        {
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();  // Opens the SQL connection if not already open
            }

            PopulateRoomTypes(roomTypeinput); // Populates room types in roomTypeinput combo box
            PopulateRoomTypess(roomtypeinputs); // Populates room types in roomtypeinputs combo box

            connect.Close(); // Closes the SQL connection
        }

        // Method to populate room types in a combo box
        public void PopulateRoomTypes(System.Windows.Forms.ComboBox roomTypeinput)
        {    
            try
            {

                roomTypeinput.Items.Clear();// Clears existing items in the combo box
                string queryRoomTypes = "SELECT RoomType FROM RoomType";// SQL query to select room types
                using (SqlCommand cmdRoomTypes = new SqlCommand(queryRoomTypes, connect))
                {
                    SqlDataReader readerRoomTypes = cmdRoomTypes.ExecuteReader();
                    
                    while (readerRoomTypes.Read())
                    {
                        string roomType = readerRoomTypes.GetString(0); // Gets the room type string
                        roomTypeinput.Items.Add(roomType); // Adds the room type to the combo box
                    }
                    readerRoomTypes.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating room types: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to populate room types in another combo box
        public void PopulateRoomTypess(System.Windows.Forms.ComboBox roomtypeinputs)
        {
            try
            {
                
                roomtypeinputs.Items.Clear();// Clears existing items in the combo box
                string queryRoomTypes = "SELECT RoomType FROM RoomType";
                using (SqlCommand cmdRoomTypes = new SqlCommand(queryRoomTypes, connect))
                {
                    SqlDataReader readerRoomTypes = cmdRoomTypes.ExecuteReader();
                    while (readerRoomTypes.Read())
                    {
                        string roomType = readerRoomTypes.GetString(0); // Gets the room type string
                        roomtypeinputs.Items.Add(roomType); // Adds the room type to the combo box
                    }
                    readerRoomTypes.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating room types: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for save button click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validates that required fields are filled
            if (roomNumInput.Text == "" || roomTypeinput.SelectedItem == null || descriptionInput.Text == "" || costInput.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // SQL query to check if room number already exists
                    string checkRoomNum = "SELECT * FROM Room WHERE RoomNumber = @roomNumber";
                    using (SqlCommand checkRoomNumCmd = new SqlCommand(checkRoomNum, connect))
                    {
                        // Adds parameter for room number
                        checkRoomNumCmd.Parameters.AddWithValue("@roomNumber", roomNumInput.Text.Trim());
                        SqlDataReader reader = checkRoomNumCmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            // Shows an error message if room number already exists
                            MessageBox.Show("Room Number already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            reader.Close();
                        }
                    }

                    // Gets the selected room type
                    string selectedRoomType = roomTypeinput.SelectedItem.ToString();

                    // SQL query to insert a new room record
                    string insertData = "INSERT INTO Room (RoomNumber, RoomType,Description,Price,Status) " +
                                        "VALUES (@roomNumber, @roomType,  @description,@price,@status)";
                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        string status = "Available"; // Default status for a new room
                        cmd.Parameters.AddWithValue("@status", status); // Adds parameter for status
                        cmd.Parameters.AddWithValue("@roomNumber", roomNumInput.Text.Trim()); // Adds parameter for room number
                        cmd.Parameters.AddWithValue("@roomType", selectedRoomType); // Adds parameter for room type
                        cmd.Parameters.AddWithValue("@description", descriptionInput.Text.Trim()); // Adds parameter for description
                        cmd.Parameters.AddWithValue("@price", costInput.Text.Trim()); // Adds parameter for price


                        cmd.ExecuteNonQuery();

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

        // Connection string for the database
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";

        // Method to bind data to the grid view
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Room", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable(); // Creates a new DataTable
                        adapter.Fill(dataTable); // Fills the DataTable with query results
                        dataGridView1.DataSource = dataTable; // Binds the DataTable to the grid view
                    }
                }
            }
        }
        
        private void tabAddClient_Selected(object sender, TabControlEventArgs e)
        {
            this.BindGrid();// Binds data to the grid view
        }

        // Event handler to restrict cost input to numeric values
        private void costInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevents non-numeric characters
            }
        }
        // Event handler to restrict room number input to numeric values
        private void roomNumInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;// Prevents non-numeric characters
            }
        }


        // Event handler for search button click event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE RoomNumber = @roomNumber", connection))
                    {
                        command.Parameters.AddWithValue("@roomNumber", roomNum.Text);// Add parameter to the command
                        // Create a data adapter to execute the command and fill the result into a data table
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable(); // Create a new data table
                            adapter.Fill(dataTable); // Fill the data table with the result of the command
                            dataGridView1.DataSource = dataTable; // Set the data source of the data grid view to the data table
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for update button click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if any input fields are empty
            if (roomnumberInput.Text == "" || roomtypeinputs.SelectedItem == null || descriptions.Text == "" || Costs.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                string selectedRoomType = roomtypeinputs.SelectedItem.ToString(); // Get the selected room type as a string

                using (SqlConnection connect = new SqlConnection(connectionString))
                {

                    connect.Open();
                    // Create a query to update the Room table
                    string query = "UPDATE Room SET RoomNumber = @roomNumber, RoomType = @roomType, Description = @description,Price = @price WHERE RoomNumber = @roomNumber";

                    // Create a new SQL command to execute the update query
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Add parameters to the command
                        cmd.Parameters.AddWithValue("@roomNumber", roomnumberInput.Text);
                        cmd.Parameters.AddWithValue("@roomType", selectedRoomType);
                        cmd.Parameters.AddWithValue("@description", descriptions.Text);
                        cmd.Parameters.AddWithValue("@price", Costs.Text);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Show a success or error message based on the number of affected rows
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
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

        // Event handler for delete button click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Create a query to delete a record from the Room table
                    string query = "DELETE FROM Room WHERE RoomNumber = @roomNumber";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@roomNumber", roomnumberInput.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Show a success or error message based on the number of affected rows
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
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

        private void Costs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and the decimal point in the Costs input field
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void addClient_Leave(object sender, EventArgs e)
        {
            Clear(); // Clear method fields when the  tab is left
        }

        private void tabAddClient_Leave(object sender, EventArgs e)
        {
            Clear();// Clear method fields when the  tab is left

        }

        private void updateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear();// Clear method fields when the  tab is left

        }

        private void roomNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters in the room number input field
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void roomnumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters in the room number input field
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
