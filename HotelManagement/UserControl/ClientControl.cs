using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.UserControl
{
    public partial class ClientControl : System.Windows.Forms.UserControl
    {
        public ClientControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxPhoneNo.Clear();
            textBoxAddress.Clear();
        }

        public void Clear1()
        {
            textBoxLastName1.Clear();
            textBoxFirstName1.Clear();
            textBoxPhoneNO1.Clear();
            textBoxAddress1.Clear();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }
    }
}
