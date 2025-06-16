using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using static BookingReservationSystem.User_Control.UserControl1;
using static BookingReservationSystem.User_Control.UserControl2;
using BookingReservationSystem.User_Control;





namespace BookingReservationSystem
{
    public partial class frmAdminDashboard : Form
    {
        // SQL Connection
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");

        // Importing GDI32.dll for rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

       
        public frmAdminDashboard()
        {
            InitializeComponent();

            // Creating rounded corners for the form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            
        }
        // Form load event
        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            // Showing dashboard user control on form load
            dashboardUserControl.Visible = true;
            dashboardUserControl.BringToFront();    
        }

        // Dashboard button click event
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Setting active panel indicator
            mvPanel.Height = btnDashboard.Height;
            mvPanel.Top = btnDashboard.Top;
            mvPanel.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(0, 96, 204);

           
            // Showing the dashboard user control
            dashboardUserControl.Show();

            // Bringing the dashboard user control to the front of other controls
            dashboardUserControl.BringToFront();

            // Calling the Client method of the dashboard user control (Assuming it sets up client-related functionality)
            dashboardUserControl.Client();

            // Calling the Admin method of the dashboard user control (Assuming it sets up admin-related functionality)
            dashboardUserControl.Admin();

            // Calling the Rooms method of the dashboard user control (Assuming it sets up room-related functionality)
            dashboardUserControl.Rooms();

            // Calling the RoomType method of the dashboard user control (Assuming it sets up room type-related functionality)
            dashboardUserControl.RoomType();

            // Setting the text of the header title control to indicate that the user is on the Dashboard page
            headerTitle.Text = "Dashboard";     

        }

        // Client button click event
        private void btnClient_Click(object sender, EventArgs e)
        {
            // Setting active panel indicator
            mvPanel.Height = btnClient.Height;
            mvPanel.Top = btnClient.Top;
            mvPanel.Left = btnClient.Left;
            btnClient.BackColor = Color.FromArgb(0, 96, 204);

            // Showing the client user control
            clientUserControl.Show();

            // Bringing the client user control to the front of other controls
            clientUserControl.BringToFront();

            // Setting the text of the header title control to indicate that the user is on the Client User page
            headerTitle.Text = "Client User";

        }

        // Rooms button click event
        private void btnRooms_Click(object sender, EventArgs e)
        {
            // Setting active panel indicator
            mvPanel.Height = btnRooms.Height;
            mvPanel.Top = btnRooms.Top;
            mvPanel.Left = btnRooms.Left;
            btnRooms.BackColor = Color.FromArgb(0, 96, 204);

            // Showing the room user control
            userControlRoom.Show();

            // Bringing the room user control to the front of other controls
            userControlRoom.BringToFront();

            // Refreshing the room types in the room user control
            userControlRoom.RefreshRoomTypes();

            // Setting the text of the header title control to indicate that the user is on the Rooms page
            headerTitle.Text = "Rooms";

        }

        // Event handler for the Room Types button click
        private void btnRoomTypes_Click(object sender, EventArgs e)
        {
            // Setting active panel indicator
            mvPanel.Height = btnRoomTypes.Height;
            mvPanel.Top = btnRoomTypes.Top;
            mvPanel.Left = btnRoomTypes.Left;
            btnRoomTypes.BackColor = Color.FromArgb(0, 96, 204);

            // Showing the room type user control and bringing it to the front
            userControlRoomType.Show();
            userControlRoomType.BringToFront();

            // Setting the text of the header title control to indicate the Room Type page
            headerTitle.Text = "Room Type";
        }

        // Event handler for the Logout button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            // Setting active panel indicator
            mvPanel.Height = btnLogout.Height;
            mvPanel.Top = btnLogout.Top;
            mvPanel.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(0, 96, 204);

            // Prompting the user for logout confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to log out?","Confirm Logout",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            // Logging out if the user confirms
            if (result == DialogResult.OK)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }

        }

        // Event handler for when the Dashboard button loses focus
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            // Resetting the background color
            btnDashboard.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when the Client button loses focus
        private void btnClient_Leave(object sender, EventArgs e)
        {
            // Resetting the background color
            btnClient.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when the Rooms button loses focus
        private void btnRooms_Leave(object sender, EventArgs e)
        {
            // Resetting the background color
            btnRooms.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when the Room Types button loses focus
        private void btnRoomTypes_Leave(object sender, EventArgs e)
        {
            // Resetting the background color
            btnRoomTypes.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when the Logout button loses focus
        private void btnLogout_Leave(object sender, EventArgs e)
        {
            // Resetting the background color
            btnLogout.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for the Exit button click
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // Closing the form and exiting the application
            this.Close();
            Application.Exit();
        }
    }
}