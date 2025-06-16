using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingReservationSystem.frmLogin;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace BookingReservationSystem.User_Control_Client
{
    public partial class UserControl5 : UserControl
    {

        public UserControl5()
        {
            InitializeComponent();
            // Attach event handler for when room number selection changes
            roomNum.SelectedIndexChanged += roomNum_SelectedIndexChanged;
        }

        // Define SQL connection string
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");


        // Method to clear form fields
        public void Clear()
        {
            // Clear text fields
            name.Text = "";
            roomNum.Text = "";
            roomType.Text = "-";
            amount.Text = "-";
            amountRecieved.Clear();
            change.Text = "-";
            discount.Text = "";
            // Clear modify fields
            nameModify.Text = "";
            nameSearch.Text = "";
            roomNumModify.Text = "";
            roomTypeModif.Text = "-";
            amountModify.Text = "-";
            discountModify.Text = "";
            amountRecievedModify.Clear();
            change.Text = "-";
        }

        // Method to refresh names in dropboxs
        public void RefreshName()
        {
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }

            // Populate customer and room dropboxs
            PopulateCustomer(name, nameModify, nameSearch);
            PopulateRoom(roomNum, roomNumModify);

            connect.Close();
        }
        // Method to populate room dropbox
        public void PopulateRoom(System.Windows.Forms.ComboBox roomNum, ComboBox roomNumModify)
        {
            try
            {
                // Clear existing items in dropbox
                roomNum.Items.Clear();
                roomNumModify.Items.Clear();
                // SQL query to select room numbers from database
                string queryRoom = "SELECT RoomNumber FROM Room";
                using (SqlCommand cmdRoom = new SqlCommand(queryRoom, connect))
                {
                    SqlDataReader readerRoom = cmdRoom.ExecuteReader();
                    while (readerRoom.Read())
                    {
                        // Read room number from database
                        long roomNumber = readerRoom.GetInt64(0);

                        // Add room number to dropdowns
                        roomNum.Items.Add(roomNumber.ToString());
                        roomNumModify.Items.Add(roomNumber.ToString());
                    }
                    readerRoom.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating room types: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to populate customer dropbox
        public void PopulateCustomer(System.Windows.Forms.ComboBox name, ComboBox nameModify, ComboBox nameSearch)
        {
            try
            {
                // Clear existing items in dropbox
                name.Items.Clear();
                nameModify.Items.Clear();
                nameSearch.Items.Clear();
                // SQL query to select customer names from database
                string queryNames = "SELECT Name FROM Customer";
                // Execute SQL command
                using (SqlCommand cmdName = new SqlCommand(queryNames, connect))
                {
                    SqlDataReader readerName = cmdName.ExecuteReader();

                    while (readerName.Read())
                    {
                        // Read customer name from database
                        string names = readerName.GetString(0);

                        // Add customer name to dropdowns
                        name.Items.Add(names);
                        nameModify.Items.Add(names);
                        nameSearch.Items.Add(names);
                    }
                    readerName.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error populating room types: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event for Create button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check if room number is selected
            if (roomNum.SelectedItem == null)
            {
                MessageBox.Show("Choose Room Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get selected room number
            string selectedRoomNumber = roomNum.SelectedItem.ToString();

            try
            {
                // Get check-in and check-out dates
                DateTime checkIn = checkInDate.Value;
                DateTime checkOut = checkOutDate.Value;

                // Update date and time to current
                DateTime updatedDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                checkInDate.Value = updatedDateTime;

                // Get amount, amount received, discount, and number of days
                string amountText = amount.Text.TrimStart('₱');
                decimal amountReceivedValue = Convert.ToDecimal(amountRecieved.Text);
                decimal amountValue = Convert.ToDecimal(amountText);
                decimal discnt = Convert.ToDecimal(discount.Text);
                decimal day = Convert.ToDecimal(days.Text);

                // Check if customer name is selected
                if (name.SelectedItem == null)
                {
                    MessageBox.Show("Choose Name of Customer!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate check-in and check-out dates
                if (checkIn.Date < DateTime.Now.Date || checkOut.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Check-in and Check-out dates cannot be in the past!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after the Check-in date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (checkIn == checkOut)
                {
                    MessageBox.Show("Check-in date and Check-out date cannot be the same!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate discount amount
                decimal discountPercentage = discnt;
                decimal discountAmount = (discountPercentage / 100) * amountValue;

                // Calculate total amount after discount
                decimal amountAfterDiscount = amountValue - discountAmount;
                decimal totalAmount = day * amountAfterDiscount;

                // Calculate change
                decimal changes = amountReceivedValue - totalAmount;

                // Validate amount received and discount
                if (amountReceivedValue < amountValue)
                {
                    MessageBox.Show("Insuffecient ammount recieved. ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (discnt.Equals(""))
                {
                    MessageBox.Show("Fill Up the discount. \nif no discount just enter ( 0 ). ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Display change
                    change.Text = changes.ToString("C2");
                }

                // Check room availability
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string checkRoomStatusQuery = "SELECT Status FROM Room WHERE RoomNumber = @RoomNumber";
                    using (SqlCommand cmdCheckRoomStatus = new SqlCommand(checkRoomStatusQuery, connect))
                    {
                        cmdCheckRoomStatus.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);

                        string roomStatus = cmdCheckRoomStatus.ExecuteScalar()?.ToString();

                        // If the room is not available, show an error message
                        if (roomStatus == null || roomStatus.Equals("Not Available", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Selected room is not available for booking!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }


                // Insert booking data into the database
                string usernamesave = Session.LoggedInUsername;
                string insertData = "INSERT INTO Bookings (Name, RoomNumber, CheckinDate, CheckoutDate,ClientUsername,DiscountedPrice) " +
                                    "VALUES (@name, @roomNum, @checkInDate, @checkOutDate,@ClientUsername,@discountedPrice)";

                using (SqlConnection connect = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    connect.Open();

                    // Add parameters for the SQL command
                    cmd.Parameters.AddWithValue("@name", name.Text.Trim());
                    cmd.Parameters.AddWithValue("@roomNum", selectedRoomNumber);
                    cmd.Parameters.AddWithValue("@checkInDate", checkIn.ToString("yyyy/MM/dd HH:mm"));
                    cmd.Parameters.AddWithValue("@checkOutDate", checkOut.ToString("yyyy/MM/dd HH:mm"));
                    cmd.Parameters.AddWithValue("@ClientUsername", usernamesave);
                    cmd.Parameters.AddWithValue("@discountedPrice", totalAmount);

                    cmd.ExecuteNonQuery();
                    // Show a success message
                    MessageBox.Show("Room booked successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Update room status to 'Not Available'
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlTransaction transaction = connect.BeginTransaction())
                    {
                        try
                        {
                            string updateRoomStatusQuery = "UPDATE Room SET Status = 'Not Available' WHERE RoomNumber = @RoomNumber";
                            using (SqlCommand cmdUpdateRoomStatus = new SqlCommand(updateRoomStatusQuery, connect, transaction))
                            {
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);

                                int rowsAffected = cmdUpdateRoomStatus.ExecuteNonQuery();

                                if (rowsAffected <= 0)
                                {
                                    // If no rows are affected, show an error message
                                    MessageBox.Show("Room is already booked or does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            // Commit the transaction
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Rollback the transaction if an error occurs
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event for Update button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if a room number is selected
            if (roomNumModify.SelectedItem == null)
            {
                MessageBox.Show("Choose Room Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected room number
            string selectedRoomNumber = roomNumModify.SelectedItem.ToString();

            try
            {
                // Get check-in and check-out dates
                DateTime checkIn = checkInmodify.Value;
                DateTime checkOut = checkOutModify.Value;

                // Check if customer name is selected
                if (nameModify.SelectedItem == null)
                {
                    MessageBox.Show("Choose Name of Customer!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if check-in and check-out dates are valid
                if (checkIn.Date < DateTime.Now.Date || checkOut.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Check-in and Check-out dates cannot be in the past!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if check-out date is after check-in date
                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after the Check-in date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if check-in and check-out dates are the same
                if (checkIn == checkOut)
                {
                    MessageBox.Show("Check-in date and Check-out date cannot be the same!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convert amount and discount to decimal values
                decimal amountValue = Convert.ToDecimal(amountModify.Text.TrimStart('₱'));
                decimal amountReceivedValue = Convert.ToDecimal(amountRecievedModify.Text);
                decimal discountPercentage = Convert.ToDecimal(discountModify.Text);
                // Calculate discount amount and amount after discount
                decimal discountAmount = (discountPercentage / 100) * amountValue;
                decimal amountAfterDiscount = amountValue - discountAmount;
                decimal changes = amountReceivedValue - amountAfterDiscount;

                // Check if received amount is less than total amount
                if (amountReceivedValue < amountValue)
                {
                    MessageBox.Show("Insufficient amount received.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Check if discount field is empty
                else if (string.IsNullOrEmpty(discountModify.Text))
                {
                    MessageBox.Show("Fill up the discount. If no discount, just enter 0.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Display change amount
                    changeModify.Text = changes.ToString("C2");
                }

                string previousRoomNumber;
                string usernamesave = Session.LoggedInUsername;

                // Open database connection
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    using (SqlTransaction transaction = connect.BeginTransaction())
                    {
                        try
                        {
                            // Retrieve previous room number for the customer
                            string getPreviousRoomNumberQuery = "SELECT RoomNumber FROM Bookings WHERE Name = @name";
                            using (SqlCommand cmdGetPreviousRoomNumber = new SqlCommand(getPreviousRoomNumberQuery, connect, transaction))
                            {
                                cmdGetPreviousRoomNumber.Parameters.AddWithValue("@name", nameModify.Text.Trim());
                                previousRoomNumber = cmdGetPreviousRoomNumber.ExecuteScalar()?.ToString();
                            }

                            // Check status of selected room
                            string checkRoomStatusQuery = "SELECT Status FROM Room WHERE RoomNumber = @RoomNumber";
                            using (SqlCommand cmdCheckRoomStatus = new SqlCommand(checkRoomStatusQuery, connect, transaction))
                            {
                                cmdCheckRoomStatus.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                                string roomStatus = cmdCheckRoomStatus.ExecuteScalar()?.ToString();

                                // If room is not available, show error and rollback transaction
                                if (roomStatus == null || roomStatus.Equals("Not Available", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Selected room is not available for booking!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    transaction.Rollback();
                                    return;
                                }
                            }

                            // Update booking information in the database
                            string updateBookingQuery = "UPDATE Bookings SET Name = @name, RoomNumber = @roomNum, CheckinDate = @checkInDate, CheckoutDate = @checkOutDate, ClientUsername = @ClientUsername, DiscountedPrice = @discountedPrice WHERE Name = @name";
                            using (SqlCommand cmdUpdateBooking = new SqlCommand(updateBookingQuery, connect, transaction))
                            {
                                cmdUpdateBooking.Parameters.AddWithValue("@name", nameModify.Text.Trim());
                                cmdUpdateBooking.Parameters.AddWithValue("@roomNum", selectedRoomNumber);
                                cmdUpdateBooking.Parameters.AddWithValue("@checkInDate", checkIn.ToString("yyyy/MM/dd HH:mm"));
                                cmdUpdateBooking.Parameters.AddWithValue("@checkOutDate", checkOut.ToString("yyyy/MM/dd HH:mm"));
                                cmdUpdateBooking.Parameters.AddWithValue("@ClientUsername", usernamesave);
                                cmdUpdateBooking.Parameters.AddWithValue("@discountedPrice", amountAfterDiscount);

                                cmdUpdateBooking.ExecuteNonQuery();
                            }

                            // If customer changed room, update previous room status
                            if (!string.IsNullOrEmpty(previousRoomNumber) && !previousRoomNumber.Equals(selectedRoomNumber))
                            {
                                string updatePreviousRoomStatusQuery = "UPDATE Room SET Status = 'Available' WHERE RoomNumber = @PreviousRoomNumber";
                                using (SqlCommand cmdUpdatePreviousRoomStatus = new SqlCommand(updatePreviousRoomStatusQuery, connect, transaction))
                                {
                                    cmdUpdatePreviousRoomStatus.Parameters.AddWithValue("@PreviousRoomNumber", previousRoomNumber);
                                    cmdUpdatePreviousRoomStatus.ExecuteNonQuery();
                                }
                            }

                            // Update status of new room to 'Not Available'
                            string updateNewRoomStatusQuery = "UPDATE Room SET Status = 'Not Available' WHERE RoomNumber = @RoomNumber";
                            using (SqlCommand cmdUpdateNewRoomStatus = new SqlCommand(updateNewRoomStatusQuery, connect, transaction))
                            {
                                cmdUpdateNewRoomStatus.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                                int rowsAffected = cmdUpdateNewRoomStatus.ExecuteNonQuery();

                                // If no rows affected, show error and rollback transaction
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Room is already booked or does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    
                                    transaction.Rollback();
                                    return;
                                }
                            }
                            // If all operations successful, commit transaction
                            transaction.Commit();
                            MessageBox.Show("Record updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            transaction.Rollback();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a room number is selected
            if (roomNumModify.SelectedItem == null)
            {
                MessageBox.Show("Choose Room Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get the selected room number
            string selectedRoomNumber = roomNumModify.SelectedItem.ToString();

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Define delete query
                    string deleteBookingQuery = "DELETE FROM Bookings WHERE Name = @name AND RoomNumber = @RoomNumber";
                    using (SqlCommand cmdDeleteBooking = new SqlCommand(deleteBookingQuery, connect))
                    {
                        // Set parameters for the delete query
                        cmdDeleteBooking.Parameters.AddWithValue("@name", nameModify.Text);
                        cmdDeleteBooking.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                        int rowsAffected = cmdDeleteBooking.ExecuteNonQuery(); // Execute delete query

                        // Check if any rows were deleted
                        if (rowsAffected > 0)
                        {
                            // Update room status to available
                            string updateRoomStatusQuery = "UPDATE Room SET Status = 'Available' WHERE RoomNumber = @RoomNumber";
                            using (SqlCommand cmdUpdateRoomStatus = new SqlCommand(updateRoomStatusQuery, connect))
                            {
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                                cmdUpdateRoomStatus.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No records found for the provided customer name and room number.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the selected name from the dropdown   
            string selectedName = nameSearch.SelectedItem.ToString();
            try
            {
                // Open database connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Define search query
                    string query = @"SELECT B.*, R.Status FROM Bookings B INNER JOIN Room R ON B.RoomNumber = R.RoomNumber WHERE B.Name LIKE @name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", "%" + selectedName + "%");

                        // Fill the data into DataGridView
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Connection string to the SQL Server database
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";
        private void BindGrid()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT B.*, R.Status FROM Bookings B INNER JOIN Room R ON B.RoomNumber = R.RoomNumber", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Creating a new DataTable to hold the retrieved data
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Setting the DataGridView's DataSource to the filled DataTable
                        dataGridView2.DataSource = dataTable;

                        // Adding custom columns for reservation status if they don't already exist
                        if (!dataGridView2.Columns.Contains("Reserve"))
                        {
                            // Creating a DataGridViewCheckBoxColumn for reservation status
                            DataGridViewCheckBoxColumn reserveColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Reserve",
                                HeaderText = "Reserve",
                                TrueValue = true,
                                FalseValue = false
                            };
                            // Adding the column to the DataGridView
                            dataGridView2.Columns.Add(reserveColumn);
                        }
                        // Adding custom columns for checkout status if they don't already exist
                        if (!dataGridView2.Columns.Contains("Checkout"))
                        {
                            // Creating a DataGridViewCheckBoxColumn for checkout status
                            DataGridViewCheckBoxColumn checkoutColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Checkout",
                                HeaderText = "Checkout",
                                TrueValue = true,
                                FalseValue = false
                            };
                            // Adding the column to the DataGridView
                            dataGridView2.Columns.Add(checkoutColumn);
                        }

                        // Adding custom columns for check-in status if they don't already exist
                        if (!dataGridView2.Columns.Contains("Checkin"))
                        {
                            // Creating a DataGridViewCheckBoxColumn for check-in status
                            DataGridViewCheckBoxColumn checkinColumn = new DataGridViewCheckBoxColumn
                            {
                                Name = "Checkin",
                                HeaderText = "Checkin",
                                TrueValue = true,
                                FalseValue = false
                            };
                            // Adding the column to the DataGridView
                            dataGridView2.Columns.Add(checkinColumn);
                        }

                        // Setting the DataGridView to be editable
                        dataGridView2.ReadOnly = false;

                        // Making all columns except the custom ones read-only
                        foreach (DataGridViewColumn column in dataGridView2.Columns)
                        {
                            if (column.Name != "Reserve" && column.Name != "Checkout" && column.Name != "Checkin")
                            {
                                column.ReadOnly = true;
                            }
                            else
                            {
                                column.ReadOnly = false;
                            }
                        }
                        // Ensuring that each cell in the custom columns has a value
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            // Setting default values for Reserve, Checkout, and Checkin if they are null
                            if (row.Cells["Reserve"].Value == null)
                            {
                                row.Cells["Reserve"].Value = false;
                            }
                            if (row.Cells["Checkout"].Value == null)
                            {
                                row.Cells["Checkout"].Value = false;
                            }
                            if (row.Cells["Checkin"].Value == null)
                            {
                                row.Cells["Checkin"].Value = false;
                            }
                        }
                    }
                }
            
            }
        }
        // Method for RefreshGrid
        public void RefreshGrid()
        {
            // Iterating through each row in the DataGridView
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // Retrieving checkout date and room number from the current row
                DateTime checkoutDate = Convert.ToDateTime(row.Cells["CheckoutDate"].Value);
                string roomNumber = row.Cells["RoomNumber"].Value.ToString();

                // Checking if the checkout date has passed
                if (DateTime.Now > checkoutDate)
                {
                    string status = "Available"; // Setting room status to "Available"

                    // Establishing a connection to the database
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {

                        connect.Open();
                        // Updating room status to "Available"
                        string updateRoomStatusQuery = "UPDATE Room SET Status = @Status WHERE RoomNumber = @RoomNumber";


                        using (SqlCommand cmdUpdateRoomStatus = new SqlCommand(updateRoomStatusQuery, connect))
                        {
                            cmdUpdateRoomStatus.Parameters.AddWithValue("@Status", status);
                            cmdUpdateRoomStatus.Parameters.AddWithValue("@RoomNumber", roomNumber);

                            // Executing the SQL command and getting the number of affected rows
                            int rowsAffected = cmdUpdateRoomStatus.ExecuteNonQuery();
                            if (rowsAffected <= 0)
                            {
                                MessageBox.Show("Room does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                        // Deleting the booking associated with the room
                        string deleteBookingQuery = "DELETE B FROM Bookings B INNER JOIN Room R ON B.RoomNumber = R.RoomNumber WHERE R.Status = @Status AND B.BookingID = @BookingID";

                        int bookingId = Convert.ToInt32(row.Cells["BookingID"].Value);

                        using (SqlCommand cmdDeleteBooking = new SqlCommand(deleteBookingQuery, connect))
                        {
                            cmdDeleteBooking.Parameters.AddWithValue("@Status", status);
                            cmdDeleteBooking.Parameters.AddWithValue("@BookingID", bookingId);

                            // Executing the SQL command and getting the number of affected rows
                            int rowsAffected = cmdDeleteBooking.ExecuteNonQuery();
                            if (rowsAffected <= 0)
                            {
                                MessageBox.Show("Wait to remove booking! try to refresh", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }

            }
        }

        // This event handler ensures changes in the DataGridView cells are committed immediately
        private void dataGridView2_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if (dataGridView2.IsCurrentCellDirty)
            {
                dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }


        // This event handler is triggered when a cell value changes
        private void dataGridView2_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == dataGridView2.Columns["Reserve"].Index ||
                                   e.ColumnIndex == dataGridView2.Columns["Checkout"].Index ||
                                   e.ColumnIndex == dataGridView2.Columns["Checkin"].Index))
            {
                // Getting the row and values of the changed cell
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                bool isReserveChecked = Convert.ToBoolean(row.Cells["Reserve"].Value);
                bool isCheckoutChecked = Convert.ToBoolean(row.Cells["Checkout"].Value);
                bool isCheckinChecked = Convert.ToBoolean(row.Cells["Checkin"].Value);

                // Handling changes based on the checked state of checkboxes
                if (isReserveChecked)
                {
                    // If Reserve is checked, uncheck Checkout and Checkin
                    row.Cells["Checkout"].Value = false;
                    row.Cells["Checkin"].Value = false;

                }
                if (isCheckoutChecked)
                {
                    // If Checkout is checked, uncheck Reserve and Checkin
                    row.Cells["Reserve"].Value = false;
                    row.Cells["Checkin"].Value = false;


                }
                if (isCheckinChecked)
                {
                    // If Checkin is checked, uncheck Reserve and Checkout
                    row.Cells["Reserve"].Value = false;
                    row.Cells["Checkout"].Value = false;
                }

                // Getting room number and setting status based on checkbox state
                int roomNumber = Convert.ToInt32(row.Cells["RoomNumber"].Value);
                string status;

                // Updating room status based on checkbox state
                if (isReserveChecked)
                {
                    status = "Reserve";
                    // Updating room status to "Reserve" in the database
                    // Handling exceptions if any error occurs during the process
                    try
                    {
                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            string updateRoomStatusQuery = "UPDATE Room SET Status = @Status WHERE RoomNumber = @RoomNumber";

                            using (SqlCommand cmdUpdateRoomStatus = new SqlCommand(updateRoomStatusQuery, connect))
                            {
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@Status", status);
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@RoomNumber", roomNumber);

                                int rowsAffected = cmdUpdateRoomStatus.ExecuteNonQuery();
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Room does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (isCheckoutChecked)
                {
                    status = "Available";
                    /* Updating room status to "Available" in the database
                    * Deleting the booking associated with the room
                     Handling exceptions if any error occurs during the process */
                    try
                    {
                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            string updateRoomStatusQuery = "UPDATE Room SET Status = @Status WHERE RoomNumber = @RoomNumber";

                            using (SqlCommand cmdUpdateRoomStatus = new SqlCommand(updateRoomStatusQuery, connect))
                            {
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@Status", status);
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@RoomNumber", roomNumber);

                                int rowsAffected = cmdUpdateRoomStatus.ExecuteNonQuery();
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Room does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }



                            string deleteBookingQuery = "DELETE B FROM Bookings B INNER JOIN Room R ON B.RoomNumber = R.RoomNumber WHERE R.Status = @Status AND B.BookingID = @BookingID";

                            int bookingId = Convert.ToInt32(row.Cells["BookingID"].Value);

                            using (SqlCommand cmdDeleteBooking = new SqlCommand(deleteBookingQuery, connect))
                            {
                                cmdDeleteBooking.Parameters.AddWithValue("@Status", status);
                                cmdDeleteBooking.Parameters.AddWithValue("@BookingID", bookingId);

                                int rowsAffected = cmdDeleteBooking.ExecuteNonQuery();
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Wait to remove booking!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (isCheckinChecked)
                {
                    status = "Not Available";
                    // Updating room status to "Not Available" in the database
                    // Handling exceptions if any error occurs during the process
                    try
                    {
                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            string updateRoomStatusQuery = "UPDATE Room SET Status = @Status WHERE RoomNumber = @RoomNumber";

                            using (SqlCommand cmdUpdateRoomStatus = new SqlCommand(updateRoomStatusQuery, connect))
                            {
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@Status", status);
                                cmdUpdateRoomStatus.Parameters.AddWithValue("@RoomNumber", roomNumber);

                                int rowsAffected = cmdUpdateRoomStatus.ExecuteNonQuery();
                                if (rowsAffected <= 0)
                                {
                                    MessageBox.Show("Room does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
        }



        private void UserControl5_Load(object sender, EventArgs e)
        {
            // Call the method to refresh client names
            RefreshName();
            // Call the method to refresh the grid view
            RefreshGrid();

        }

        private void roomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected room number from the combo box
            string selectedRoomNumber = roomNum.SelectedItem.ToString();

            // SQL query to retrieve room details based on the selected room number
            string queryRoomDetails = "SELECT RoomType, Price FROM Room WHERE RoomNumber = @RoomNumber";

            try
            {

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                using (SqlCommand cmdRoomDetails = new SqlCommand(queryRoomDetails, connect))
                {
                    // Set the parameter for the room number in the SQL query
                    cmdRoomDetails.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);

                    // Execute the SQL query and read the results
                    SqlDataReader readerRoomDetails = cmdRoomDetails.ExecuteReader();

                    if (readerRoomDetails.Read())
                    {
                        // Retrieve room type and price from the query results
                        string roomTypes = readerRoomDetails["RoomType"].ToString();
                        decimal price = readerRoomDetails.GetDecimal(readerRoomDetails.GetOrdinal("Price"));

                        // Display room type and price in respective text boxes
                        roomType.Text = roomTypes;
                        amount.Text = price.ToString("C2");


                    }

                    readerRoomDetails.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving room details: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void tabAddClient_Selected(object sender, TabControlEventArgs e)
        {
            BindGrid(); // Call the method to bind the grid view
        }

        private void amountRecieved_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and '.' for amount received input
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }



        private void ad_Leave(object sender, EventArgs e)
        {
            Clear();   // Call the Clear method when leaving the control

        }


        private void addClient_Leave(object sender, EventArgs e)
        {
            Clear();   // Call the Clear method when leaving the control

        }

        private void searchClientUser_Leave(object sender, EventArgs e)
        {
            Clear();   // Call the Clear method when leaving the control

        }

        private void roomNumModify_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected room number from the combo box
            string selectedRoomNumber = roomNumModify.SelectedItem.ToString();

            // SQL query to retrieve room details based on the selected room number
            string queryRoomDetails = "SELECT RoomType, Price FROM Room WHERE RoomNumber = @RoomNumber";

            try
            {

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                using (SqlCommand cmdRoomDetails = new SqlCommand(queryRoomDetails, connect))
                {
                    // Set the parameter for the room number in the SQL query
                    cmdRoomDetails.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);


                    SqlDataReader readerRoomDetails = cmdRoomDetails.ExecuteReader();

                    if (readerRoomDetails.Read())
                    {
                        // Retrieve room type and price from the query results
                        string roomTypes = readerRoomDetails["RoomType"].ToString();
                        decimal price = readerRoomDetails.GetDecimal(readerRoomDetails.GetOrdinal("Price"));

                        // Display room type and price in respective text boxes
                        roomTypeModif.Text = roomTypes;
                        amountModify.Text = price.ToString("C2");


                    }

                    readerRoomDetails.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving room details: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void discountModify_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters for discount input
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void amountRecievedModify_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters, and '.' for amount received input
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters for discount input
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UserControl5_VisibleChanged(object sender, EventArgs e)
        {
            // Call the RefreshGrid method when the visibility of the control changes
            RefreshGrid();
        }
    }

}
