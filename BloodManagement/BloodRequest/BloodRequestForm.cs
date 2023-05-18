using BloodManagement.BloodRequest;
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
namespace BloodManagement
{
    public partial class BloodRequestForm : Form
    {
        DataBase dataBase = new DataBase(); 
        private void CreatingColumns()
        {
            DataGridViewRequest.Columns.Add("RequestID", "ID");
            DataGridViewRequest.Columns.Add("HospitalName", "Hospital");
            DataGridViewRequest.Columns.Add("BloodType", "Blood Type");
            DataGridViewRequest.Columns.Add("RhFactor", "RhFactor");
            DataGridViewRequest.Columns.Add("NumberOfUnits", "Units");
            DataGridViewRequest.Columns.Add("RequestUrgency", "Urgency");
            DataGridViewRequest.Columns.Add("RequestDate", "Request Date");
            DataGridViewRequest.Columns.Add("DeliveryDate", "Delivery Date");
            DataGridViewRequest.Columns.Add("Status", "Status");
        }
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 9) {return;}
            Int32 id = datarecord.IsDBNull(0) ? 0 : datarecord.GetInt32(0);
            string hospital = datarecord.IsDBNull(1) ? "" : datarecord.GetString(1);
            string type = datarecord.IsDBNull(2) ? "" : datarecord.GetString(2);
            string factor = datarecord.IsDBNull(3) ? "" : datarecord.GetString(3);
            Int32 units = datarecord.IsDBNull(4) ? 0 : datarecord.GetInt32(4);
            string urgency = datarecord.IsDBNull(5) ? "" : datarecord.GetString(5);
            DateTime request = datarecord.IsDBNull(6) ? DateTime.MinValue : datarecord.GetDateTime(6);
            DateTime delivery = datarecord.IsDBNull(7) ? DateTime.MinValue : datarecord.GetDateTime(7);
            string status = datarecord.IsDBNull(8) ? "" : datarecord.GetString(8);
            string requestString = request == DateTime.MinValue ? "" : request.ToString("yyyy-MM-dd");
            string deliveryString = delivery == DateTime.MinValue ? "" : delivery.ToString("yyyy-MM-dd");
            datagw.Rows.Add(id, hospital, type, factor, units, urgency, requestString, deliveryString, status);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from BloodRequest order by RequestID";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {ReadRow(datagw, reader);}
            reader.Close();
        }
        public BloodRequestForm() {InitializeComponent();}
        private void Search(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string searchstring = "";
            SqlCommand command = new SqlCommand();
            command.Connection = dataBase.getConnection();
            if (!string.IsNullOrWhiteSpace(comboBoxHospitalName.Text))
            {
                searchstring = "GetBloodRequestsByHospital";
                command.CommandText = searchstring;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HospitalName", comboBoxHospitalName.Text);
            }                          
            else if (comboBoxBloodType.SelectedIndex > -1 && comboBoxRhFactor.SelectedIndex > -1)
            {
                searchstring = "GetBloodRequestsByBloodTypeRhFactor";
                command.CommandText = searchstring;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bloodType", comboBoxBloodType.SelectedItem.ToString());
                command.Parameters.AddWithValue("@rhFactor", comboBoxRhFactor.SelectedItem.ToString());
            }                     
            else if (comboBoxBloodType.SelectedIndex > -1)
            {
                searchstring = "GetBloodRequestsByBloodType";
                command.CommandText = searchstring;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bloodType", comboBoxBloodType.SelectedItem.ToString());
            }
            else if (comboBoxRhFactor.SelectedIndex > -1)
            {
                searchstring = "GetBloodRequestsByRhFactor";
                command.CommandText = searchstring;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@rhFactor", comboBoxRhFactor.SelectedItem.ToString());
            }
            else if (comboBoxUrgency.SelectedIndex > -1)
            {
                searchstring = "GetBloodRequestsByUrgency";
                command.CommandText = searchstring;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@urgency", comboBoxUrgency.SelectedItem.ToString());
            }
            else if (dateTimePickerRequestDate.Value != DateTime.MinValue && dateTimePickerDeliveryDate.Value != DateTime.MinValue)
            {
                searchstring = "GetBloodRequestsByDate";
                command.CommandText = searchstring;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@requestdate", dateTimePickerRequestDate.Value);
                command.Parameters.AddWithValue("@deliverydate", dateTimePickerDeliveryDate.Value);
            }
            else
            {
                searchstring = "SELECT * FROM BloodRequest";
                command.CommandText = searchstring;
                command.CommandType = CommandType.Text;
            }
            dataBase.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {ReadRow(datagw, read);}
            read.Close();
        }
        private void BloodRequest_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridViewRequest);
            string querystring1 = $"select * from BloodRequest order by RequestID";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);
        }
        private void label7_Click(object sender, EventArgs e) {}            
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
        private void button1_Click(object sender, EventArgs e)
        {
            BloodRequestAdd blreqadd = new BloodRequestAdd();
            blreqadd.Show();
        }
        private void comboBoxHospitalName_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewRequest);}
        private void comboBoxBloodType_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewRequest);}
        private void comboBoxRhFactor_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewRequest);}
        private void comboBoxUrgency_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewRequest);}
        private void dateTimePickerRequestDate_ValueChanged(object sender, EventArgs e) {Search(DataGridViewRequest);}
        private void dateTimePickerDeliveryDate_ValueChanged(object sender, EventArgs e) {Search(DataGridViewRequest);}
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.openConnection();
                if (!int.TryParse(textBox1.Text, out int id))
                {
                    MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var statusreq = comboBoxStatus.SelectedItem;
                var command = new SqlCommand("UpdateBloodRequestStatus", dataBase.getConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@status", statusreq);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NewDataGrid(DataGridViewRequest);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            BloodRequestInfoo bldreqinfo = new BloodRequestInfoo();
            bldreqinfo.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e) {Application.Exit();}
    }
}
