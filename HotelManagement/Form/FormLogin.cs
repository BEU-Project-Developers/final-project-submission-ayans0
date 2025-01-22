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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HotelManagement
{
    public partial class FormLogin : Form
    {
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool check = false;

        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source = .\\SQLEXPRESS;\r\n                           Initial Catalog = Hotel_Management_System;\r\n                           Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "SQL connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return sqlConnection;
        }


        public bool IsValidNamePass(string Username, string Password)
        {
            try
            {
                string cmdText = "SELECT User_Name, User_Password FROM User_Table WHERE User_Name = '" + Username + "' AND User_Password = '" + Password + "'";
                SqlConnection connection = GetConnection();
                SqlCommand selectCommand = new SqlCommand(cmdText, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                connection.Close();
                if (dataTable.Rows.Count > 0)
                {
                    check = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return check;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool check=IsValidNamePass(textBoxUsername.Text.Trim(),textBoxPassword.Text.Trim());
            if(textBoxUsername.Text.Trim()==string.Empty || textBoxPassword.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Please fill out all field.", "Required field",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               if(check)
                {
                    FormDashboard fd= new FormDashboard();
                    fd.Username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    fd.Show();
                }
               else
                {
                    MessageBox.Show("Invalid Username or Password.", "Username or Password", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
           
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
