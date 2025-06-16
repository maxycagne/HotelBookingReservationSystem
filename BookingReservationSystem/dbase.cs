using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookingReservationSystem
{
    internal class dbase
    {
        // Connection string for the database
        private readonly string connectionString;

        public dbase()
        {
            // Constructor to initialize connection string
            connectionString = @"Data Source=LAPTOP-R6TOEIPM\SQLEXPRESS;Initial Catalog=dbBookingandReservation;Integrated Security=True;TrustServerCertificate=True";
        }

        // Method to execute a query and return count of results
        public int Count(string query)
        {

            int count = 0;
            // Establishing connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Creating SQL command
                SqlCommand command = new SqlCommand(query, connection);
                // Opening the connection
                connection.Open();
                // Executing the query and getting the count
                count = (int)command.ExecuteScalar();
                return count;
            }
        }

    }
}
