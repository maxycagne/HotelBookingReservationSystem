using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace BookingReservationSystem.User_Control
{
    public partial class UserControl4 : UserControl 
    {
        
        public UserControl4()
        {
            InitializeComponent();
        }
        UserControl3 user3 = new UserControl3();

        // Define the SQL connection string
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");

        // Method to clear the input fields
        public void Clear()
        {
            roomTypeInput.Clear();
            descriptionInput.Clear();
            roomType.Clear();
            description.Clear();

        }

        // Method to refresh the room types
        public void RefreshRoomType()
        {
            user3.RefreshRoomTypes();
        }

        // Event handler for Save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if any input field is empty
            if (roomTypeInput.Text == "" || descriptionInput.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Query to check if the room type already exists
                        string checkRoomType = "SELECT * FROM RoomType WHERE RoomType = @roomType";
                        using (SqlCommand checkRoomTypeCmd = new SqlCommand(checkRoomType, connect))
                        {
                            checkRoomTypeCmd.Parameters.AddWithValue("@roomType", roomTypeInput.Text.Trim());
                            SqlDataReader reader = checkRoomTypeCmd.ExecuteReader();
                            // If room type already exists, show error message
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Room Type already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                reader.Close();
                            }
                        }

                        // Insert query for new room type
                        string insertData = "INSERT INTO RoomType (RoomType,Description) " +
                                            "VALUES ( @roomType, @description)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {

                            cmd.Parameters.AddWithValue("@roomType", roomTypeInput.Text.Trim());
                            cmd.Parameters.AddWithValue("@description", descriptionInput.Text.Trim());

                            cmd.ExecuteNonQuery();// Execute the insert command

                            MessageBox.Show("Created Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        RefreshRoomType();// Refresh room types
                    }
                    catch (Exception ex)
                    {
                        // Show error message in case of an exception
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }

            }
        }

        // Event handler for when the user leaves the addClient control
        private void addClient_Leave(object sender, EventArgs e)
        {
            Clear(); // Clear input fields
        }

        private void updateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear();// Clear input fields

        }

        // Connection string for database operations
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";

        // Event handler for Delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Roomtype WHERE RoomType = @roomType";  // Delete query

                    using (SqlCommand command = new SqlCommand(query,conn))
                    {
                        command.Parameters.AddWithValue("@roomType", roomType.Text); // Add parameter
                        int rowAffected = command.ExecuteNonQuery();// Execute delete command

                        // Check if any row was affected
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");
                            
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided room type.");
                        }
                        user3.RefreshRoomTypes(); // Refresh room types
                    }
                    
                }
                RefreshRoomType();// Refresh room types
            }
            catch(Exception ex)
            {
                // Show error message in case of an exception
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
