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
    public partial class ReservationControl : System.Windows.Forms.UserControl
    {
        private string RID = "", No;
        public ReservationControl()
        {
            InitializeComponent();
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

        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }

        public void UpdateReservationRoom(string No, string Free)
        {
            string cmdText = "UPDATE Room_Table SET Room_Free = @RoomFree WHERE Room_Number = @RoomNumber";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@RoomFree", SqlDbType.VarChar).Value = Free;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            connection.Close();
        }

        public bool AddReservation(string Type, string No, string CID, string In, string Out)
        {
            string cmdText = "INSERT INTO Reservation_Table VALUES (@Type, @No, @CID, @In, @Out)";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@No", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@CID", SqlDbType.Int).Value = CID;
            sqlCommand.Parameters.Add("@In", SqlDbType.VarChar).Value = In;
            sqlCommand.Parameters.Add("@Out", SqlDbType.VarChar).Value = Out;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Reservation Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Client ID already exist.", "Client ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool UpdateReservation(string RID, string Type, string No, string CID, string In, string Out)
        {
            string cmdText = "UPDATE Reservation_Table SET Reservation_Room_Type = @ReservationRoomType, Reservation_Room_Number = @ReservationRoomNumber, Reservation_Client_ID = @ReservationClientID, Reservation_In = @ReservationIn, Reservation_Out = @ReservationOut WHERE Reservation_ID = @ReservationID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ReservationID", SqlDbType.Int).Value = RID;
            sqlCommand.Parameters.Add("@ReservationRoomType", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@ReservationRoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@ReservationClientID", SqlDbType.Int).Value = CID;
            sqlCommand.Parameters.Add("@ReservationIn", SqlDbType.VarChar).Value = In;
            sqlCommand.Parameters.Add("@ReservationOut", SqlDbType.VarChar).Value = Out;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Reservation Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Client ID already exist.", "Client ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteReservation(string ID)
        {
            string cmdText = "DELETE FROM Reservation_Table WHERE Reservation_ID = @ReservationID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Canceled Successfully!", "Reservation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Canceled Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            connection.Close();
            return true;
        }

        public void RoomTypeAndNo(string query, ComboBox cb)
        {
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            cb.Items.Clear();
            cb.Items.Add("Please select ...");
            cb.SelectedIndex = 0;
            while (sqlDataReader.Read())
            {
                cb.Items.Add(sqlDataReader[0]);
            }
        }
    

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" +
                comboBoxType.SelectedItem.ToString() +
                "'AND Room_Free='Yes' ORDER BY Room_Number", comboBoxNo);
        }

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (comboBoxType.SelectedIndex==0 ||
                comboBoxNo.SelectedIndex == 0 ||
                textBoxClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.", "Require all fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = AddReservation(comboBoxType.SelectedItem.ToString(),
                    comboBoxNo.SelectedItem.ToString(),
                    textBoxClientID.Text.Trim(),
                    dateTimePickerIn.Text, dateTimePickerOut.Text);
                    UpdateReservationRoom(comboBoxNo.SelectedItem.ToString(),"No");
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
        private void tabPageSearchReservation_Enter(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Reservation_Table", dataGridViewReservation);
        }

        private void tabPageSearchReservation_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();   
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            DisplayAndSearch("SELECT * FROM Reservation_Table WHERE Reservation_Client_ID LIKE '%" +
                textBoxSearchClientID.Text + "%'", dataGridViewReservation);
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if(e.RowIndex!=-1)
            {
                DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 ||
                comboBoxNo1.SelectedIndex == 0 ||
                textBoxClientID1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = UpdateReservation(RID, comboBoxType.SelectedItem.ToString(),
                    comboBoxNo.SelectedItem.ToString(),
                    textBoxClientID1.Text.Trim(),
                    dateTimePickerIn1.Text, dateTimePickerOut1.Text);
                    UpdateReservationRoom(No, "Yes");
                    UpdateReservationRoom(comboBoxNo1.SelectedItem.ToString(), "No");
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 ||
                textBoxClientID1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all fields.", "Require all fields",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to cancel this client?",
                        "Reservation cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = DeleteReservation(RID);
                        UpdateReservationRoom(No, "Yes");
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

        private void tabPageUpdateAndCancel_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" +
               comboBoxType1.SelectedItem.ToString() +
               "'AND Room_Free='Yes' ORDER BY Room_Number", comboBoxNo1);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
