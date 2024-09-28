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
    public partial class UserControlRoom : UserControl
    {
        public UserControlRoom()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            // Get values from the text box and radio buttons
            int roomNumber;

            if (!int.TryParse(textBoxRoomNo.Text, out roomNumber))
            {
                MessageBox.Show("Please enter a valid room number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int roomTypeID = GetSelectedRoomTypeID();
            string roomStatus = radioButtonVacant.Checked ? "Vacant" : "Vacant";

            // Validate input if needed

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Insert data into the Rooms table
                    string query = "INSERT INTO Rooms (RoomNumber, TypeID, RoomStatus) VALUES (@RoomNumber, @RoomTypeID, @RoomStatus)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                        command.Parameters.AddWithValue("@RoomTypeID", roomTypeID);
                        command.Parameters.AddWithValue("@RoomStatus", roomStatus);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Room added successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Helper method to get the selected room type ID
        private int GetSelectedRoomTypeID()
        {
            if (radioButtonSingleRoom.Checked) return 1;
            else if (radioButtonDoubleRoom.Checked) return 2;
            else if (radioButtonTwinRoom.Checked) return 3;
            else if (radioButtonFamilyRoom.Checked) return 4;
            else if (radioButtonDeluxeRoom.Checked) return 5;
            else if (radioButtonAdjoiningRooms.Checked) return 6;
            else if (radioButtonAccessibleRoom.Checked) return 7;
            else if (radioButtonPetFriendlyRoom.Checked) return 8;

            // Return a default value or handle the case where no radio button is checked
            return 0;
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Perform a join operation to get room information along with type names
                    string query = "SELECT Rooms.RoomNumber AS Room_No, RoomType.TypeName AS Room_Type, Rooms.RoomStatus AS Room_Status " +
                                   "FROM Rooms " +
                                   "JOIN RoomType ON Rooms.TypeID = RoomType.TypeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridViewSearchRoom.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void radioButtonSearchVacant_CheckedChanged(object sender, EventArgs e)
        {
            // Trigger the search when the radio button is checked
            if (radioButtonSearchVacant.Checked)
            {
                PerformRoomSearch();
            }
        }

        private void PerformRoomSearch()
        {
            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Perform a join operation to get room information along with type names
                    string query = "SELECT Rooms.RoomNumber AS Room_No, RoomType.TypeName AS Room_Type, Rooms.RoomStatus AS Room_Status " +
                                   "FROM Rooms " +
                                   "JOIN RoomType ON Rooms.TypeID = RoomType.TypeID";

                    // Add a WHERE clause to filter by room status if the radioButtonSearchVacant is checked
                    if (radioButtonSearchVacant.Checked)
                    {
                        query += " WHERE Rooms.RoomStatus = 'Vacant'";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridViewSearchRoom.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Occupied_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSearchOccupied.Checked)
            {
                PerformRoomSearchocc();
            }
        }


        private void PerformRoomSearchocc()
        {
            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Perform a join operation to get room information along with type names
                    string query = "SELECT Rooms.RoomNumber AS Room_No, RoomType.TypeName AS Room_Type, Rooms.RoomStatus AS Room_Status " +
                                   "FROM Rooms " +
                                   "JOIN RoomType ON Rooms.TypeID = RoomType.TypeID";

                    // Add a WHERE clause to filter by room status based on the checked radio button
                    if (radioButtonSearchVacant.Checked)
                    {
                        query += " WHERE Rooms.RoomStatus = 'Vacant'";
                    }
                    else if (radioButtonSearchOccupied.Checked)
                    {
                        query += " WHERE Rooms.RoomStatus = 'Occupied'";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridViewSearchRoom.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tabPageRoomType_Enter(object sender, EventArgs e)
        {
            // Update the RoomType grid when entering the tab page
            UpdateRoomTypeGrid();
        }

        private void UpdateRoomTypeGrid()
        {
            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Select data from the RoomType table
                    string query = "SELECT TypeID AS Type_ID, TypeName AS Type_Name, RoomFeatures AS Room_Features, CostPerDay AS Room_Cost FROM RoomType";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridViewRoomType.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridViewSearchRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not the header and a valid row
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewSearchRoom.Rows[e.RowIndex];

                // Fetch data from columns
                string roomNumber = row.Cells[0].Value.ToString();
                string roomStatus = row.Cells[2].Value.ToString();

                // Populate controls
                textBoxRoomUpdatedelete.Text = roomNumber;

                // Check the appropriate radio button based on the room status
                if (roomStatus == "Vacant")
                {
                    radioButtonRoomVacantUpd.Checked = true;
                    radioButtonRoomOccupiedUpd.Checked = false;
                }
                else if (roomStatus == "Occupied")
                {
                    radioButtonRoomVacantUpd.Checked = false;
                    radioButtonRoomOccupiedUpd.Checked = true;
                }
            }
        }

        private void buttonUpdateRoom_Click(object sender, EventArgs e)
        {
            // Get the room number and new room status from the TextBox and RadioButtons
            string roomNumber = textBoxRoomUpdatedelete.Text;
            string newRoomStatus = radioButtonRoomVacantUpd.Checked ? "Vacant" : "Occupied";

            // Validate the input if needed

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Update the room status in the Rooms table
                    string query = "UPDATE Rooms SET RoomStatus = @NewRoomStatus WHERE RoomNumber = @RoomNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewRoomStatus", newRoomStatus);
                        command.Parameters.AddWithValue("@RoomNumber", roomNumber);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room status updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Room not found or status not updated");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            // Get the room number from the TextBox
            string roomNumber = textBoxRoomUpdatedelete.Text;

            // Validate the input if needed

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Delete the room from the Rooms table
                    string query = "DELETE FROM Rooms WHERE RoomNumber = @RoomNumber";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomNumber", roomNumber);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Room not found or not deleted");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tabPageUpdateDeleteRoom_Leave(object sender, EventArgs e)
        {
            // Clear the room number TextBox
            textBoxRoomUpdatedelete.Text = string.Empty;

            // Uncheck any radio buttons
            radioButtonRoomVacantUpd.Checked = false;
            radioButtonRoomOccupiedUpd.Checked = false;
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            radioButtonSearchVacant.Checked = false;
            radioButtonSearchOccupied.Checked = false;
        }
    }
}
