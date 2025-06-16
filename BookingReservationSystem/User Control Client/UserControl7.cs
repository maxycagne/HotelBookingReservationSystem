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

namespace BookingReservationSystem.User_Control_Client
{
    public partial class UserControl7 : UserControl
    {
        // Connection string for accessing the database
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";

        // Database instance
        dbase db;
        public UserControl7()
        {
            InitializeComponent();

            // Initialize database object
            db = new dbase();
        }

        // Event handler for when UserControl7 is loaded
        private void UserControl7_Load(object sender, EventArgs e)
        {
            // Update panel colors based on room status
            UpdatePanelColorsBasedOnStatus();

            // Load customer count
            Customer();
            // Load bookings count
            Bookings();
            // Load available room count
            AvailableRoom();
        }


        // Method to display customer count
        public void Customer()
        {
            customerNo.Text = db.Count("SELECT COUNT(*) FROM Customer").ToString();
        }

        // Method to display available room count
        public void AvailableRoom()
        {
            string query = "SELECT COUNT(*) FROM Room WHERE Status = 'Available'";
            int availableRoomCount = db.Count(query);
            availRoomNum.Text = availableRoomCount.ToString();
        }

        // Method to display bookings count
        public void Bookings()
        {
            bookingsNo.Text = db.Count("SELECT COUNT(*) FROM Bookings").ToString();
        }


        // Method to update panel colors based on room status
        public void UpdatePanelColorsBasedOnStatus()
        {
            try
            {
                // Load room statuses from the database
                DataTable roomStatuses = LoadRoomStatusesFromDatabase();

                // Loop through each panel representing a room
                for (int i = 1; i <= 12; i++)
                {
                    string panelName = "room" + i;
                    Panel panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;

                    // If panel exists
                    if (panel != null)
                    {
                        DataRow[] statusRows = roomStatuses.Select($"RoomNumber = {i}");
                        if (statusRows.Length > 0)
                        {
                            // Set panel color based on room status
                            string status = statusRows[0]["Status"].ToString();
                            if (status.Equals("Not Available", StringComparison.OrdinalIgnoreCase))
                            {
                                panel.BackColor = Color.FromArgb(255, 4, 0);// Red color for not available
                            }
                            else if (status.Equals("Available", StringComparison.OrdinalIgnoreCase))
                            {
                                panel.BackColor = Color.FromArgb(0, 123, 255); // Blue color for available
                            }
                            else if (status.Equals("Reserve", StringComparison.OrdinalIgnoreCase))
                            {
                                panel.BackColor = Color.FromArgb(251, 255, 0); // Yellow color for reserved
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show($"Panel '{panelName}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to load room statuses from the database
        private DataTable LoadRoomStatusesFromDatabase()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT RoomNumber, Status FROM Room";

            // Establish connection and execute query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        
    }
}
