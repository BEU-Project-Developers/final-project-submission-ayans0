using HotelManagement.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MovePanel(Control btn)
        {
            panelSliide.Top= btn.Top;
            panelSliide.Height= btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result=MessageBox.Show("Are you want to Log Out?",
                "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            labelUsername.Text = Username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            useControlDashboard1.Show();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            useControlDashboard1.Hide();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlClient1.Hide();
            userControlRoom1.Show();
            userControlReservation1.Hide();
            useControlDashboard1.Hide();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Show();
            useControlDashboard1.Hide();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Hide();
            useControlDashboard1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
