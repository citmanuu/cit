using System;
using System.Collections;
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
    public partial class frmCloneDeptBudget : Form
    {
        Dictionary<int, string> departments = new Dictionary<int, string>();
        private int userId, deptId, roleId;
        private string formName;
        public frmCloneDeptBudget(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void CloneDeptBudget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet.DEPT' table. You can move, or remove it, as needed.
            this.dEPTTableAdapter.Fill(this.financeDataSet.DEPT);
            PrepareFinancialYearCombo();
            PrepareDepartmentsCombo(0);
            PrepareToYearCombo();
        }

        #region //DML Functions
        //Prepare Financial Year LOV
        private void PrepareFinancialYearCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKFYID, FYName FROM [Finance].[dbo].[FinancialYear] Order by 1";
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
                comboFromFinancialYear.DisplayMember = "ListItemDesc"; // will display Name property
                comboFromFinancialYear.ValueMember = "ListItemID"; // will select Value property
                comboFromFinancialYear.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare Departments LOV
        private void PrepareDepartmentsCombo(int FKFYID)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT Distinct DeptId, DeptName FROM [Finance].[dbo].[Department] A, [Finance].[dbo].[BUDGET] B " +
                                   "WHERE B.FKDEPID = A.DeptId AND B.FKFYID = " + FKFYID + " Order by 1";
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
                comboDepartment.DisplayMember = "ListItemDesc"; // will display Name property
                comboDepartment.ValueMember = "ListItemID"; // will select Value property
                comboDepartment.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare Financial Year LOV
        private void PrepareToYearCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKFYID, FYName FROM [Finance].[dbo].[FinancialYear] Order by 1";
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
                comboToFinancialYear.DisplayMember = "ListItemDesc"; // will display Name property
                comboToFinancialYear.ValueMember = "ListItemID"; // will select Value property
                comboToFinancialYear.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        #endregion //DML Functions

        //        #region //Support Functions
        //Move Department to List of Selected Departments
        private void btnMove_Click(object sender, EventArgs e)
        {
            MoveDepartments();
        }

        //Move Departments from FromDepartmentList to toDepartmentList
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
                if (CheckDuplicate(item.Row["DEPNAME"].ToString()))
                {
                    depts.Add(new LOV(Convert.ToInt32(item.Row["PKDEPID"].ToString()), item.Row["DEPNAME"].ToString()));
                }
            }
            toDepartmentList.DisplayMember = "ListItemDesc";
            toDepartmentList.ValueMember = "ListItemID ";
            toDepartmentList.DataSource = depts;

        }

        //Check that Duplicates Dpertments do not enter in the ToDepartmentList
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

        //Move Multiple Departments to List of Selected Departments
        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            MoveDepartments();
        }

        //Remove Department from List of Selected Department
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

        //Remove Departments from List of Selected Department
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

        //Set the Departments and Financial year LOVs based on selection of FromFinancialYear
        private void comboFromFinancialYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareDepartmentsCombo(Convert.ToInt32(comboFromFinancialYear.SelectedValue));
            PrepareToYearCombo();
        }

        //Add Records to Budget Table
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;

            if (validateRecord())
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                //Prepare for record addition

                SqlCommand objSqlCmd = new SqlCommand("CopyBudget", objSqlConnection);
                objSqlCmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    objSqlConnection.Open();
                    int itemCount = toDepartmentList.Items.Count;
                    foreach (LOV item in toDepartmentList.Items)
                    {
                        string s = item.ListItemID.ToString();
                        objSqlCmd.Parameters.AddWithValue("@FromFKFYID", Convert.ToInt32(comboFromFinancialYear.SelectedValue));
                        objSqlCmd.Parameters.AddWithValue("@ToFKFYID", Convert.ToInt32(comboToFinancialYear.SelectedValue));
                        objSqlCmd.Parameters.AddWithValue("@FromFKDEPID", comboDepartment.SelectedValue);

                        objSqlCmd.Parameters.AddWithValue("@ToFKDEPID", Convert.ToInt32(s));
                        objSqlCmd.Parameters.AddWithValue("@UpdatedOn", today);
                        objSqlCmd.Parameters.AddWithValue("@UpdatedBy", "User");

                        if (chkUpdateOn.Checked == true)
                            objSqlCmd.Parameters.AddWithValue("@UpdateOn", 1);
                        else
                            objSqlCmd.Parameters.AddWithValue("@UpdateOn", 0);

                        Convert.ToString(objSqlCmd.ExecuteScalar());
                        objSqlCmd.Parameters.Clear();
                    }
                    MessageBox.Show("Budget Records added for Selected Department(s)", "Record(s) Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    if (ex.Message.Contains("PK_Budget"))
                    {
                        MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Contains("Unique_Dep_Budget_Account"))
                    {
                        MessageBox.Show("Record already added.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
            }

        }

        //Validate Record
        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (Convert.ToString(comboFromFinancialYear.SelectedValue) == "0")
            {
                validationMessage = "Please Select Financial Year\n";
                validationResult = false;
            }
            if (Convert.ToString(comboDepartment.SelectedValue) == "0")
            {
                validationMessage += "Please Select the Department from where Budget is to be copied.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboToFinancialYear.SelectedValue) == "0")
            {
                validationMessage += "Please Select Target Financial Year.\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Bill Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}
