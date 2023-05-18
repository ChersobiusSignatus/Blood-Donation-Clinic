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
namespace BloodManagement.BloodRequest
{
    public partial class BloodRequestAdd : Form
    {
        DataBase dataBase = new DataBase();
        public BloodRequestAdd() {InitializeComponent();}
        private void pictureBox1_Click(object sender, EventArgs e) {this.Hide();}
        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var hospitalname = comboBox3.Text;
            var bloodtype = comboBox1.Text;
            var rhfactor = comboBox4.SelectedItem;
            var numberofunits = int.Parse(textBox4.Text);
            var urgency = comboBox5.SelectedItem;
            var requestdate = dateTimePicker1.Value;
            var deliverydate = DateTime.Now; 
            try
            {
                SqlCommand command = new SqlCommand("AddNewBloodRequest", dataBase.getConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HospitalName", hospitalname);
                command.Parameters.AddWithValue("@BloodType", bloodtype);
                command.Parameters.AddWithValue("@RhFactor", rhfactor);
                command.Parameters.AddWithValue("@NumberOfUnits", numberofunits);
                command.Parameters.AddWithValue("@RequestUrgency", urgency);
                command.Parameters.AddWithValue("@RequestDate", requestdate);
                command.Parameters.Add("@DeliveryDate", SqlDbType.Date).Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                var deliveryDate = (DateTime)command.Parameters["@DeliveryDate"].Value;
                textBox1.Text = deliveryDate.ToString("yyyy-MM-dd");
                MessageBox.Show("Data Added", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void BloodRequestAdd_Load(object sender, EventArgs e) {}
    }
}
