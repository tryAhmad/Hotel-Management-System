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
    public partial class UserControlClient : UserControl
    {
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxFirstname.Clear();
            textBoxLastname.Clear();
            textBoxPhoneNo.Clear();
            textBoxEmail.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }

        public void Clear1()
        {
            textBoxFirstName1.Clear();
            textBoxLastName1.Clear();
            textBoxPhoneNo1.Clear();
            textBoxEmail1.Clear();
            ID = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string firstName = textBoxFirstname.Text;
            string lastName = textBoxLastname.Text;
            string phoneNo = textBoxPhoneNo.Text;
            string email = textBoxEmail.Text;

            // Validate input
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phoneNo))
            {
                MessageBox.Show("First Name, Last Name, and Phone Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Insert data into the Client table
                    string query = "INSERT INTO Client (FirstName, LastName, Phone, Email) VALUES (@FirstName, @LastName, @Phone, @Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Phone", phoneNo);
                        command.Parameters.AddWithValue("@Email", email);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Client added successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBoxSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchName.Text;

            // Perform search and update the DataGridView
            SearchUsers(searchTerm);
        }

        private void SearchUsers(string searchTerm)
        {
            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Perform search in the Employees table based on the username
                    string query = "SELECT ClientID, FirstName, LastName, Phone, Email FROM Client WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridViewClient.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void textBoxSearchLastName_TextChanged(object sender, EventArgs e)
        {

        }



        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxSearchName.Clear();
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string updatedFirstName = textBoxFirstName1.Text;
            string updatedLastName = textBoxLastName1.Text;
            string updatedPhoneNo = textBoxPhoneNo1.Text;
            string updatedEmail = textBoxEmail1.Text;

            // Validate input if needed

            // Check if a row is selected in the DataGridView
            // Check if a row is selected
            if (!string.IsNullOrEmpty(ID))
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
                {
                    try
                    {
                        connection.Open();

                        // Update data in the Employees table
                        string query = "UPDATE Client SET FirstName = @UpdatedFirstName, LastName = @UpdatedLastName, Phone = @UpdatedPhoneNo, Email = @UpdatedEmail WHERE ClientID = @ClientID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UpdatedFirstName", updatedFirstName);
                            command.Parameters.AddWithValue("@UpdatedLastName", updatedLastName);
                            command.Parameters.AddWithValue("@UpdatedPhoneNo", updatedPhoneNo);
                            command.Parameters.AddWithValue("@UpdatedEmail", updatedEmail);
                            command.Parameters.AddWithValue("@ClientID", ID);


                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User updated successfully");
                            }
                            else
                            {
                                MessageBox.Show("User not found or no changes made");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridViewClient.SelectedRows.Count > 0)
            {
                // Get the ClientID of the selected row
                

                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
                {
                    try
                    {
                        connection.Open();

                        // Delete the client from the Client table
                        string query = "DELETE FROM Client WHERE ClientID = @ClientID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ClientID", ID);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Client deleted successfully");

                                // Clear textboxes after deletion
                                textBoxFirstName1.Text = string.Empty;
                                textBoxLastName1.Text = string.Empty;
                                textBoxPhoneNo1.Text = string.Empty;
                                textBoxEmail1.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("Client not found or deletion failed");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.");
            }
        }

        private void tabPageUpdateDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void UserControlClient_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            SearchEmployees(textBoxSearchName.Text);
        }

        private void SearchEmployees(string searchTerm)
        {
            // Establish a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Perform search in the Employees table
                    string query = "SELECT ClientID AS ID, FirstName, LastName, Phone AS Contact, Email FROM Client WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR Phone LIKE @SearchTerm OR Email LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Clear existing columns in the DataGridView
                            dataGridViewClient.Columns.Clear();

                            // Bind the DataTable to the DataGridView
                            dataGridViewClient.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNo1.Text = row.Cells[3].Value.ToString();
                textBoxEmail1.Text = row.Cells[4].Value.ToString();

            }
        }
    }
}
