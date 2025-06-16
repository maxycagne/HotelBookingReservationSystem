using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BookingReservationSystem.User_Control_Client
{
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
            // Initialize event handler for printing
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        // Connection string to the database
        private string connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";

        // Method to bind data to the DataGridView
        public void BindGrid()
        {
            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("SELECT RoomNumber, ClientUsername, DiscountedPrice From Bookings", connection))
                    {
                        // Adapter to fill data from SQL command to DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            // Set DataGridView's data source to the filled DataTable
                            dataGridView1.DataSource = dataTable;

                            // Calculate total discounted price
                            decimal totalDiscountedPrice = 0;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                if (row["DiscountedPrice"] != DBNull.Value)
                                {
                                    totalDiscountedPrice += Convert.ToDecimal(row["DiscountedPrice"]);
                                }
                            }
                            // Display total revenue
                            revenue.Text = totalDiscountedPrice.ToString("C2");
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // Event handler for print button click
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Show print preview dialog
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        // Event handler for printing
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Convert DataGridView to bitmap and draw on print page
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

            // Print total revenue below DataGridView
            string totalRevenueText = "Total Revenue: " + revenue.Text;
            Font font = new Font("Arial", 12, FontStyle.Bold);
            e.Graphics.DrawString(totalRevenueText, font, Brushes.Black, new PointF(0, this.dataGridView1.Height + 10));
        }

        // Event handler for show button click
        private void btShow_Click(object sender, EventArgs e)
        {
            BindGrid();// Call BindGrid method to bind data to DataGridView
        }

        private void roomPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
