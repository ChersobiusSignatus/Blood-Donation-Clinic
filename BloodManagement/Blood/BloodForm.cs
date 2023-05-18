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
namespace BloodManagement
{
    public partial class BloodForm : Form
    {
        DataBase dataBase = new DataBase(); 
        private void CreatingColumns()
        {
            DataGridViewBlood.Columns.Add("BloodType", "Blood Type");
            DataGridViewBlood.Columns.Add("RhFactor", "RhFactor");
            DataGridViewBlood.Columns.Add("NumberOfUnits", "Number Of Units");          
        }
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 3) {return;}
            string bldtype = datarecord.IsDBNull(0) ? "" : datarecord.GetString(0);
            string rhfac = datarecord.IsDBNull(1) ? "" : datarecord.GetString(1);            
            Int32 units = datarecord.IsDBNull(2) ? 0 : datarecord.GetInt32(2);
            datagw.Rows.Add(bldtype, rhfac, units);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from Blood order by BloodType";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {ReadRow(datagw, reader);}
            reader.Close();
        }
        private void Search(DataGridView datagw) 
        {
            string bloodType = comboBox1.Text;
            string rhFactor = comboBox2.Text;
            string queryString = "SELECT * FROM Blood WHERE ";
            if (!string.IsNullOrEmpty(bloodType))
            {
                queryString += $"BloodType = '{bloodType}' ";
            }
            if (!string.IsNullOrEmpty(rhFactor))
            {
                if (!string.IsNullOrEmpty(bloodType))
                {
                    queryString += "AND ";
                }
                queryString += $"RhFactor = '{rhFactor}' ";
            }
            if (string.IsNullOrEmpty(bloodType) && string.IsNullOrEmpty(rhFactor))
            {
                NewDataGrid(DataGridViewBlood);
                return;
            }
            queryString += "ORDER BY BloodType";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            DataGridViewBlood.Rows.Clear();
            while (reader.Read()) {ReadRow(DataGridViewBlood, reader);}
            reader.Close();
        }
        public BloodForm() {InitializeComponent();}     
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
        private void label6_Click(object sender, EventArgs e) {}
        private void label7_Click(object sender, EventArgs e)
        {
            BloodRequestForm bloodreqform = new BloodRequestForm();
            this.Hide();
            bloodreqform.ShowDialog();
        }
        private void BloodForm_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridViewBlood);
            string querystring1 = $"select * from Blood order by BloodType";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewBlood);}
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {Search(DataGridViewBlood);}
        private void pictureBox1_Click(object sender, EventArgs e) {Application.Exit();}
    }
}
