using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class RolePrivileges : Form
    {
        private int userId, deptId, roleId;
        private string formName;
        public RolePrivileges(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }
        // DML
        #region
        private void btRolesMove_Click(object sender, EventArgs e)
        {
            MoveRoles();
        }

        private void MoveRoles()
        {
            List<LOV> roles = new List<LOV>();

            int index = 0;
            while (index < toRolesList.Items.Count)
            {
                LOV s = (LOV)toRolesList.Items[index];
                roles.Add(new LOV(s.ListItemID, s.ListItemDesc));

                // do something with s
                index++;
            }
            foreach (DataRowView item in fromRolesList.SelectedItems)
            {
                //Check if item does not exist already
                if (CheckRolesDuplicate(item.Row["RoleName"].ToString()))
                {
                    roles.Add(new LOV(Convert.ToInt32(item.Row["RoleId"].ToString()), item.Row["RoleName"].ToString()));
                }
            }
            toRolesList.DisplayMember = "ListItemDesc";
            toRolesList.ValueMember = "ListItemID ";
            toRolesList.DataSource = roles;
        }

        private void btRolesMoveAll_Click(object sender, EventArgs e)
        {
            MoveRoles();
        }

        private void btRolesRemove_Click(object sender, EventArgs e)
        {
            List<LOV> roles = new List<LOV>();
            LOV selectedRole = (LOV)toRolesList.SelectedItem;

            int index = 0;
            while (index < toRolesList.Items.Count)
            {
                LOV s = (LOV)toRolesList.Items[index];
                if (s.ListItemID != selectedRole.ListItemID)
                    roles.Add(new LOV(s.ListItemID, s.ListItemDesc));

                // do something with s
                index++;
            }
            toRolesList.DisplayMember = "ListItemDesc";
            toRolesList.ValueMember = "ListItemID ";
            toRolesList.DataSource = roles;
            MessageBox.Show("Item removed.", "Items Removed from the List", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btRolesRemoveAll_Click(object sender, EventArgs e)
        {

            List<LOV> roles = new List<LOV>();
            List<int> selectedDept = new List<int>();
            Boolean removeFlag = false;

            //Prepare List of Selected Department Numbers
            foreach (LOV sd in toRolesList.SelectedItems)
            {
                selectedDept.Add(sd.ListItemID);
            }

            //Check that the current item which is to be added to the list was not selected

            int index = 0;
            while (index < toRolesList.Items.Count)
            {
                removeFlag = false;
                LOV s = (LOV)toRolesList.Items[index];
                foreach (int i in selectedDept)
                {
                    if (s.ListItemID == i)
                        removeFlag = true;
                }
                if (removeFlag == false)
                    roles.Add(new LOV(s.ListItemID, s.ListItemDesc));
                index++;
            }
            toRolesList.DisplayMember = "ListItemDesc";
            toRolesList.ValueMember = "ListItemID ";
            toRolesList.DataSource = roles;

            MessageBox.Show(" Items removed.", "Items Removed from the List", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void viewUserMapping_Click(object sender, EventArgs e)
        {
            View objectveiw = new View();
            objectveiw.ShowDialog();
        }

        private void btAddToDatabase_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                //Prepare for record addition

                SqlCommand objSqlCmd = new SqlCommand("UsertoDepttoRole_insert", objSqlConnection);
                objSqlCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    objSqlConnection.Open();
                    int itemCount = toRolesList.Items.Count;
                    foreach (LOV item in toRolesList.Items)
                    {
                        string s = item.ListItemID.ToString();
                        objSqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(comboBox1.SelectedValue));
                        objSqlCmd.Parameters.AddWithValue("@DeptID", Convert.ToInt32(comboBox2.SelectedValue));
                        objSqlCmd.Parameters.AddWithValue("@RoleID", Convert.ToInt32(s));

                        Convert.ToString(objSqlCmd.ExecuteScalar());
                        objSqlCmd.Parameters.Clear();
                    }
                    MessageBox.Show("Records added for Selected User, Department and Selected Role(s)", "Record(s) Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearcombobox();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
            }
        }

        #endregion


        // support
        #region
        private bool CheckRolesDuplicate(string newItem)
        {
            int itemCount = toRolesList.Items.Count;
            int index = 0;
            while (index < itemCount)
            {
                LOV s = (LOV)toRolesList.Items[index];
                // do something with s
                if (s.ListItemDesc == newItem)
                {
                    MessageBox.Show(s.ListItemDesc + " already exists.", "Item addition error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                index++;
            }
            return true;
        }

        private void clearcombobox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (Convert.ToString(comboBox1.SelectedValue) == "0")
            {
                validationMessage = "Please Select User Name\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void Role_Modify_Privileges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet1.RoleMST' table. You can move, or remove it, as needed.
            this.roleMSTTableAdapter1.Fill(this.financeDataSet1.RoleMST);
            preparedcombo();
        }

        private void preparedcombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT UserId, Name FROM [finance].[dbo].[Users] Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBox1.DisplayMember = "ListItemDesc"; // will display Name property
                comboBox1.ValueMember = "ListItemID"; // will select Value property
                comboBox1.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                var objLOVClass = new List<LOV>();
                objLOVClass.Add(new LOV(0, "-- Please Select --"));

                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);
                //Prepare Update String                
                string selectCommand = "SELECT a.DeptId, a.DeptName FROM [finance].[dbo].[Department] as a inner join [finance].[dbo].[UserDept] as b on a.DeptId = b.DeptId where b.UserId = '" + Convert.ToInt32(comboBox1.SelectedValue) + "'Order by 1";
                SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                    while (objDataReader.Read())
                    {
                        objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                    }
                    // Bind combobox list to the items
                    comboBox2.DisplayMember = "ListItemDesc"; // will display Name property
                    comboBox2.ValueMember = "ListItemID"; // will select Value property
                    comboBox2.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
        }
        #endregion
    }
}
