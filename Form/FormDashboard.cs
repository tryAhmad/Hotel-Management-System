using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Napier_Lodges
{
    public partial class FormDashboard : Form
    {
        public string username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;

        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = username;
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashBoard);

            userControlClient1.Hide();

            userControlSetting1.Hide();

            userControlRoom1.Hide();

            userControlReservation1.Hide();

            userControlDashboard1.Show();

            userControlBill1.Hide();

        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClients);
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlBill1.Hide();

        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRooms);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Show();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlBill1.Hide();

        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Clear();
            userControlReservation1.Show();
            userControlDashboard1.Hide();
            userControlBill1.Hide();

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlBill1.Hide();

        }

        private void userControlClient1_Load(object sender, EventArgs e)
        {

        }

        private void userControlRoom1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBill_Click(object sender, EventArgs e)
        {
            MovePanel(buttonBill);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlSetting1.Hide();
            userControlReservation1.Hide();
            userControlDashboard1.Hide();
            userControlBill1.Show();
        }
    }
}
