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

namespace BookingReservationSystem
{
    public partial class frmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        // Importing function from Gdi32.dll to create a rounded form
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public frmLogin()
        {
            InitializeComponent();
            // Make the form rounded
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }


        // Static class to store session data
        public static class Session
        {
            public static string LoggedInUsername { get; set; }
        }

        // Event handler for the Admin button hover
        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            btnAdmin.ForeColor = Color.Black;
        }
        // Event handler for the Admin button leave
        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnAdmin.ForeColor = Color.DodgerBlue;
        }
        // Event handler for the Admin button click
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Show admin login form and hide current form
            frmAdminLogin frmAdminLogin = new frmAdminLogin();

            frmAdminLogin.Show();
            this.Hide();



        }
        // Event handler for the Exit button click
        private void Exit_Click_1(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
            Application.Exit();
        }

        // Event handler for mouse click in the username input field
        private void inputUsernameClient_MouseClick(object sender, MouseEventArgs e)
        {
            // Clear default text when clicked
            if (inputUsernameClient.Text == "Enter Username")
            {
                inputUsernameClient.Text = "";
                inputUsernameClient.ForeColor = Color.Black;
            }
        }

        // Event handler for mouse click in the password input field
        private void inputPasswordClient_MouseClick(object sender, MouseEventArgs e)
        {
            // Clear default text when clicked
            if (inputPasswordClient.Text == "Enter Password")
            {
                inputPasswordClient.Text = "";
                inputPasswordClient.ForeColor = Color.Black;

                // Show password characters
                if (inputPasswordClient.Text == "")
                {
                    inputPasswordClient.PasswordChar = '●';
                }
            }

        }

        // Event handler for hiding password characters
        private void btnHidePasswordClient_Click(object sender, EventArgs e)
        {
            if (inputPasswordClient.PasswordChar == '\0')
            {
                btnShowPasswordClient.BringToFront();
                inputPasswordClient.PasswordChar = '●';

            }
        }

        // Event handler for showing password characters
        private void btnShowPasswordClient_Click(object sender, EventArgs e)
        {
            if (inputPasswordClient.PasswordChar == '●')
            {
                btnHidePasswordClient.BringToFront();
                inputPasswordClient.PasswordChar = '\0';

            }
        }

        // Event handler for changes in the username input field
        private void inputUsernameClient_TextChanged(object sender, EventArgs e)
        {
            inputUsernameClient.ForeColor = Color.Black;

        }

        // Event handler for changes in the password input field
        private void inputPasswordClient_TextChanged(object sender, EventArgs e)
        {
            inputUsernameClient.ForeColor = Color.Black;
        }

        // SQL connection string
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");

        // Event handler for the Login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Check if username and password fields are filled
            if (inputUsernameClient.Text == "" || inputPasswordClient.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    // SQL command to check username and password
                    string checkUsername = "SELECT * FROM Client WHERE ClientUsername = @clientUsername AND ClientPassword = @clientPassword";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@clientUsername", inputUsernameClient.Text.Trim());
                        checkUser.Parameters.AddWithValue("@clientPassword", inputPasswordClient.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // If user found, proceed to dashboard
                        if (table.Rows.Count > 0)
                        {
                            
                            frmClientDashboard frmClientDashboard = new frmClientDashboard();

                            // Store logged in username in session
                            string username = inputUsernameClient.Text;
                            Session.LoggedInUsername = username;

                            // Show dashboard and hide login form
                            frmClientDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

           

        }
    }
}
