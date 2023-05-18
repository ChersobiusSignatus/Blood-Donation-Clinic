using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
namespace BloodManagement.Donors
{
    public partial class DonorsNewDonationForm : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        private void CreatingColumns()
        {
            DataGridHistoryDonors.Columns.Add("DonorFullName", "Donor FullName");
            DataGridHistoryDonors.Columns.Add("LastVisit", "Last Visit");            
            DataGridHistoryDonors.Columns.Add("QuantityDonated", "Quantity Donated");            
            DataGridHistoryDonors.Columns.Add("EmployeeFullName", "Employee FullName");                            
        }
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 4) {return;}
            string fullName = datarecord.IsDBNull(0) ? "" : datarecord.GetString(0);
            DateTime lastvisit = datarecord.IsDBNull(1) ? DateTime.MinValue : datarecord.GetDateTime(1);
            Int32 quandono = datarecord.IsDBNull(2) ? 0 : datarecord.GetInt32(2);
            string empfull = datarecord.IsDBNull(3) ? "" : datarecord.GetString(3);
            string lastvisitString = lastvisit == DateTime.MinValue ? "" : lastvisit.ToString("yyyy-MM-dd");
            datagw.Rows.Add(fullName, lastvisitString, quandono, empfull);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from DonorsHistory order by DonorFullName";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {ReadRow(datagw, reader);}
            reader.Close();
        }
        private void Search(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string searchstring = $"SELECT * FROM DonorsHistory WHERE DonorFullName LIKE '%" + textBox2.Text + "%'";        
            SqlCommand command = new SqlCommand(searchstring, dataBase.getConnection());                         
            dataBase.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {ReadRow(datagw, read);}
            read.Close();
        }
        public DonorsNewDonationForm() {InitializeComponent();}
        private void pictureBox1_Click(object sender, EventArgs e) {this.Hide();}
        private void DonorsNewDonationForm_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridHistoryDonors);
            string querystring1 = $"select * from DonorsHistory order by DonorFullName";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);           
        }
        private void textBox2_TextChanged(object sender, EventArgs e) {Search(DataGridHistoryDonors);}
        private void DataGridHistoryDonors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridHistoryDonors.Rows[selectedRow];
                textBox2.Text = row.Cells[0].Value.ToString();               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var donorfull = textBox2.Text;
            var quandono = int.Parse(textBox8.Text);
            var visit = dateTimePicker1.Value;
            var physi = comboBox1.SelectedItem.ToString();
            SqlCommand checkCommand = new SqlCommand("SELECT TOP 1 LastVisit FROM DonorsHistory WHERE DonorFullName = @DonorFullName ORDER BY LastVisit DESC", dataBase.getConnection());
            checkCommand.Parameters.AddWithValue("@DonorFullName", donorfull);
            SqlDataReader reader = checkCommand.ExecuteReader();
            if (reader.Read())
            {
                DateTime lastVisit = reader.GetDateTime(0);
                if (visit.Subtract(lastVisit).Days < 30)
                {
                    reader.Close();
                    MessageBox.Show("Error: It hasn't been 30 days since the last visit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            reader.Close();
            var command = new SqlCommand("UpdateDonorsHistory", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DonorFullName", donorfull);
            command.Parameters.AddWithValue("@QuantityDonated", quandono);
            command.Parameters.AddWithValue("@EmployeeFullName", physi);
            command.Parameters.AddWithValue("@LastVisit", visit);
            command.ExecuteNonQuery();
            MessageBox.Show("Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NewDataGrid(DataGridHistoryDonors);
        }
    }
}
