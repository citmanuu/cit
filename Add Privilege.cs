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
        private int userId, deptId, roleId;
        private string formName;
        public Privilege(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void Privilege_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet2.RoleFormPrivileges' table. You can move, or remove it, as needed.
            this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);

            PreparedcomboRole();
            preparedcomboform();
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
        }
        // support
        #region
        private void preparedcomboform()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT FormId, FormName FROM [finance].[dbo].[FormMST] Order by 1";
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
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT RoleId, RoleName FROM [finance].[dbo].[RoleMST] Order by 1";
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

            string CanPrint = "CanPrint";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanPrint, formName))
            {
                btnPrint.Enabled = true;
            }
            else
                btnPrint.Enabled = false;
        }

        private void cleartextbox()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            checkbt1.Checked = false;
            checkbt2.Checked = false;
            checkbt3.Checked = false;
            checkbt4.Checked = false;
            checkbt5.Checked = false;
            retrievedForUpdate = false;
            checkBox1.Checked = false;
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
        #endregion
        // DML 
        #region
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                    //Connection String 
                    string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection con = new SqlConnection(cs);

                    // Open the connection
                    con.Open();
                    // Get the number of the row in database
                    SqlCommand cmd = new SqlCommand("privileges_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoleId", int.Parse(new SqlCommand("SELECT RoleId FROM [finance].[dbo].[RoleMST] where RoleName = '" + comboBox1.Text + "'", con).ExecuteScalar().ToString()));
                    cmd.Parameters.AddWithValue("@FormId", int.Parse(new SqlCommand("SELECT FormId FROM [finance].[dbo].[FormMST] where FormName = '" + comboBox2.Text + "'", con).ExecuteScalar().ToString()));
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

                try
                {
                   bool sucess =  Convert.ToBoolean(cmd.ExecuteScalar());
                    if(sucess)
                    {
                        MessageBox.Show("Privileges is Added ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);
                        cleartextbox();
                    }
                    else
                        MessageBox.Show("Some Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Please check your Form Name : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);
                    cleartextbox();
                    con.Close();
                }                      
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVPrivilege, "Privileges");
            objectsupport.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                //Connection String 
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection con = new SqlConnection(cs);

                // Open the connection
                con.Open();
               
                // Get the number of the row in database
                SqlCommand cmd = new SqlCommand("Privileges_addoreditordelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleId", int.Parse(new SqlCommand("SELECT RoleId FROM [finance].[dbo].[RoleMST] where RoleName = '" + comboBox1.Text + "'", con).ExecuteScalar().ToString()));
                cmd.Parameters.AddWithValue("@FormId", int.Parse(new SqlCommand("SELECT FormId FROM [finance].[dbo].[FormMST] where FormName = '" + comboBox2.Text + "'", con).ExecuteScalar().ToString()));
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

                try
                {
                    bool sucess = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (sucess)
                    {
                        MessageBox.Show("Privileges is Updated ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);
                        cleartextbox();
                    }
                    else
                        MessageBox.Show("Some Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Please check your Form Name : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);
                    cleartextbox();
                    con.Close();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete ?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (validateRecord())
                {
                    if(retrievedForUpdate)
                    {

                        //Connection String 
                        string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                        //Instantiate SQL Connection
                        SqlConnection con = new SqlConnection(cs);

                        // Open the connection
                        con.Open();
                        // Get the number of the row in database
                        SqlCommand cmd = new SqlCommand("Privileges_addoreditordelete", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RoleId", int.Parse(new SqlCommand("SELECT RoleId FROM [Ldap].[dbo].[RoleMST] where RoleName = '" + comboBox1.Text + "'", con).ExecuteScalar().ToString()));
                        cmd.Parameters.AddWithValue("@FormId", int.Parse(new SqlCommand("SELECT FormId FROM [Ldap].[dbo].[FormMST] where FormName = '" + comboBox2.Text + "'", con).ExecuteScalar().ToString()));

                        try
                        {
                            bool sucess = Convert.ToBoolean(cmd.ExecuteScalar());
                            if (sucess)
                            {
                                MessageBox.Show("Privileges is deleted ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);
                                cleartextbox();
                            }
                            else
                                MessageBox.Show("Some Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Please check your Form Name : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            this.roleFormPrivilegesTableAdapter4.Fill(this.financeDataSet2.RoleFormPrivileges);
                            cleartextbox();
                            con.Close();
                        }
                    }
                    else
                        MessageBox.Show("Please select first ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        #endregion

    }
}
