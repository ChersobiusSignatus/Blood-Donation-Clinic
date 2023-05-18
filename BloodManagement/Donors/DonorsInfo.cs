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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BloodManagement.Donors
{
    public partial class BloodRequestEdit : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;   
        private void CreatingColumns()
        {
            DataGridInfoDonors.Columns.Add("DonorFullName", "Donor FullName");
            DataGridInfoDonors.Columns.Add("IdentificationNumber", "ITIN");
            DataGridInfoDonors.Columns["IdentificationNumber"].Visible = false;
            DataGridInfoDonors.Columns.Add("Sex", "Sex");
            DataGridInfoDonors.Columns["Sex"].Visible = false;
            DataGridInfoDonors.Columns.Add("DateOfBirth", "Date Of Birth");
            DataGridInfoDonors.Columns["DateOfBirth"].Visible = false;
            DataGridInfoDonors.Columns.Add("Address", "Address");
            DataGridInfoDonors.Columns["Address"].Visible = false;
            DataGridInfoDonors.Columns.Add("MobileNumber", "Mobile Number");
            DataGridInfoDonors.Columns["MobileNumber"].Visible = false;
            DataGridInfoDonors.Columns.Add("Email", "Email");
            DataGridInfoDonors.Columns["Email"].Visible = false;
            DataGridInfoDonors.Columns.Add("BloodType", "Blood Type");
            DataGridInfoDonors.Columns["BloodType"].Visible = false;
            DataGridInfoDonors.Columns.Add("RhFactor", "Rh Factor");
            DataGridInfoDonors.Columns["RhFactor"].Visible = false;
            DataGridInfoDonors.Columns.Add("OverallDonated", "Overall Donated");
            DataGridInfoDonors.Columns["OverallDonated"].Visible = false;
            DataGridInfoDonors.Columns.Add("LastVisit", "Last Visit");
            DataGridInfoDonors.Columns["LastVisit"].Visible = false;
            DataGridInfoDonors.Columns.Add("QuantityDonated", "Quantity Donated");
            DataGridInfoDonors.Columns["QuantityDonated"].Visible = false;
            DataGridInfoDonors.Columns.Add("EmployeeFullName", "Employee FullName");
            DataGridInfoDonors.Columns["EmployeeFullName"].Visible = false;
        }
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 13) {return;}
            string fullName = datarecord.IsDBNull(0) ? "" : datarecord.GetString(0);
            string identificationNumber = datarecord.IsDBNull(1) ? "" : datarecord.GetString(1);
            string sex = datarecord.IsDBNull(2) ? "" : datarecord.GetString(2);
            DateTime dateOfBirth = datarecord.IsDBNull(3) ? DateTime.MinValue : datarecord.GetDateTime(3);
            string address = datarecord.IsDBNull(4) ? "" : datarecord.GetString(4);
            string mobileNumber = datarecord.IsDBNull(5) ? "" : datarecord.GetString(5);
            string email = datarecord.IsDBNull(6) ? "" : datarecord.GetString(6);
            string bloodtp = datarecord.IsDBNull(7) ? "" : datarecord.GetString(7);
            string rgfac = datarecord.IsDBNull(8) ? "" : datarecord.GetString(8);
            Int32 ovdono = datarecord.IsDBNull(9) ? 0 : datarecord.GetInt32(9);
            DateTime lastvisit = datarecord.IsDBNull(10) ? DateTime.MinValue : datarecord.GetDateTime(10);
            Int32 quandono = datarecord.IsDBNull(11) ? 0 : datarecord.GetInt32(11);
            string empfull = datarecord.IsDBNull(12) ? "" : datarecord.GetString(12);
            string lastvisitString = lastvisit == DateTime.MinValue ? "" : lastvisit.ToString("yyyy-MM-dd");
            string dateOfBirthString = dateOfBirth == DateTime.MinValue ? "" : dateOfBirth.ToString("yyyy-MM-dd");
            datagw.Rows.Add(fullName, identificationNumber, sex, dateOfBirthString, address, mobileNumber, email, bloodtp, rgfac, ovdono, lastvisitString, quandono, empfull);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from vw_DonorDetails order by DonorFullName";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {ReadRow(datagw, reader);}
            reader.Close();
        }
        public BloodRequestEdit() {InitializeComponent();}
        private void Search(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string searchstring = "SELECT Donors.*, DonorsHistory.LastVisit, DonorsHistory.QuantityDonated, DonorsHistory.EmployeeFullName " +
                        "FROM Donors " +
                        "JOIN DonorsHistory ON Donors.DonorFullName = DonorsHistory.DonorFullName " +
                        "WHERE Donors.DonorFullName LIKE @fullName";
            SqlCommand command = new SqlCommand();
            command.Connection = dataBase.getConnection();
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                command.CommandText = searchstring;
                command.Parameters.AddWithValue("@fullName", $"%{textBox1.Text}%");
            }
            else if (comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1)
            {
                command.CommandText = "SELECT * FROM dbo.GetDonorsByRhFactorBloodType(@bloodType, @rhFactor)";
                command.Parameters.AddWithValue("@bloodType", comboBox2.SelectedItem.ToString());
                command.Parameters.AddWithValue("@rhFactor", comboBox3.SelectedItem.ToString());
            }
            else if (comboBox2.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(comboBox2.SelectedItem.ToString()))
                {
                    command.CommandText = "SELECT * FROM dbo.GetDonorsByBloodType(@bloodType)";
                    command.Parameters.AddWithValue("@bloodType", comboBox2.SelectedItem.ToString());
                }
            }
            else if (comboBox3.SelectedIndex > -1)
            {
                if (!string.IsNullOrEmpty(comboBox3.SelectedItem.ToString()))
                {
                    command.CommandText = "SELECT * FROM dbo.GetDonorsByRhFactor(@rhFactor)";
                    command.Parameters.AddWithValue("@rhFactor", comboBox3.SelectedItem.ToString());
                }
            }                                   
            else
            {
                command.CommandText = "SELECT Donors.*, DonorsHistory.LastVisit, DonorsHistory.QuantityDonated, DonorsHistory.EmployeeFullName " +
                                        "FROM Donors " +
                                        "JOIN DonorsHistory ON Donors.DonorFullName = DonorsHistory.DonorFullName";
            }
            dataBase.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {ReadRow(datagw, read);}
            read.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e) {this.Hide();}
        private void DonorsInfo_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridInfoDonors);
            string querystring1 = $"select * from vw_DonorDetails order by DonorFullName";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);            
        }
        private void DataGridInfoDonors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridInfoDonors.Rows[selectedRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox8.Text = row.Cells[2].Value.ToString();
                textBox9.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                textBox5.Text = row.Cells[5].Value.ToString();
                textBox6.Text = row.Cells[6].Value.ToString();
                textBox10.Text = row.Cells[7].Value.ToString();
                textBox11.Text = row.Cells[8].Value.ToString();
                textBox7.Text = row.Cells[9].Value.ToString();
                textBox12.Text = row.Cells[12].Value.ToString();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {Search(DataGridInfoDonors);}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridInfoDonors);}
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridInfoDonors);}
        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var fullName = textBox2.Text;        
            var address = textBox4.Text;
            var mobileNumber = textBox5.Text;
            var email = textBox6.Text;    
            var command = new SqlCommand("UpdateDonor", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DonorFullName", fullName);  
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MobileNumber", mobileNumber);
            command.Parameters.AddWithValue("@Email", email);              
            command.ExecuteNonQuery();
            MessageBox.Show("Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NewDataGrid(DataGridInfoDonors);                
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DonorsNewDonationForm dononewdon = new DonorsNewDonationForm();
            dononewdon.ShowDialog();
        }
    }
}
