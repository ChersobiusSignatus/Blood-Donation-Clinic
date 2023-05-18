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
namespace BloodManagement.Employees
{
    public partial class EmployeesInfo : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        private void CreatingColumns()
        {
            dataGridViewEmployeeView.Columns.Add("EmployeeFullName", "Employee FullName");
            dataGridViewEmployeeView.Columns.Add("IdentificationNumber", "ITIN");
            dataGridViewEmployeeView.Columns["IdentificationNumber"].Visible = false;
            dataGridViewEmployeeView.Columns.Add("Sex", "Sex");
            dataGridViewEmployeeView.Columns["Sex"].Visible = false;
            dataGridViewEmployeeView.Columns.Add("DateOfBirth", "Date Of Birth");
            dataGridViewEmployeeView.Columns["DateOfBirth"].Visible = false;
            dataGridViewEmployeeView.Columns.Add("Address", "Address");
            dataGridViewEmployeeView.Columns["Address"].Visible = false;
            dataGridViewEmployeeView.Columns.Add("MobileNumber", "Mobile Number");
            dataGridViewEmployeeView.Columns["MobileNumber"].Visible = false;
            dataGridViewEmployeeView.Columns.Add("Email", "Email");
            dataGridViewEmployeeView.Columns["Email"].Visible = false;
            dataGridViewEmployeeView.Columns.Add("PositionName", "Position Name");
            dataGridViewEmployeeView.Columns["PositionName"].Visible = false;
        }
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 8) 
            {
                return;
            }
            string fullName = datarecord.IsDBNull(0) ? "" : datarecord.GetString(0);
            string identificationNumber = datarecord.IsDBNull(1) ? "" : datarecord.GetString(1);
            string sex = datarecord.IsDBNull(2) ? "" : datarecord.GetString(2);
            DateTime dateOfBirth = datarecord.IsDBNull(3) ? DateTime.MinValue : datarecord.GetDateTime(3);
            string address = datarecord.IsDBNull(4) ? "" : datarecord.GetString(4);
            string mobileNumber = datarecord.IsDBNull(5) ? "" : datarecord.GetString(5);
            string email = datarecord.IsDBNull(6) ? "" : datarecord.GetString(6);
            string positionName = datarecord.IsDBNull(7) ? "" : datarecord.GetString(7);
            string dateOfBirthString = dateOfBirth == DateTime.MinValue ? "" : dateOfBirth.ToString("yyyy-MM-dd");
            datagw.Rows.Add(fullName, identificationNumber, sex, dateOfBirthString, address, mobileNumber, email, positionName);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from EmployeeInformation";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadRow(datagw, reader);
            }
            reader.Close();
        }
        private void Search(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string searchstring = "SELECT e.EmployeeFullName, e.IdentificationNumber, e.Sex, e.DateOfBirth, e.Address, e.MobileNumber, e.Email, p.PositionName " +
                                  "FROM Employees e " +
                                  "INNER JOIN Positions p ON e.PositionName = p.PositionName ";
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                searchstring += $"WHERE e.EmployeeFullName like '%{textBox3.Text}%' ";
            }
            if (comboBoxDepartment.SelectedIndex != -1)
            {
                if (searchstring.Contains("WHERE"))
                {
                    searchstring += $"AND p.DepartmentName = '{comboBoxDepartment.SelectedItem}' ";
                }
                else
                {
                    searchstring += $"WHERE p.DepartmentName = '{comboBoxDepartment.SelectedItem}' ";
                }
            }
            if (comboBoxPosition.SelectedIndex != -1)
            {
                if (searchstring.Contains("WHERE"))
                {
                    searchstring += $"AND p.PositionName = '{comboBoxPosition.SelectedItem}' ";
                }
                else
                {
                    searchstring += $"WHERE p.PositionName = '{comboBoxPosition.SelectedItem}' ";
                }
            }
            SqlCommand command = new SqlCommand(searchstring, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ReadRow(datagw, read);
            }
            read.Close();
        }
        public EmployeesInfo()
        {
            InitializeComponent();
        }
        private void EmployeesView_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(dataGridViewEmployeeView);
            string querystring1 = $"select * from EmployeeInformation";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);            
        }
        private void dataGridViewEmployeeView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployeeView.Rows[selectedRow];
                textBoxSearch.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox6.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();
                textBox8.Text = row.Cells[6].Value.ToString();
                textBox7.Text = row.Cells[7].Value.ToString();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewEmployeeView);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var empname = textBoxSearch.Text;            
            var address = textBox5.Text;
            var mobile = textBox4.Text;
            var email = textBox8.Text;            
            var command = new SqlCommand("UpdateEmployee", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmployeeFullName", empname);            
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MobileNumber", mobile);
            command.Parameters.AddWithValue("@Email", email);          
            command.ExecuteNonQuery();
            MessageBox.Show("Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NewDataGrid(dataGridViewEmployeeView);          
        }
        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(dataGridViewEmployeeView);
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(dataGridViewEmployeeView);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
