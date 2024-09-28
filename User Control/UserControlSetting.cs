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
    public partial class UserControlSetting : UserControl
    {
        private string ID = ""; 
        public UserControlSetting()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxPosition.Clear();
            textBoxContact.Clear();
            tabControlUser.SelectedTab = tabPageAddEmp;
        }

        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxUserPassword1.Clear();
            textBoxUserposition1.Clear();
            textBoxUserContact1.Clear();
            ID = "";
        }

        private void tabPageAddEmp_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchEmp_Enter(object sender, EventArgs e)
        {
            // Perform search when entering the tabPageSearchEmp
            SearchEmployees(textBoxSearchUser.Text);
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
                    string query = "SELECT EmployeeID AS ID, Name AS Username, Password,Position, ContactInformation AS Contact FROM Employees WHERE Name LIKE @SearchTerm OR Position LIKE @SearchTerm OR ContactInformation LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Clear existing columns in the DataGridView
                            dataGridViewUser.Columns.Clear();

                            // Bind the DataTable to the DataGridView
                            dataGridViewUser.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void tabPageSearchEmp_Leave(object sender, EventArgs e)
        {
            textBoxSearchUser.Clear();
        }

        private void tabPageUpdateDeleteEmployee_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string name = textBoxUsername.Text;
            string position = textBoxPosition.Text;
            string contact = textBoxContact.Text;
            string password = textBoxPassword.Text;

            // Check if all fields are filled
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill out all fields", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any field is empty
            }

            // Establish a connection to the database

            using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
            {
                try
                {
                    connection.Open();

                    // Insert data into the Employees table
                    string query = "INSERT INTO Employees (Name, Position, ContactInformation, Password) " +
                                   "VALUES (@Name, @Position, @Contact, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Position", position);
                        command.Parameters.AddWithValue("@Contact", contact);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Employee added successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string updatedUsername = textBoxUsername1.Text;
            string updatedPosition = textBoxUserposition1.Text;
            string updatedPassword = textBoxUserPassword1.Text;
            string updatedContact = textBoxUserContact1.Text;

            // Validate input if needed

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
                        string query = "UPDATE Employees SET Name = @UpdatedUsername, Position = @UpdatedPosition, Password = @UpdatedPassword, ContactInformation = @UpdatedContact WHERE EmployeeID = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UpdatedUsername", updatedUsername);
                            command.Parameters.AddWithValue("@UpdatedPosition", updatedPosition);
                            command.Parameters.AddWithValue("@UpdatedPassword", updatedPassword);
                            command.Parameters.AddWithValue("@UpdatedContact", updatedContact);
                            command.Parameters.AddWithValue("@ID", ID);

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (!string.IsNullOrEmpty(ID))
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection("Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true"))
                {
                    try
                    {
                        connection.Open();

                        // Delete the user from the Employees table
                        string query = "DELETE FROM Employees WHERE EmployeeID = @ID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ID", ID);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully");

                                // Clear textboxes after deletion
                                textBoxUsername1.Text = string.Empty;
                                textBoxUserPassword1.Text = string.Empty;
                                textBoxUserposition1.Text = string.Empty;
                                textBoxUserContact1.Text = string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("User not found or deletion failed");
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
                MessageBox.Show("Please select a user to delete.");
            }

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxUsername1.Text = row.Cells[1].Value.ToString();
                textBoxUserPassword1.Text = row.Cells[2].Value.ToString();
                textBoxUserposition1.Text = row.Cells[3].Value.ToString();
                textBoxUserContact1.Text = row.Cells[4].Value.ToString();
                
            }
        }

        private void textBoxSearchUser_TextChanged(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = textBoxSearchUser.Text;

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
                    string query = "SELECT * FROM Employees WHERE Name LIKE @SearchTerm";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                        // Use SqlDataAdapter to fill the DataTable with the results
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridViewUser.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
