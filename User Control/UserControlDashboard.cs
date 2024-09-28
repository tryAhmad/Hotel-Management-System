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
    public partial class UserControlDashboard : UserControl
    {
        private string connectionString = "Data Source=HP-ELITEBOOK\\SQLEXPRESS;Initial Catalog=NapierLodges;Integrated Security=true";
        private object dataGridViewBill;

        public int GetTotalUserCount()
        {
            int userCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Employees";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        userCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log or display an error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return userCount;
        }

        public int GetTotalClientCount()
        {
            int clientCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Client";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        clientCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log or display an error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return clientCount;
        }

        public int GetTotalRoomCount()
        {
            int roomCount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Rooms";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        roomCount = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log or display an error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return roomCount;
        }

        public int GetTotalSales()
        {
            int totalSales = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(TotalAmount) FROM Bill";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            totalSales = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log or display an error message
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return totalSales;
        }


        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void labelUserCount_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {


            
        }

        private void UserControlDashboard_Enter(object sender, EventArgs e)
        {
            // Set labelUserCount
            int userCount = GetTotalUserCount();
            labelUserCount.Text = $"{userCount}";

            // Set labelClientCount
            int clientCount = GetTotalClientCount();
            labelClientCount.Text = $"{clientCount}";

            // Set labelRoomCount
            int roomCount = GetTotalRoomCount();
            labelRoomCount.Text = $"{roomCount}";

            // Set labelSalesCount
            int salesCount = GetTotalSales();
            labelSalesCount.Text = $"{salesCount}";
        }
    }
}
