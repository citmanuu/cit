using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
   public class CheckingPrivileges
    {
        public int userId
        {
            get;
            private set;
        }

        public int deptId
        {
            get;
            private set;
        }

        public int roleId
        {
            get;
            private set;
        }

        public string FormName
        {
            get;
            private set;
        }
        public string buttonName
        {
            get;
            private set;
        }

        public bool CheckingPrivilegesaction (int _userId, int _deptId, int _roleId, string _buttonName, string _formName )
        {
            bool privileges = false;
            userId = _userId;
            deptId = _deptId;
            roleId = _roleId;
            buttonName = _buttonName;
            FormName = _formName;

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT CanAdd, CanUpdate, CanDelete, CanPrint, CanSearch FROM [Ldap].[dbo].[Privileges]  where RoleId = '" + roleId + "' and FormId = (select FormId from [Ldap].[dbo].[FormMST] where FormName = '" + FormName + "')", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();
            while (objDataReader.Read())
            {

                if (buttonName.Equals("CanAdd") && Convert.ToInt32(objDataReader["CanAdd"]) == 1)
                {
                    privileges = true;
                }
                if (buttonName.Equals("CanUpdate") && Convert.ToInt32(objDataReader["CanUpdate"]) == 1)
                {
                    privileges = true;
                }
                if (buttonName.Equals("CanDelete") && Convert.ToInt32(objDataReader["CanDelete"]) == 1)
                {
                    privileges = true;
                }
                if (buttonName.Equals("CanPrint") && Convert.ToInt32(objDataReader["CanPrint"]) == 1)
                {
                    privileges = true;
                }
                if (buttonName.Equals("CanSearch") && Convert.ToInt32(objDataReader["CanPrint"]) == 1)
                {
                    privileges = false;
                }
            }
            return privileges;
        }
        public bool CheckingPrivilegesform(int _userId, int _deptId, int _roleId, string _formName)
        {
            bool privilegesform = false;
            userId = _userId;
            deptId = _deptId;
            roleId = _roleId;
            FormName = _formName;

            List<string> FormClass = new List<string>();
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT a.FormName FROM [Ldap].[dbo].[FormMST] as a " +
                "inner join [Ldap].[dbo].[Privileges] as b on a.FormId = b.FormId " +
                "where b.RoleId = '" + roleId + "'", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                FormClass.Add((objDataReader.GetValue(0).ToString()));
            }
            if (FormClass.Count != 0)
            {
                foreach (var formNameId in FormClass)
                {
                    if (FormName.Equals(formNameId))
                    {
                        privilegesform = true;
                    }
                }
            }
            else
            {
                privilegesform = false;
            }
            objSqlConnection.Close();
            return privilegesform;
        }
    }
}
