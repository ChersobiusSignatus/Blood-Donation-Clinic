using BloodManagement.Donors;
using BloodManagement.Employees;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace BloodManagement
{
    public partial class DonorsForm : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public DonorsForm() {InitializeComponent();}
        private void CreatingColumns() {DataGridViewDonors.Columns.Add("DonorFullName", "Donor FullName");}
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 1) {return;}
            string fullName = datarecord.IsDBNull(0) ? "" : datarecord.GetString(0);
            datagw.Rows.Add(fullName);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from Donors order by DonorFullName";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {ReadRow(datagw, reader);}
            reader.Close();
        }
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
            else if (dateTimePicker2.Value <= dateTimePicker3.Value)
            {
                command.CommandText = "SELECT Donors.*, DonorsHistory.LastVisit, DonorsHistory.QuantityDonated, DonorsHistory.EmployeeFullName " +
                                        "FROM Donors " +
                                        "JOIN DonorsHistory ON Donors.DonorFullName = DonorsHistory.DonorFullName " +
                                        "WHERE DonorsHistory.LastVisit BETWEEN @startDate AND @endDate";
                command.Parameters.AddWithValue("@startDate", dateTimePicker2.Value);
                command.Parameters.AddWithValue("@endDate", dateTimePicker3.Value);
            }
            else if (!string.IsNullOrWhiteSpace(textBox8.Text))
            {
                command.CommandText = "SELECT * FROM dbo.GetDonorsWithOverallDonations(@overallDonated)";
                command.Parameters.AddWithValue("@overallDonated", textBox8.Text);
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
        private void label4_Click(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e)
        {
            EmployeesForm empform = new EmployeesForm();
            this.Hide();
            empform.ShowDialog();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            BloodForm bloodform = new BloodForm();
            this.Hide();
            bloodform.ShowDialog();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            BloodRequestForm bloodreqform = new BloodRequestForm();
            this.Hide();
            bloodreqform.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DonorsAdd donoadd = new DonorsAdd();
            donoadd.Show();
        }
        private void DonorsForm_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridViewDonors);
            string querystring1 = $"select * from Donors order by DonorFullName";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);            
        }
        private void textBox1_TextChanged(object sender, EventArgs e) {Search(DataGridViewDonors);}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewDonors);}
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewDonors);}
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) {Search(DataGridViewDonors);}
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) {Search(DataGridViewDonors);}
        private void textBox8_TextChanged(object sender, EventArgs e) {Search(DataGridViewDonors);}
        private void button4_Click(object sender, EventArgs e)
        {
            BloodRequestEdit doninf = new BloodRequestEdit();
            doninf.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {            
            SqlCommand command = new SqlCommand("DeleteDonor", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DonorFullName", DataGridViewDonors.Rows[selectedRow].Cells["DonorFullName"].Value.ToString());
            command.ExecuteNonQuery();
            
            NewDataGrid(DataGridViewDonors);
            MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void pictureBox1_Click(object sender, EventArgs e) {Application.Exit();}
    }
}

