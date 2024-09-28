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
    public partial class UserControlReservation : UserControl
    {
        private string RID = "", No;
        public UserControlReservation()
        {
            InitializeComponent();
            Load += UserControlReservation_Load;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            comboBoxRoomNo.Click += comboBoxRoomNo_Click;
            PopulateComboBoxType1();
            
        }


        public void Clear ()
        {
            
            textBoxClientIDRes.Clear();
            dateTimePickerin.Value = DateTime.Now;
            dateTimePickerout.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }

        public void Clear1()
        {
            
            textBoxClientres1.Clear();
            dateTimePickerin1.Value = DateTime.Now;
            dateTimePickerout1.Value = DateTime.Now;
            RID = "";
        }

        private void tabPageAddReservation_Click(object sender, EventArgs e)
        {

        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            PopulateRoomTypes();
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = -1;
            comboBoxRoomNo.Items.Clear();
            textBoxClientIDRes.Clear();
            dateTimePickerin.Value = DateTime.Now;
            dateTimePickerout.Value = DateTime.Now;
        }

        private void tabPageUpdateCancelReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateRoomNumbers();
        }

        private void tabPageAddReservation_Enter(object sender, EventArgs e)
        {
            // Clear controls when entering the tabPageAddReservation
            comboBoxType.SelectedIndex = -1;
            comboBoxRoomNo.Items.Clear();
            textBoxClientIDRes.Clear();
            dateTimePickerin.Value = DateTime.Now;
            dateTimePickerout.Value = DateTime.Now;
        }


        private void PopulateRoomTypes()
        {
            comboBoxType.Items.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TypeName FROM RoomType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string roomTypeName = reader["TypeName"].ToString();
                            comboBoxType.Items.Add(roomTypeName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void comboBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void PopulateRoomNumbers()
        {
            comboBoxRoomNo.Items.Clear();

            string selectedRoomType = comboBoxType.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedRoomType))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT RoomNumber FROM Rooms " +
                                       "WHERE TypeID = (SELECT TypeID FROM RoomType WHERE TypeName = @RoomTypeName) " +
                                       "AND RoomStatus = 'Vacant'";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RoomTypeName", selectedRoomType);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                                    comboBoxRoomNo.Items.Add(roomNumber);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void comboBoxRoomNo_Click(object sender, EventArgs e)
        {
            // Populate room numbers when the comboBoxRoomNo is clicked
            PopulateRoomNumbers();
        }

        private void comboBoxRoomNo_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            // Get the selected values from controls
            string selectedRoomType = comboBoxType.SelectedItem?.ToString();
            int selectedRoomNumber = (int)comboBoxRoomNo.SelectedItem;
            int clientID = Convert.ToInt32(textBoxClientIDRes.Text);
            DateTime checkInDate = dateTimePickerin.Value;
            DateTime checkOutDate = dateTimePickerout.Value;

            // Get the TypeID for the selected room type
            int roomTypeID = GetRoomTypeID(selectedRoomType);

            // Perform the reservation by inserting data into the Reservations table
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Reservations (RoomType, RoomNumber, ClientID, CheckIn, CheckOut) " +
                                   "VALUES (@RoomType, @RoomNumber, @ClientID, @CheckIn, @CheckOut)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomType", roomTypeID);
                        command.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                        command.Parameters.AddWithValue("@ClientID", clientID);
                        command.Parameters.AddWithValue("@CheckIn", checkInDate);
                        command.Parameters.AddWithValue("@CheckOut", checkOutDate);

                        command.ExecuteNonQuery();

                        string updateRoomStatusQuery = "UPDATE Rooms SET RoomStatus = 'Occupied' WHERE RoomNumber = @RoomNumber";

                        using (SqlCommand updateRoomStatusCommand = new SqlCommand(updateRoomStatusQuery, connection))
                        {
                            updateRoomStatusCommand.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                            updateRoomStatusCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Reservation added successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int GetRoomTypeID(string roomTypeName)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TypeID FROM RoomType WHERE TypeName = @RoomTypeName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomTypeName", roomTypeName);

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return -1; // Return a default value or handle accordingly
        }

        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            // Load reservations data when entering the tabPageSearchReservation
            LoadReservationsData();
        }

        private void LoadReservationsData()
        {
            dataGridViewReservation.Rows.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Reservations.ReservationID, " +
                                   "Reservations.RoomType, " +
                                   "Reservations.RoomNumber, " +
                                   "Reservations.ClientID, " +
                                   "Reservations.CheckIn, " +
                                   "Reservations.CheckOut, " +
                                   "RoomType.CostPerDay " +
                                   "FROM Reservations " +
                                   "INNER JOIN RoomType ON Reservations.RoomType = RoomType.TypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int reservationID = Convert.ToInt32(reader["ReservationID"]);
                            int roomType = Convert.ToInt32(reader["RoomType"]);
                            int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                            int clientID = Convert.ToInt32(reader["ClientID"]);
                            DateTime checkInDate = Convert.ToDateTime(reader["CheckIn"]);
                            DateTime checkOutDate = Convert.ToDateTime(reader["CheckOut"]);
                            int costPerDay = Convert.ToInt32(reader["CostPerDay"]);

                            // Calculate the number of days stayed
                            int daysStayed = (int)Math.Ceiling((checkOutDate - checkInDate).TotalDays);

                            // Calculate the reservation amount
                            int reservationAmount = daysStayed * costPerDay;

                            dataGridViewReservation.Rows.Add(reservationID, roomType, roomNumber, clientID, checkInDate, checkOutDate, reservationAmount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void textBoxSearchClientIDres_TextChanged(object sender, EventArgs e)
        {
            // Filter and update data based on the entered client ID
            FilterReservationsByClientID(textBoxSearchClientIDres.Text);
        }

        private void FilterReservationsByClientID(string clientIDFilter)
        {
            dataGridViewReservation.Rows.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Reservations.ReservationID, " +
                                   "Reservations.RoomType, " +
                                   "Reservations.RoomNumber, " +
                                   "Reservations.ClientID, " +
                                   "Reservations.CheckIn, " +
                                   "Reservations.CheckOut, " +
                                   "RoomType.CostPerDay " +
                                   "FROM Reservations " +
                                   "INNER JOIN RoomType ON Reservations.RoomType = RoomType.TypeID " +
                                   "WHERE Reservations.ClientID LIKE @ClientID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", "%" + clientIDFilter + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int reservationID = Convert.ToInt32(reader["ReservationID"]);
                                int roomType = Convert.ToInt32(reader["RoomType"]);
                                int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                                int clientID = Convert.ToInt32(reader["ClientID"]);
                                DateTime checkInDate = Convert.ToDateTime(reader["CheckIn"]);
                                DateTime checkOutDate = Convert.ToDateTime(reader["CheckOut"]);
                                int costPerDay = Convert.ToInt32(reader["CostPerDay"]);

                                // Calculate the number of days stayed
                                int daysStayed = (int)(checkOutDate - checkInDate).TotalDays;

                                // Calculate the reservation amount
                                int reservationAmount = daysStayed * costPerDay;

                                dataGridViewReservation.Rows.Add(reservationID, roomType, roomNumber, clientID, checkInDate, checkOutDate, daysStayed, reservationAmount);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            // Clear the client ID textbox when leaving the tabPageSearchReservation
            textBoxSearchClientIDres.Clear();
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];

                // Assuming your DataGridView columns are named ClientID, CheckIn, CheckOut
                int clientID = Convert.ToInt32(row.Cells[3].Value);
                DateTime checkInDate = Convert.ToDateTime(row.Cells[4].Value);
                DateTime checkOutDate = Convert.ToDateTime(row.Cells[5].Value);

                // Populate controls with the values from the selected row
                textBoxClientres1.Text = clientID.ToString();
                dateTimePickerin1.Value = checkInDate;
                dateTimePickerout1.Value = checkOutDate;
            }
        }



        private void buttonUpdateReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxType1.SelectedItem != null)
            {
                // Get values from controls
                int selectedRoomType = ((KeyValuePair<int, string>)comboBoxType1.SelectedItem).Key;
                int selectedRoomNumber = Convert.ToInt32(comboBoxRoomNo1.SelectedItem);
                int clientID = Convert.ToInt32(textBoxClientres1.Text);
                DateTime checkInDate = dateTimePickerin1.Value;
                DateTime checkOutDate = dateTimePickerout1.Value;

                // Validate input if needed

                using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
                {
                    try
                    {
                        connection.Open();

                        // Get the current room number associated with the reservation
                        int currentRoomNumber = GetCurrentRoomNumberForReservation(); // Implement this method to get the current room number

                        // Update the reservation table
                        string updateReservationQuery = "UPDATE Reservations " +
                                                       "SET RoomType = @RoomType, RoomNumber = @RoomNumber, ClientID = @ClientID, " +
                                                       "CheckIn = @CheckIn, CheckOut = @CheckOut " +
                                                       "WHERE ReservationID = @ReservationID";

                        using (SqlCommand updateReservationCommand = new SqlCommand(updateReservationQuery, connection))
                        {
                            updateReservationCommand.Parameters.AddWithValue("@RoomType", selectedRoomType);
                            updateReservationCommand.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                            updateReservationCommand.Parameters.AddWithValue("@ClientID", clientID);
                            updateReservationCommand.Parameters.AddWithValue("@CheckIn", checkInDate);
                            updateReservationCommand.Parameters.AddWithValue("@CheckOut", checkOutDate);

                            // Assuming you have the ReservationID stored somewhere (e.g., as a class variable)
                            // If not, you need to find a way to get the ReservationID of the selected reservation
                            int reservationID = GetSelectedReservationID(); // Implement this method to get the ReservationID
                            updateReservationCommand.Parameters.AddWithValue("@ReservationID", reservationID);

                            updateReservationCommand.ExecuteNonQuery();
                        }

                        // Update the room status to 'Vacant' for the current room
                        int roomNo = Convert.ToInt32(dataGridViewReservation.SelectedRows[0].Cells[2].Value);
                        string updateRoomStatusQuery = "UPDATE Rooms SET RoomStatus = 'Vacant' WHERE RoomNumber = @RoomNumber";

                        using (SqlCommand updateRoomStatusCommand = new SqlCommand(updateRoomStatusQuery, connection))
                        {
                            updateRoomStatusCommand.Parameters.AddWithValue("@RoomNumber", roomNo);
                            updateRoomStatusCommand.ExecuteNonQuery();
                        }


                        // Update the room status to 'Occupied' for the selected room
                        updateRoomStatusQuery = "UPDATE Rooms SET RoomStatus = 'Occupied' WHERE RoomNumber = @RoomNumber";

                        using (SqlCommand updateSelectedRoomStatusCommand = new SqlCommand(updateRoomStatusQuery, connection))
                        {
                            updateSelectedRoomStatusCommand.Parameters.AddWithValue("@RoomNumber", selectedRoomNumber);
                            updateSelectedRoomStatusCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reservation updated successfully!");

                        // Clear all fields
                        comboBoxType1.SelectedIndex = -1;
                        comboBoxRoomNo1.Items.Clear();
                        textBoxClientres1.Clear();
                        dateTimePickerin1.Value = DateTime.Now;
                        dateTimePickerout1.Value = DateTime.Now;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                // Handle the case where no item is selected in comboBoxType1
                MessageBox.Show("Please select a room type.");
            }
        }

        private int GetCurrentRoomNumberForReservation()
        {
            // Implement this method to retrieve the current room number associated with the selected reservation
            // For example, query the Reservations table based on the selected ReservationID
            // Return the current room number
            return 0; // Replace with actual logic
        }



        // Implement this method to get the ReservationID of the selected reservation
        private int GetSelectedReservationID()
        {
            if (dataGridViewReservation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewReservation.SelectedRows[0];
                int reservationID = Convert.ToInt32(selectedRow.Cells[0].Value);
                return reservationID;
            }

            // If no row is selected, return a default or handle as needed
            return -1; // Replace with an appropriate default value or error handling
        }

        private void buttonCancelReservation_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in dataGridViewReservation
            if (dataGridViewReservation.SelectedRows.Count > 0)
            {
                // Get the ReservationID and RoomNumber from the selected row
                int reservationID = Convert.ToInt32(dataGridViewReservation.SelectedRows[0].Cells[0].Value);
                int roomNumber = Convert.ToInt32(dataGridViewReservation.SelectedRows[0].Cells[2].Value);

                // Execute the SQL UPDATE and DELETE statements
                using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
                {
                    try
                    {
                        connection.Open();

                        // Update the room status to 'Vacant'
                        string updateRoomStatusQuery = "UPDATE Rooms SET RoomStatus = 'Vacant' WHERE RoomNumber = @RoomNumber";

                        using (SqlCommand updateRoomStatusCommand = new SqlCommand(updateRoomStatusQuery, connection))
                        {
                            updateRoomStatusCommand.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            updateRoomStatusCommand.ExecuteNonQuery();
                        }

                        // Delete the reservation
                        string deleteReservationQuery = "DELETE FROM Reservations WHERE ReservationID = @ReservationID";

                        using (SqlCommand deleteReservationCommand = new SqlCommand(deleteReservationQuery, connection))
                        {
                            deleteReservationCommand.Parameters.AddWithValue("@ReservationID", reservationID);
                            deleteReservationCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Reservation canceled successfully!");

                        // Optionally, refresh the data in dataGridViewReservation after deletion
                        LoadReservationsData();

                        comboBoxType1.SelectedIndex = -1;
                        comboBoxRoomNo1.Items.Clear();
                        textBoxClientres1.Clear();
                        dateTimePickerin1.Value = DateTime.Now;
                        dateTimePickerout1.Value = DateTime.Now;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to cancel.");
            }
        }


        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change event if needed
            // Example: Display the selected TypeID and TypeName in a MessageBox
            if (comboBoxType1.SelectedItem != null)
            {
                KeyValuePair<int, string> selectedType = (KeyValuePair<int, string>)comboBoxType1.SelectedItem;
                MessageBox.Show($"Selected TypeID: {selectedType.Key}, TypeName: {selectedType.Value}");
                // Update comboBoxRoomNo1 based on the selected room type
                PopulateRoomNumbers(selectedType.Key);
            }
        }

        private void PopulateRoomNumbers(int selectedTypeID)
        {
            comboBoxRoomNo1.Items.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT RoomNumber FROM Rooms " +
                                   "WHERE TypeID = @TypeID ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TypeID", selectedTypeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int roomNumber = Convert.ToInt32(reader["RoomNumber"]);
                                comboBoxRoomNo1.Items.Add(roomNumber);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void PopulateComboBoxType1()
        {
            comboBoxType1.Items.Clear();

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT TypeID, TypeName FROM RoomType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int typeID = Convert.ToInt32(reader["TypeID"]);
                            string typeName = reader["TypeName"].ToString();
                            comboBoxType1.Items.Add(new KeyValuePair<int, string>(typeID, typeName));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void comboBoxRoomNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        


        private void comboBoxRoomNo1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void tabPageUpdateCancelReservation_Click(object sender, EventArgs e)
        {

        }
    }
}
