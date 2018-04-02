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
    public partial class Roles : Form
    {
        bool retrievedForUpdate = false;
        int GlobalId = 0;
        private int userId, deptId, roleId;
        private string formName;
        public Roles(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void AddRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ldapDataSet.RoleMST' table. You can move, or remove it, as needed.
            this.roleMSTTableAdapter.Fill(this.ldapDataSet.RoleMST);
            prepareaction();
        }

        // DML 
        #region
        // add the record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                //Connection String 
                string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection con = new SqlConnection(cs);

                // Open the connection
                con.Open();
                // Get the number of the row in database
                SqlCommand cmd = new SqlCommand("RoleMST_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", textBox1.Text.ToString().ToUpper());
                cmd.Parameters.AddWithValue("@RoleDescription", richTextBox1.Text.ToString().ToUpper());
                bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                if (success)
                {
                    MessageBox.Show("Role is Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.roleMSTTableAdapter.Fill(this.ldapDataSet.RoleMST);
                    con.Close();
                    cleartextbox();

                }
                else
                {
                    MessageBox.Show("Please check your Role Name", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartextbox();
                }
            }
        }
        // exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // update the form
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //If Form Controls are validated proceed to update record
            if (validateRecord())
            {
                //Check if we are not Updating Record
                if (retrievedForUpdate)
                {
                    //Connection String 
                    string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection con = new SqlConnection(cs);
                    // Open the connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("RoleMST_update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleId", GlobalId);
                    cmd.Parameters.AddWithValue("@RoleName", textBox1.Text.ToString().ToUpper());
                    cmd.Parameters.AddWithValue("@RoleDescription", richTextBox1.Text.ToString().ToUpper());
                    bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (success)
                    {
                        MessageBox.Show("Role is Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.roleMSTTableAdapter.Fill(this.ldapDataSet.RoleMST);
                        con.Close();
                        cleartextbox();

                    }
                    else
                    {
                        MessageBox.Show("Please check your Role Name", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartextbox();
                    }
                }
            }
        }
        // delete the form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete the Role?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (validateRecord())
                {
                    //Connection String 
                    string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection con = new SqlConnection(cs);

                    // Open the connection
                    con.Open();

                    // Get the number of the row in database
                    SqlCommand cmd = new SqlCommand("RoleMST_delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleName", textBox1.Text.ToString());

                    bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (success)
                    {
                        MessageBox.Show("Role is Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.roleMSTTableAdapter.Fill(this.ldapDataSet.RoleMST);
                        con.Close();
                        cleartextbox();
                    }
                    else
                    {
                        MessageBox.Show("Please Click Role Name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cleartextbox();
                    }
                }
            }
        }
        #endregion

        // support
        #region
        private void cleartextbox()
        {
            textBox1.Text = String.Empty;
            richTextBox1.Text = String.Empty;
            retrievedForUpdate = false;
        }

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";
            if (textBox1.Text.Length == 0)
            {
                validationMessage += "Please provide Role Name\n";
                validationResult = false;
            }
            if (richTextBox1.Text.Length == 0)
            {
                validationMessage += "Please provide Description\n";
                validationResult = false;
            }
            if (richTextBox1.Text.Length >= 250)
            {
                validationMessage += "Please provide only 250 charecters in description box\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder SearchStatement = new StringBuilder();
            try
            {
                SearchStatement.Clear();
                if (txtRoleSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("RoleName like '%" + txtRoleSearch.Text + "%'");
                }
                //Refresh DGV 
                roleMSTBindingSource.Filter = SearchStatement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtRoleSearch.Text = "";
            roleMSTBindingSource.Filter = null;
        }

        private void btClearRecord_Click(object sender, EventArgs e)
        {
            cleartextbox();
        }

        private void DGVRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = DGVRole.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                richTextBox1.Text = DGVRole.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                retrievedForUpdate = true;
                string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT RoleId FROM [Ldap].[dbo].[RoleMST] where RoleName = '" + textBox1.Text + "'", con);
                GlobalId = int.Parse(myCommand.ExecuteScalar().ToString());
                con.Close();
            }
        }
        //prepare the action add, delete, update
        private void prepareaction()
        {
            string CanAdd = "CanAdd";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanAdd, formName))
            {
                btnAdd.Enabled = true;
            }
            else
                btnAdd.Enabled = false;
            string CanUpdate = "CanUpdate";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanUpdate, formName))
            {
                btnUpdate.Enabled = true;
            }
            else
                btnUpdate.Enabled = false;
            string CanDelete = "CanDelete";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanDelete, formName))
            {
                btnDelete.Enabled = true;
            }
            else
                btnDelete.Enabled = false;
        }
        #endregion
    }
}