using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace BloodManagement
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-CD5T2HK;Initial Catalog=BloodBank;Integrated Security=True");
        internal object vw_DonorDetail;
        internal object vw_Blood;
        public object DonorInformation { get; internal set; }
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            { 
                sqlConnection.Open();
            }
        }                
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }                
        public SqlConnection getConnection() 
        { 
            return sqlConnection; 
        }  
    }
}

