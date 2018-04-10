using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    class AdministratorLogin
    {
        public bool administratorLogin(int userId)
        {
            bool admin = true;
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT Name FROM [finance].[dbo].[Users] where UserId = '" + userId + "'", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();

            while (objDataReader.Read())
            {
                if (objDataReader["Name"].Equals("admin1"))
                {
                    admin = false;
                }
                if (objDataReader["Name"].Equals("admin2"))
                {
                    admin = false;
                }
            }
            objSqlConnection.Close();
            return admin;
        }
    }
}
