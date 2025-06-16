using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookingReservationSystem.dbase;

namespace BookingReservationSystem.User_Control
{
    public partial class UserControl2 : UserControl
    {
        // Instance of the database class
        dbase db;
        public UserControl2()
        {
            InitializeComponent();

            db = new dbase();  // Creates a new instance of the database class


        }

        // Method to get and display the count of clients
        public void Client()
        {
            // Executes a SQL query to count clients and sets the result to clientUser text
            clientUser.Text = db.Count("SELECT COUNT(*) FROM Client").ToString();
        }

        // Method to get and display the count of admins
        public void Admin()
        {
            // Executes a SQL query to count admins and sets the result to adminUser text
            adminUser.Text = db.Count("SELECT COUNT(*) FROM Admin").ToString();
        }

        // Method to get and display the count of rooms
        public void Rooms()
        {
            // Executes a SQL query to count rooms and sets the result to rooms text
            rooms.Text = db.Count("SELECT COUNT(*) FROM Room").ToString();
        }

        // Method to get and display the count of room types
        public void RoomType()
        {
            // Executes a SQL query to count room types and sets the result to roomTypes text
            roomTypes.Text = db.Count("SELECT COUNT(*) FROM RoomType").ToString();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            // Calls methods to update counts on UI load
            Client();
            Admin();
            Rooms();
            RoomType();
            
        }

    }
}
