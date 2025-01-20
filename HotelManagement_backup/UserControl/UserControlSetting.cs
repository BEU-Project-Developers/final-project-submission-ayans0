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
    public partial class UserControlSetting : System.Windows.Forms.UserControl
    {
        private string ID = "";
        public UserControlSetting()=> InitializeComponent();
        

        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        private void Clear1()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            ID = "";
        }

        private void buttonAdd_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridViewUser_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void UpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}
