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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;



namespace BookingReservationSystem
{
    public partial class frmAdminLogin : Form
    {
        // SqlConnection object for database connection
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True");

        // Importing method from Gdi32.dll for creating rounded corners in form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public frmAdminLogin()
        {
            InitializeComponent();
            // Applying rounded corners to the form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        // Event handler for client button click
        private void btnClient_Click(object sender, EventArgs e)
        {
            // Redirecting to client login form
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        // Event handler for exit button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closing the application
            this.Close();
            Application.Exit();
        }

        // Event handler for client button hover
        private void btnClient_MouseHover(object sender, EventArgs e)
        {
            btnClient.ForeColor = Color.Black;

        }

        // Event handler for client button leave
        private void btnClient_MouseLeave(object sender, EventArgs e)
        {
            btnClient.ForeColor = Color.DodgerBlue;
        }

        // Event handler for username input click
        private void inputUsernameAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            // Clearing default text when clicked
            if (inputUsernameAdmin.Text == "Enter Username")
            {
                inputUsernameAdmin.Text = "";
                inputUsernameAdmin.ForeColor = Color.Black;
            }

        }

        // Event handler for password input click
        private void inputPasswordAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            // Clearing default text and displaying password characters
            if (inputPasswordAdmin.Text == "Enter Password")
            {
                inputPasswordAdmin.Text = "";
                inputPasswordAdmin.ForeColor = Color.Black;

                if (inputPasswordAdmin.Text == "")
                {
                    inputPasswordAdmin.PasswordChar = '●';
                }
            }

        }

        // Event handler for show password button click
        private void btnShowPasswordAdmin_Click(object sender, EventArgs e)
        {
            // Showing password characters
            if (inputPasswordAdmin.PasswordChar == '●')
            {
                btnHidePasswordAdmin.BringToFront();
                inputPasswordAdmin.PasswordChar = '\0';

            }

        }

        // Event handler for hide password button click
        private void btnHidePasswordAdmin_Click(object sender, EventArgs e)
        {
            // Hiding password characters
            if (inputPasswordAdmin.PasswordChar == '\0')
            {
                btnShowPasswordAdmin.BringToFront();
                inputPasswordAdmin.PasswordChar = '●';

            }

        }

        // Event handler for username input change
        private void inputUsernameAdmin_TextChanged(object sender, EventArgs e)
        {
            inputUsernameAdmin.ForeColor = Color.Black;
        }

        // Event handler for password input change
        private void inputPasswordAdmin_TextChanged(object sender, EventArgs e)
        {
            inputUsernameAdmin.ForeColor = Color.Black;
        }

        // Event handler for login button click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validating username and password
            if (inputUsernameAdmin.Text == "" || inputPasswordAdmin.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checking database connection
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkUsername = "SELECT * FROM Admin WHERE AdminUsername = @adminUsername AND AdminPassword = @adminPassword";
                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@adminUsername", inputUsernameAdmin.Text.Trim());
                        checkUser.Parameters.AddWithValue("@adminPassword", inputPasswordAdmin.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Redirecting to admin dashboard if credentials are correct
                        if (table.Rows.Count > 0)
                        {
                            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
                            frmAdminDashboard.Show();
                            this.Close();
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

        // Event handler for change password button hover
        private void btnChangePass_MouseHover(object sender, EventArgs e)
        {
            btnChangePass.ForeColor = Color.Black;
        }

        // Event handler for change password button leave
        private void btnChangePass_MouseLeave(object sender, EventArgs e)
        {
            btnChangePass.ForeColor = Color.DodgerBlue;
        }

        // Event handler for change password button click
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            // Redirecting to change password form
            AdminChangePass adminpass = new AdminChangePass();
            adminpass.Show();
        }
    }
}