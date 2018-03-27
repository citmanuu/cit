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
    public partial class DeptPrivileges : Form
    {
        public DeptPrivileges()
        {
            InitializeComponent();
        }

        private void AssignUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ldapDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.ldapDataSet.Department);

            PreparedcomboUser();
        }

        private void PreparedcomboUser()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT UserId, Name FROM [Ldap].[dbo].[Users] Order by 1";
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

        private void btnMove_Click(object sender, EventArgs e)
        {
            MoveDepartments();
        }

        private void MoveDepartments()
        {
            List<LOV> depts = new List<LOV>();

            int index = 0;
            while (index < toDepartmentList.Items.Count)
            {
                LOV s = (LOV)toDepartmentList.Items[index];
                depts.Add(new LOV(s.ListItemID, s.ListItemDesc));

                // do something with s
                index++;
            }
            foreach (DataRowView item in fromDepartmentList.SelectedItems)
            {
                //Check if item does not exist already
                if (CheckDuplicate(item.Row["DeptName"].ToString()))
                {
                    depts.Add(new LOV(Convert.ToInt32(item.Row["DeptId"].ToString()), item.Row["DeptName"].ToString()));
                }
            }
            toDepartmentList.DisplayMember = "ListItemDesc";
            toDepartmentList.ValueMember = "ListItemID ";
            toDepartmentList.DataSource = depts;
        }

        private bool CheckDuplicate(string newItem)
        {
            int itemCount = toDepartmentList.Items.Count;
            int index = 0;
            while (index < itemCount)
            {
                LOV s = (LOV)toDepartmentList.Items[index];
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

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            MoveDepartments();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<LOV> depts = new List<LOV>();
            LOV selectedDept = (LOV)toDepartmentList.SelectedItem;

            int index = 0;
            while (index < toDepartmentList.Items.Count)
            {
                LOV s = (LOV)toDepartmentList.Items[index];
                if (s.ListItemID != selectedDept.ListItemID)
                    depts.Add(new LOV(s.ListItemID, s.ListItemDesc));

                // do something with s
                index++;
            }
            toDepartmentList.DisplayMember = "ListItemDesc";
            toDepartmentList.ValueMember = "ListItemID ";
            toDepartmentList.DataSource = depts;
            MessageBox.Show("Item removed.", "Items Removed from the List", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            List<LOV> depts = new List<LOV>();
            List<int> selectedDept = new List<int>();
            Boolean removeFlag = false;

            //Prepare List of Selected Department Numbers
            foreach (LOV sd in toDepartmentList.SelectedItems)
            {
                selectedDept.Add(sd.ListItemID);
            }

            //Check that the current item which is to be added to the list was not selected

            int index = 0;
            while (index < toDepartmentList.Items.Count)
            {
                removeFlag = false;
                LOV s = (LOV)toDepartmentList.Items[index];
                foreach (int i in selectedDept)
                {
                    if (s.ListItemID == i)
                        removeFlag = true;
                }
                if (removeFlag == false)
                    depts.Add(new LOV(s.ListItemID, s.ListItemDesc));
                index++;
            }
            toDepartmentList.DisplayMember = "ListItemDesc";
            toDepartmentList.ValueMember = "ListItemID ";
            toDepartmentList.DataSource = depts;

            MessageBox.Show(" Items removed.", "Items Removed from the List", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btRolesMove_Click(object sender, EventArgs e)
        {
            
        }

        private void btRolesMoveAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btRolesRemove_Click(object sender, EventArgs e)
        {
            }

        private void btRolesRemoveAll_Click(object sender, EventArgs e)
        {
        }

        private void btAddToDatabase_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                //Prepare for record addition

                SqlCommand objSqlCmd = new SqlCommand("userdept_insert", objSqlConnection);
                objSqlCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    objSqlConnection.Open();
                    int itemCount = toDepartmentList.Items.Count;
                    foreach (LOV item in toDepartmentList.Items)
                    {
                        string s = item.ListItemID.ToString();
                        objSqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(comboBox1.SelectedValue));
                        objSqlCmd.Parameters.AddWithValue("@DeptID", Convert.ToInt32(s));
                        Convert.ToString(objSqlCmd.ExecuteScalar());
                        objSqlCmd.Parameters.Clear();
                    }
                    MessageBox.Show("Records added for Selected Department(s) and Selected Role(s)", "Record(s) Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearcombobox();
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PK_Budget"))
                    {
                        MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    objSqlConnection.Close();
                }
            }
        }

        private void clearcombobox()
        {
            comboBox1.SelectedIndex = 0;
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
            if(toDepartmentList.Items.Count == 0)
            {
                validationMessage = "Please Select Department\n";
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

        private void button1_Click(object sender, EventArgs e)
        {
            View objectview = new View();
            objectview.ShowDialog();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentTableAdapter.FillBy(this.ldapDataSet.Department);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
