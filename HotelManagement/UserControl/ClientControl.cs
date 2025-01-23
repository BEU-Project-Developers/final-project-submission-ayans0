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
    public partial class ClientControl : System.Windows.Forms.UserControl
    {
       
        private string ID = "";
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
            tabControlClient.SelectedTab = tabPageAddClient; //add client hissesinde qalmasi ucun
        }

        private void Clear1()
        {
            textBoxLastName1.Clear();
            textBoxFirstName1.Clear();
            textBoxPhoneNO1.Clear();
            textBoxAddress1.Clear();
            ID = "";
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

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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


        public bool AddClient(string FirstName, string LastName, string Phone, string Address)
        {
            string cmdText = "INSERT INTO Client_Table VALUES (@Client_FirstName, @Client_LastName, @Client_Phone, @Client_Address)"; //formda doldurulanlar
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Client_FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@Client_LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Client_Phone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@Client_Address", SqlDbType.VarChar).Value = Address;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool UpdateClient(string ID, string FirstName, string LastName, string Phone, string Address)
        {
            string cmdText = "UPDATE Client_Table SET Client_FirstName = @ClientFirstName, Client_LastName = @ClientLastName, Client_Phone = @ClientPhone, Client_Address = @ClientAddress WHERE Client_ID = @ClientID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@ClientFirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@ClientLastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@ClientPhone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = Address;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteClient(string ID)
        {
            string cmdText = "DELETE FROM Client_Table WHERE Client_ID = @ClientID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Client Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            connection.Close();
            return true;
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxFirstName.Text.Trim() == string.Empty ||
                textBoxLastName.Text.Trim() == string.Empty ||
                textBoxPhoneNo.Text.Trim() == string.Empty ||
                textBoxAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check=AddClient(textBoxFirstName.Text.Trim(),
                    textBoxLastName.Text.Trim(),
                    textBoxPhoneNo.Text.Trim(),
                    textBoxAddress.Text.Trim());
                if (check)
                {
                    Clear();
                }
            }
        }

        public void DisplayAndSearch(string query, DataGridView dgv)
        {
            SqlConnection connection = GetConnection();
            SqlCommand selectCommand = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Client_Table", dataGridViewClient);
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            textBoxPhoneNo.Clear();
        }

        private void textBoxSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Client_Table WHERE Client_Phone LIKE '%" +
                textBoxSearchPhoneNo.Text + "%'", dataGridViewClient);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == string.Empty ||
                   textBoxLastName1.Text.Trim() == string.Empty ||
                   textBoxPhoneNO1.Text.Trim() == string.Empty ||
                   textBoxAddress1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = UpdateClient(ID, textBoxFirstName1.Text.Trim(),
                        textBoxLastName1.Text.Trim(),
                        textBoxPhoneNO1.Text.Trim(),
                        textBoxAddress1.Text.Trim());
                    if (check)
                    {
                        Clear1();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table.",
                    "Seelection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxFirstName1.Text.Trim() == string.Empty ||
                   textBoxLastName1.Text.Trim() == string.Empty ||
                   textBoxPhoneNO1.Text.Trim() == string.Empty ||
                   textBoxAddress1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this client?",
                        "Client delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = DeleteClient(ID);
                        if (check)
                        {
                            Clear1();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table.",
                    "Seelection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tabPageUpdateAndDelete_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1)
            {
                DataGridViewRow row=dataGridViewClient.Rows[e.RowIndex];
                ID=row.Cells[0].Value.ToString();
                textBoxFirstName1.Text = row.Cells[1].Value.ToString();
                textBoxLastName1.Text = row.Cells[2].Value.ToString();
                textBoxPhoneNO1.Text = row.Cells[3].Value.ToString();
                textBoxAddress1.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
