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
namespace BloodManagement.BloodRequest
{
    public partial class BloodRequestInfoo : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public BloodRequestInfoo() {InitializeComponent();}

        private void CreatingColumns()
        {
            DataGridInfoRequest.Columns.Add("HospitalName", "Hospital Name");
            DataGridInfoRequest.Columns.Add("Address", "Address");
            DataGridInfoRequest.Columns["Address"].Visible = false;
            DataGridInfoRequest.Columns.Add("PhoneNumber", "Phone Number");
            DataGridInfoRequest.Columns["PhoneNumber"].Visible = false;
            DataGridInfoRequest.Columns.Add("Email", "Email");
            DataGridInfoRequest.Columns["Email"].Visible = false;            
        }
        private void ReadRow(DataGridView datagw, IDataRecord datarecord)
        {
            if (datarecord.FieldCount < 3) {return;}
            string hospname = datarecord.IsDBNull(0) ? "" : datarecord.GetString(0);
            string address = datarecord.IsDBNull(1) ? "" : datarecord.GetString(1);
            string phone = datarecord.IsDBNull(2) ? "" : datarecord.GetString(2);
            string email = datarecord.IsDBNull(3) ? "" : datarecord.GetString(3);           
            datagw.Rows.Add(hospname, address, phone, email);
        }
        private void NewDataGrid(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string queryString = $"select * from Hospital order by HospitalName";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {ReadRow(datagw, reader);}
            reader.Close();
        }
        private void Search(DataGridView datagw)
        {
            datagw.Rows.Clear();
            string searchstring = "SELECT * from Hospital WHERE Hospital.HospitalName LIKE @hospName";
            SqlCommand command = new SqlCommand();
            command.Connection = dataBase.getConnection();
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                command.CommandText = searchstring;
                command.Parameters.AddWithValue("@hospName", $"%{textBox1.Text}%");
            }    
            else
            {
                command.CommandText = "SELECT * from Hospital";
            }
            dataBase.openConnection();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read()) {ReadRow(datagw, read);}
            read.Close();
        }
        private void BloodRequestInfoo_Load(object sender, EventArgs e)
        {
            CreatingColumns();
            NewDataGrid(DataGridInfoRequest);
            string querystring1 = $"select * from Hospital order by HospitalName";
            SqlDataAdapter command1 = new SqlDataAdapter(querystring1, dataBase.getConnection());
            DataTable nameDep = new DataTable();
            command1.Fill(nameDep);
        }
        private void pictureBox1_Click(object sender, EventArgs e){this.Hide();}
        private void DataGridInfoRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridInfoRequest.Rows[selectedRow];
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox8.Text = row.Cells[2].Value.ToString();
                textBox9.Text = row.Cells[3].Value.ToString();               
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {Search(DataGridInfoRequest);}
    }
}
