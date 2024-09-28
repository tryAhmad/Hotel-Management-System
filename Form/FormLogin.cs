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

namespace Napier_Lodges
{
    public partial class FormLogin : Form
    {
        public FormLogin() => InitializeComponent();
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Equals(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            ToolTip.Equals(pictureBoxHide, "Hide Password");       
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = HP-ELITEBOOK\\SQLEXPRESS; Initial Catalog = NapierLodges; Integrated Security=true";
            SqlConnection con = new SqlConnection(connstring);
            
            if(textBoxUsername.Text.Trim()== string.Empty || textBoxPassword.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please fill out all fields", "Required Feild", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Employees WHERE Name = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text.Trim());

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Add code to navigate to the next form or perform other actions upon successful login.
                        FormDashboard fd = new FormDashboard();
                        fd.username = textBoxUsername.Text;
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        fd.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }


            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
