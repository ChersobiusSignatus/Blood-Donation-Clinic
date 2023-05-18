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
    public partial class LoginForm : Form
    {        
        DataBase dataBase = new DataBase();
        public LoginForm()
        {
            InitializeComponent();           
        }
        private void Login_Load(object sender, EventArgs e)
        {            
            textBoxLogin.MaxLength = 30;
            textBoxPassword.MaxLength = 30;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var userLogin = textBoxLogin.Text;
            var userPassword = textBoxPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string queryString = $"select id, login, password from AuthorisedUser where login = '{userLogin}' and password = '{userPassword}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                EmployeesForm empform = new EmployeesForm();
                this.Hide();
                empform.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Account doesn't exist", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e) {}
        private void textBoxPassword_TextChanged(object sender, EventArgs e) {}
        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            Application.Exit();            
        }
    }
}


