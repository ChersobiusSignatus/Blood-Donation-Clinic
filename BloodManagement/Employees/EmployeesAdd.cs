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
using BloodManagement.Employees;
namespace BloodManagement.Employees
{
    public partial class EmployeesAdd : Form
    {
        DataBase dataBase = new DataBase();
        public EmployeesAdd()
        {
            InitializeComponent();
        }
        private void EmployeesAdd_Load(object sender, EventArgs e) {}
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var empname = textBox2.Text;
            var itin = textBox3.Text;
            var sex = comboBox1.SelectedItem;
            var dateofbirth = dateTimePicker1.Value;
            var address = textBox4.Text;
            var mobile = textBox5.Text;
            var email = textBox6.Text;
            var pos = comboBox2.SelectedItem;
            var command = new SqlCommand("AddNewEmployee", dataBase.getConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@EmployeeFullName", empname);
            command.Parameters.AddWithValue("@IdentificationNumber", itin);
            command.Parameters.AddWithValue("@Sex", sex);
            command.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@MobileNumber", mobile);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@PositionName", pos);
            try 
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Data Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
