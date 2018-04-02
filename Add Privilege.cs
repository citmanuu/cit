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
    public partial class Privilege : Form
    {
        bool   retrievedForUpdate = false;
        public Privilege()
        {
            InitializeComponent();
        }

        private void Privilege_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ldapDataSet8.RoleFormPrivileges' table. You can move, or remove it, as needed.
            this.roleFormPrivilegesTableAdapter3.Fill(this.ldapDataSet8.RoleFormPrivileges);
            PreparedcomboRole();
            preparedcomboform();
          }

        private void preparedcomboform()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT FormId, FormName FROM [Ldap].[dbo].[FormMST] Order by 1";
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

        private void PreparedcomboRole()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT RoleId, RoleName FROM [Ldap].[dbo].[RoleMST] Order by 1";
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
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btAdd_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("privileges_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleId", int.Parse(new SqlCommand("SELECT RoleId FROM [Ldap].[dbo].[RoleMST] where RoleName = '" + comboBox1.Text + "'", con).ExecuteScalar().ToString()));
                    cmd.Parameters.AddWithValue("@FormId", int.Parse(new SqlCommand("SELECT FormId FROM [Ldap].[dbo].[FormMST] where FormName = '" + comboBox2.Text + "'", con).ExecuteScalar().ToString()));
                    if (checkbt1.Checked == true)
                        cmd.Parameters.AddWithValue("@CanAdd", 1);
                    else
                        cmd.Parameters.AddWithValue("@CanAdd", 0);

                    if (checkbt2.Checked == true)
                        cmd.Parameters.AddWithValue("@CanUpdate", 1);
                    else
                        cmd.Parameters.AddWithValue("@CanUpdate", 0);

                    if (checkbt3.Checked == true)
                        cmd.Parameters.AddWithValue("@CanDelete", 1);
                    else
                        cmd.Parameters.AddWithValue("@CanDelete", 0);

                    if (checkbt4.Checked == true)
                        cmd.Parameters.AddWithValue("@CanPrint", 1);
                    else
                        cmd.Parameters.AddWithValue("@CanPrint", 0);

                    if (checkbt5.Checked == true)
                        cmd.Parameters.AddWithValue("@CanSearch", 1);
                    else
                        cmd.Parameters.AddWithValue("@CanSearch", 0);

                    bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (success)
                    {
                        MessageBox.Show("Privileges is Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: This line of code loads data into the 'ldapDataSet8.RoleFormPrivileges' table. You can move, or remove it, as needed.
                    this.roleFormPrivilegesTableAdapter3.Fill(this.ldapDataSet8.RoleFormPrivileges);
                    con.Close();
                        cleartextbox();
                    }
                    else
                    {
                        MessageBox.Show("Please check your Form Name", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartextbox();
                    }             
            }
        }

        private void cleartextbox()
        {
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            checkbt1.Checked = false;
            checkbt2.Checked = false;
            checkbt3.Checked = false;
            checkbt4.Checked = false;
            checkbt5.Checked = false;
            retrievedForUpdate = false;
        }

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";
            if (this.comboBox1.SelectedItem == null || this.comboBox1.Text == "" || this.comboBox1.SelectedIndex == 0)
            {
                validationMessage += "Please provide Role Name\n";
                validationResult = false;
            }
            if (this.comboBox2.SelectedItem == null || this.comboBox2.Text == "" || this.comboBox2.SelectedIndex == 0)
            {
                validationMessage += "Please provide Form Name\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void btUpdate_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("privilege_update", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleId", int.Parse(new SqlCommand("SELECT RoleId FROM [Ldap].[dbo].[RoleMST] where RoleName = '" + comboBox1.Text + "'", con).ExecuteScalar().ToString()));
                cmd.Parameters.AddWithValue("@FormId", int.Parse(new SqlCommand("SELECT FormId FROM [Ldap].[dbo].[FormMST] where FormName = '" + comboBox2.Text + "'", con).ExecuteScalar().ToString()));
                if (checkbt1.Checked == true)
                    cmd.Parameters.AddWithValue("@CanAdd", 1);
                else
                    cmd.Parameters.AddWithValue("@CanAdd", 0);

                if (checkbt2.Checked == true)
                    cmd.Parameters.AddWithValue("@CanUpdate", 1);
                else
                    cmd.Parameters.AddWithValue("@CanUpdate", 0);

                if (checkbt3.Checked == true)
                    cmd.Parameters.AddWithValue("@CanDelete", 1);
                else
                    cmd.Parameters.AddWithValue("@CanDelete", 0);

                if (checkbt4.Checked == true)
                    cmd.Parameters.AddWithValue("@CanPrint", 1);
                else
                    cmd.Parameters.AddWithValue("@CanPrint", 0);

                if (checkbt5.Checked == true)
                    cmd.Parameters.AddWithValue("@CanSearch", 1);
                else
                    cmd.Parameters.AddWithValue("@CanSearch", 0);

                bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                if (success)
                {
                    MessageBox.Show("Privileges is Update", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: This line of code loads data into the 'ldapDataSet8.RoleFormPrivileges' table. You can move, or remove it, as needed.
                    this.roleFormPrivilegesTableAdapter3.Fill(this.ldapDataSet8.RoleFormPrivileges);
                    con.Close();
                    cleartextbox();
                }
                else
                {
                    MessageBox.Show("Please Click the Add Button", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cleartextbox();
                }
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("privilege_delete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleId", int.Parse(new SqlCommand("SELECT RoleId FROM [Ldap].[dbo].[RoleMST] where RoleName = '" + comboBox1.Text + "'", con).ExecuteScalar().ToString()));
                cmd.Parameters.AddWithValue("@FormId", int.Parse(new SqlCommand("SELECT FormId FROM [Ldap].[dbo].[FormMST] where FormName = '" + comboBox2.Text + "'", con).ExecuteScalar().ToString()));

                bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                if (success)
                {
                    MessageBox.Show("Privileges is Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: This line of code loads data into the 'ldapDataSet8.RoleFormPrivileges' table. You can move, or remove it, as needed.
                    this.roleFormPrivilegesTableAdapter3.Fill(this.ldapDataSet8.RoleFormPrivileges);
                    con.Close();
                    cleartextbox();
                }
                else
                {
                    MessageBox.Show("Please Click Department, Role and Form Box", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cleartextbox();
                }
            }
        }

        private void DGVPrivilege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboBox1.Text = DGVPrivilege.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                comboBox2.Text = DGVPrivilege.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                checkbt1.Checked = Convert.ToBoolean(DGVPrivilege.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                checkbt2.Checked = Convert.ToBoolean(DGVPrivilege.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                checkbt3.Checked = Convert.ToBoolean(DGVPrivilege.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                checkbt4.Checked = Convert.ToBoolean(DGVPrivilege.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                checkbt5.Checked = Convert.ToBoolean(DGVPrivilege.Rows[e.RowIndex].Cells[9].FormattedValue.ToString());
                retrievedForUpdate = true;
            }
        }

        private void btClearRecord_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            checkbt1.Checked = false;
            checkbt2.Checked = false;
            checkbt3.Checked = false;
            checkbt4.Checked = false;
            checkbt5.Checked = false;
            retrievedForUpdate = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder SearchStatement = new StringBuilder();
            try
            {
                SearchStatement.Clear();
                if (txtRoleSearch.Text.Length > 0)
                {
                    SearchStatement.Append("RoleName like '%" + txtRoleSearch.Text + "%'");
                }
                if (txtFormSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("FormName like '%" + txtFormSearch.Text + "%'");
                }                
                //Refresh DGV 
                roleFormPrivilegesBindingSource5.Filter = SearchStatement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtRoleSearch.Text = "";
            txtFormSearch.Text = "";
            roleFormPrivilegesBindingSource5.Filter = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkbt1.Checked = true;
                checkbt2.Checked = true;
                checkbt3.Checked = true;
                checkbt4.Checked = true;
                checkbt5.Checked = true;
            }
            else
            {
                checkbt1.Checked = false;
                checkbt2.Checked = false;
                checkbt3.Checked = false;
                checkbt4.Checked = false;
                checkbt5.Checked = false;
            }
        }
    }
}
