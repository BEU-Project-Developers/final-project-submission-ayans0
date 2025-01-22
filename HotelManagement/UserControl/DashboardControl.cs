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

namespace HotelManagement.UserControl
{
    public partial class DashboardControl : System.Windows.Forms.UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Hotel_Management_System; Integrated Security=true";
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

        public int Count(string query) // query=>sql sorgusu
        {
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(query, connection); //for using sql query
            return (int)sqlCommand.ExecuteScalar();
        }


        public void Client() { 
            labelClientCount.Text=Count("SELECT COUNT(*) FROM Client_Table").ToString();
        }

        public void Room()
        {
            labelRoomCount.Text = Count("SELECT COUNT(*) FROM Room_Table").ToString();
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            Client();
            Room();
        }

        private void labelClient_Click(object sender, EventArgs e)
        {

        }
    }
}
