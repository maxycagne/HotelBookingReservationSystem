using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookingReservationSystem.User_Control;

namespace BookingReservationSystem
{
    public partial class frmClientDashboard : Form
    {
        // Importing function from Gdi32.dll to create a rounded form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public frmClientDashboard()
        {
            InitializeComponent();
            // Make the form rounded
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Event handler for the Dashboard button click
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Update panel and button appearance
            mvPanel.Height = btnDashboard.Height;
            mvPanel.Top = btnDashboard.Top;
            mvPanel.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(0, 96, 204);

            // Show the Dashboard user control
            userControlDashboard.Show();

            // Bring the Dashboard user control to the front
            userControlDashboard.BringToFront();

            // Update the panel colors based on status within the Dashboard user control
            userControlDashboard.UpdatePanelColorsBasedOnStatus();

            // Retrieve and display customer information within the Dashboard user control
            userControlDashboard.Customer();

            // Retrieve and display booking information within the Dashboard user control
            userControlDashboard.Bookings();

            // Retrieve and display available room information within the Dashboard user control
            userControlDashboard.AvailableRoom();

            // Update the header title to indicate the current page as "Dashboard"
            headerTitle.Text = "Dashboard";

        }

        // Event handler for the Bookings button click
        private void btnBookings_Click(object sender, EventArgs e)
        {
            // Update panel and button appearance for Bookings
            mvPanel.Height = btnBookings.Height;
            mvPanel.Top = btnBookings.Top;
            mvPanel.Left = btnBookings.Left;
            btnBookings.BackColor = Color.FromArgb(0, 96, 204);

            // Show the Bookings user control
            userControlBookings.Show();

            // Bring the Bookings user control to the front
            userControlBookings.BringToFront();

            // Refresh the name information within the Bookings user control
            userControlBookings.RefreshName();

            // Refresh the grid information within the Bookings user control
            userControlBookings.RefreshGrid();

            // Update the header title to indicate the current page as "Bookings"
            headerTitle.Text = "Bookings";

        }

        // Event handler for the Customers button click
        private void btnCostumers_Click(object sender, EventArgs e)
        {
            // Update panel and button appearance for Customers
            mvPanel.Height = btnCostumers.Height;
            mvPanel.Top = btnCostumers.Top;
            mvPanel.Left = btnCostumers.Left;
            btnCostumers.BackColor = Color.FromArgb(0, 96, 204);

            // Show and bring Customers user control to front
            userControlCustomer.Show();
            userControlCustomer.BringToFront();

            // Update header title
            headerTitle.Text = "Customers";
        }

        // Event handler for the Revenue button click
        private void btnRevenue_Click(object sender, EventArgs e)
        {
            // Update panel and button appearance for Revenue
            mvPanel.Height = btnRevenue.Height;
            mvPanel.Top = btnRevenue.Top;
            mvPanel.Left = btnRevenue.Left;
            btnRevenue.BackColor = Color.FromArgb(0, 96, 204);

            // Show and bring Revenue user control to front
            userControRevenue.Show();
            userControRevenue.BringToFront();

            // Update header title
            headerTitle.Text = "Revenue";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Update panel and button appearance for Logout
            mvPanel.Height = btnLogout.Height;
            mvPanel.Top = btnLogout.Top;
            mvPanel.Left = btnLogout.Left;
            btnLogout.BackColor = Color.FromArgb(0, 96, 204);

            // Display logout confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            // If user confirms logout, show login form and close dashboard
            if (result == DialogResult.OK)
            {
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
                this.Close();
            }
        }
        // Event handler for when Dashboard button loses focus
        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when Bookings button loses focus
        private void btnBookings_Leave(object sender, EventArgs e)
        {
            btnBookings.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when Customers button loses focus
        private void btnCostumers_Leave(object sender, EventArgs e)
        {
            btnCostumers.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when Revenue button loses focus
        private void btnRevenue_Leave(object sender, EventArgs e)
        {
            btnRevenue.BackColor = Color.FromArgb(0, 123, 255);
        }

        // Event handler for when Logout button loses focus
        private void btnLogout_Leave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(0, 123, 255);
        }


        // Event handler for when the client dashboard form is loaded
        private void frmClientDashboard_Load(object sender, EventArgs e)
        {
            // Show Dashboard user control when form is loaded
            userControlDashboard.Visible = true;
            userControlDashboard.BringToFront();
        }

        // Event handler for the Exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
            Application.Exit();
        }

     
    }
}
