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

namespace Napier_Lodges.User_Control
{
    public partial class UserControlBill : UserControl
    {
        public UserControlBill()
        {
            InitializeComponent();
        }



        private void tabPageSearchBill_Enter(object sender, EventArgs e)
        {
            // Clear the existing data in the dataGridViewBill
            dataGridViewBill.Rows.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Select data from Reservations table
                    string selectQuery = "SELECT ReservationID, RoomType, RoomNumber, ClientID, CheckIn, CheckOut FROM Reservations";

                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reservationID = Convert.ToInt32(reader["ReservationID"]);
                            int roomType = Convert.ToInt32(reader["RoomType"]);
                            int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                            int clientID = Convert.ToInt32(reader["ClientID"]);
                            DateTime checkInDate = Convert.ToDateTime(reader["CheckIn"]);
                            DateTime checkOutDate = Convert.ToDateTime(reader["CheckOut"]);

                            // Calculate days stayed and amount
                            int daysStayed = (int)Math.Ceiling((checkOutDate - checkInDate).TotalDays);

                            // Fetch cost per day from RoomType table
                            int costPerDay = GetCostPerDay(roomType);

                            // Calculate the total amount
                            int totalAmount = daysStayed * costPerDay;

                            // Insert data into Bill table
                            InsertIntoBill(reservationID, roomType, roomNumber, clientID, daysStayed, totalAmount);

                            // Display data in dataGridViewBill
                            dataGridViewBill.Rows.Add(reservationID, GetClientName(clientID), GetRoomTypeName(roomType),
                                roomNumber, checkInDate, checkOutDate, daysStayed, totalAmount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Helper method to fetch cost per day from RoomType table
        private int GetCostPerDay(int roomType)
        {
            int costPerDay = 0;

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT CostPerDay FROM RoomType WHERE TypeID = @RoomType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", roomType);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            costPerDay = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return costPerDay;
        }

        // Helper method to insert data into the Bill table
        // Helper method to insert data into the Bill table
        private void InsertIntoBill(int reservationID, int roomType, int roomNumber, int clientID, int daysStayed, int totalAmount)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Check if the entry with the same ReservationID already exists
                    string checkExistenceQuery = "SELECT COUNT(*) FROM Bill WHERE ReservationID = @ReservationID";
                    using (SqlCommand checkExistenceCommand = new SqlCommand(checkExistenceQuery, connection))
                    {
                        checkExistenceCommand.Parameters.AddWithValue("@ReservationID", reservationID);

                        int entryCount = Convert.ToInt32(checkExistenceCommand.ExecuteScalar());

                        // If an entry with the same ReservationID exists, do not insert a new one
                        if (entryCount > 0)
                        {
                            return;
                        }
                    }

                    // Insert data into Bill table
                    string insertQuery = "INSERT INTO Bill (ReservationID, RoomType, RoomNumber, ClientID, DaysStayed, TotalAmount, PaymentStatus) " +
                                        "VALUES (@ReservationID, @RoomType, @RoomNumber, @ClientID, @DaysStayed, @TotalAmount, 'Unpaid')";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@ReservationID", reservationID);
                        insertCommand.Parameters.AddWithValue("@RoomType", roomType);
                        insertCommand.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        insertCommand.Parameters.AddWithValue("@ClientID", clientID);
                        insertCommand.Parameters.AddWithValue("@DaysStayed", daysStayed);
                        insertCommand.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        insertCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // Helper method to get client name based on clientID
        private string GetClientName(int clientID)
        {
            string clientName = "Unknown";

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT FirstName, LastName FROM Client WHERE ClientID = @ClientID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                clientName = $"{firstName} {lastName}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return clientName;
        }

        private string GetRoomTypeName(int roomType)
        {
            string roomTypeName = "Unknown";

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT TypeName FROM RoomType WHERE TypeID = @RoomType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", roomType);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            roomTypeName = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return roomTypeName;
        }




    }
}
