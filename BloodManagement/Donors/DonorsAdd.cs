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
namespace BloodManagement.Donors
{
    public partial class DonorsAdd : Form
    {
        DataBase dataBase = new DataBase();
        public DonorsAdd() {InitializeComponent();}
        private void pictureBox1_Click(object sender, EventArgs e) {this.Hide();}
        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var donname = textBox2.Text;
            var itin = textBox3.Text;
            var sex = comboBox1.SelectedItem;
            var dateofbirth = dateTimePicker1.Value;
            var bltype = comboBox2.SelectedItem;
            var address = textBox4.Text;
            var mobile = textBox5.Text;
            var email = textBox6.Text;
            var overdono = textBox7.Text;
            var rh = comboBox3.SelectedItem;
            if (DateTime.Today.Subtract(dateofbirth).TotalDays < (18 * 365))
            {
                MessageBox.Show("Donor must be at least 18 years old.", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                SqlCommand command = new SqlCommand("AddNewDonor", dataBase.getConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@DonorFullName", donname);
                command.Parameters.AddWithValue("@IdentificationNumber", itin);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@DateOfBirth", dateofbirth);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@MobileNumber", mobile);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@BloodType", bltype);
                command.Parameters.AddWithValue("@RhFactor", rh);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DonorsAdd_Load(object sender, EventArgs e) {}
    }
}
