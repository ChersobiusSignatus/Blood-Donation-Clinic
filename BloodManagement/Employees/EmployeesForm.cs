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
using BloodManagement.Employees;
namespace BloodManagement
{
    public partial class EmployeesForm : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public EmployeesForm()
        {
            InitializeComponent();
        }
        private void CreatingColumns()
        {
            DataGridViewEmployees.Columns.Add("EmployeeFullName", "Employee FullName");
            DataGridViewEmployees.Columns.Add("IdentificationNumber", "ITIN");
            DataGridViewEmployees.Columns["IdentificationNumber"].Visible = false;
            DataGridViewEmployees.Columns.Add("Sex", "Sex");
            DataGridViewEmployees.Columns["Sex"].Visible = false;
            DataGridViewEmployees.Columns.Add("DateOfBirth", "Date Of Birth");
            DataGridViewEmployees.Columns["DateOfBirth"].Visible = false;
            DataGridViewEmployees.Columns.Add("Address", "Address");
            DataGridViewEmployees.Columns["Address"].Visible = false;
            DataGridViewEmployees.Columns.Add("MobileNumber", "Mobile Number");
            DataGridViewEmployees.Columns["MobileNumber"].Visible = false;
            DataGridViewEmployees.Columns.Add("Email", "Email");
            DataGridViewEmployees.Columns["Email"].Visible = false;
            DataGridViewEmployees.Columns.Add("PositionName", "Position Name");
            DataGridViewEmployees.Columns["PositionName"].Visible = false;
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
            datagw.Rows.Add(fullName, identificationNumber, sex, dateOfBirth, address, mobileNumber, email, positionName);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from Employees order by PositionName";
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
            string searchstring = "SELECT DISTINCT e.EmployeeFullName, e.IdentificationNumber, e.Sex, e.DateOfBirth, e.Address, e.MobileNumber, e.Email, p.PositionName " +
                                  "FROM Employees e " +
                                  "INNER JOIN Positions p ON e.PositionName = p.PositionName ";                        
            if (checkBox1.Checked)
            {
                searchstring += "INNER JOIN DonorsHistory dh ON e.EmployeeFullName = dh.EmployeeFullName ";
            }
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                searchstring += $"WHERE e.EmployeeFullName like '%{textBox1.Text}%'";
            }
            if (comboBoxDepartment.SelectedIndex > -1)
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
            if (comboBoxPosition.SelectedIndex > -1)
            {
                if (searchstring.Contains("WHERE"))
                {
                    searchstring += $"AND p.PositionName = '{comboBoxPosition.SelectedItem}'";
                }
                else
                {
                    searchstring += $"WHERE p.PositionName = '{comboBoxPosition.SelectedItem}'";
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
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridViewEmployees);
            string querystring1 = $"select * from Employees order by PositionName";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);            
        }
        private void DataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(DataGridViewEmployees);
        }
        private void button3_Click(object sender, EventArgs e)
        {            
            SqlCommand command = new SqlCommand("DeleteEmployee", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmployeeFullName", DataGridViewEmployees.Rows[selectedRow].Cells["EmployeeFullName"].Value.ToString());
            command.ExecuteNonQuery();                        
            NewDataGrid(DataGridViewEmployees);
            MessageBox.Show("Data Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }                    
        private void button4_Click(object sender, EventArgs e)
        {
            EmployeesInfo empview = new EmployeesInfo();
            empview.ShowDialog();
        }
        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(DataGridViewEmployees);
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(DataGridViewEmployees);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Search(DataGridViewEmployees);
        }
        private void label3_Click(object sender, EventArgs e)
        {
            EmployeesForm empform = new EmployeesForm();
            this.Hide();
            empform.ShowDialog();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            DonorsForm donorsform = new DonorsForm();
            this.Hide();
            donorsform.ShowDialog();
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
            EmployeesAdd empadd = new EmployeesAdd();
            empadd.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
