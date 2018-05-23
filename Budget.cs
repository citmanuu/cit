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
    public partial class frmBudget : Form
    {
        bool retrievedForUpdate;
        bool queryMode;
        private int userId, deptId, roleId;
        string formName;
        public frmBudget(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void Budget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet16.BudgetWithAccounts' table. You can move, or remove it, as needed.
            this.budgetWithAccountsTableAdapter2.Fill(this.financeDataSet16.BudgetWithAccounts);
            PrepareDeptCombo();
            PrepareFYCombo();
            PrepareSL1Combo();
            PrepareSL2Combo("0");
            PrepareSL3Combo("0");
            Preparebudgetactype();
            timer1_Tick(0, new EventArgs());
            //PrepareAccountsCombo("0");             
            UnpinControls();
            retrievedForUpdate = false;
            queryMode = false;
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
        }

        private void Preparebudgetactype()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] where GEMID = 5 Order by 2";
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
                comboBudgetACTYPE.DisplayMember = "ListItemDesc"; // will display Name property
                comboBudgetACTYPE.ValueMember = "ListItemID"; // will select Value property
                comboBudgetACTYPE.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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
        #region

        //Prepare Department Combo
        private void PrepareDeptCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT DeptId, DeptName FROM [Finance].[dbo].[Department] Order by 1";
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
                comboDept.DisplayMember = "ListItemDesc"; // will display Name property
                comboDept.ValueMember = "ListItemID"; // will select Value property
                comboDept.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare Financial Year Combo
        private void PrepareFYCombo()
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
                comboFY.DisplayMember = "ListItemDesc"; // will display Name property
                comboFY.ValueMember = "ListItemID"; // will select Value property
                comboFY.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare SL1Combo
        private void PrepareSL1Combo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select Distinct A.SL1ID, A.SL1Name from Finance.dbo.SL1 A, Finance.dbo.AccountsView B " +
                                   "where  A.SL1ID = B.SL1ID order by 2";
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
                comboSL1.DisplayMember = "ListItemDesc"; // will display Name property
                comboSL1.ValueMember = "ListItemID"; // will select Value property
                comboSL1.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare SL2Combo
        private void PrepareSL2Combo(string fkSL1)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select Distinct A.PKSL2, A.SL2Name from Finance.dbo.SL2 A, Finance.dbo.AccountsView B " +
                                    "where B.SL1ID = " + fkSL1 + " and A.PKSL2 = B.PKSL2 order by 2";
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
                comboSL2.DisplayMember = "ListItemDesc"; // will display Name property
                comboSL2.ValueMember = "ListItemID"; // will select Value property
                comboSL2.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare SL3Combo
        private void PrepareSL3Combo(string fkSL2)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select Distinct A.PKSL3, A.SL3Name from Finance.dbo.SL3 A, Finance.dbo.AccountsView B " +
                                    "where B.PKSL2 = " + fkSL2 + "and A.PKSL3 = B.FKSL3ID order by 2";
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
                comboSL3.DisplayMember = "ListItemDesc"; // will display Name property
                comboSL3.ValueMember = "ListItemID"; // will select Value property
                comboSL3.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Prepare Accounts Combo
        private void PrepareAccountsCombo(string fkSL3)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select PKACID, ACCOUNTNAME from Finance.dbo.Accounts where FKSL3ID = " + fkSL3 + "order by 2";
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
                comboAccount.DisplayMember = "ListItemDesc"; // will display Name property
                comboAccount.ValueMember = "ListItemID"; // will select Value property
                comboAccount.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Add Account Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //If Form Controls are validated proceed to add record
                if (validateRecord())
                {
                    //Check if we are not Updating Record
                    if (!retrievedForUpdate)
                    {

                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string insertCommand = "INSERT INTO [dbo].[Budget] (FKFYID, FKDEPID, FKACID, BECY, RBECY, BENY,BudgetAcType) " +
                                                "VALUES (@FKFYID, @FKDEPID, @FKACID, @BECY, @RBECY, @BENY,@BudgetAcType)";

                        SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objInsertCommand.Parameters.AddWithValue("@FKFYID", comboFY.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@FKDEPID", comboDept.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@FKACID", comboAccount.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@BECY", txtBECY.Text);
                        objInsertCommand.Parameters.AddWithValue("@RBECY", txtRBECY.Text);
                        objInsertCommand.Parameters.AddWithValue("@BENY", txtBENY.Text);
                        objInsertCommand.Parameters.AddWithValue("@BudgetAcType", comboBudgetACTYPE.SelectedValue);

                    try
                        {
                            objSqlConnection.Open();
                            objInsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_Budget"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBECY.Focus();
                            }
                            else if (ex.Message.Contains("Unique_Dep_Budget_Account"))
                            {
                                MessageBox.Show("This account head has already been added to departmental Budget", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBECY.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                    //Refresh DGV 
                    this.budgetWithAccountsTableAdapter2.Fill(this.financeDataSet16.BudgetWithAccounts);
                }
                }
         }

        //Update record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                //If Form Controls are validated proceed to add record
                if (validateRecord())
                {
                    //Check if we are not Updating Record
                    if (retrievedForUpdate)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String

                        string updateCommand = "Update [dbo].[Budget] set FKACID = @FKACID, BECY = @BECY, RBECY = @RBECY, BENY = @BENY , BudgetAcType = @BudgetAcType" +
                                               "where PKBUDGETID = @PKBUDGETID";
                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);
                        objUpdateCommand.Parameters.AddWithValue("@FKACID", comboAccount.SelectedValue);
                        objUpdateCommand.Parameters.AddWithValue("@PKBUDGETID", txtPKBudgetID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@BECY", txtBECY.Text);
                        objUpdateCommand.Parameters.AddWithValue("@RBECY ", txtRBECY.Text);
                        objUpdateCommand.Parameters.AddWithValue("@BENY", txtBENY.Text);
                        objUpdateCommand.Parameters.AddWithValue("@BudgetAcType", comboBudgetACTYPE.SelectedValue);

                    try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_Accounts"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBECY.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                    //Refresh DGV 
                    this.budgetWithAccountsTableAdapter2.Fill(this.financeDataSet16.BudgetWithAccounts);
                }
                }
        }

        #endregion

        //Support Methods
        #region

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        //Clear Template Method
        private void ClearTemplate()
        {
            if (pinFY.Checked == false)
            {
                comboFY.SelectedValue = 0;
                comboFY.Enabled = true;
            }
            if (pinDept.Checked == false)
            {
                comboDept.SelectedValue = 0;
                comboDept.Enabled = true;
            }
            if (pinSL1.Checked == false)
            {  
                comboSL1.SelectedValue = 0;
                comboSL1.Enabled = true;
            }
            if (pinSL2.Checked == false)
            {
                comboSL2.SelectedValue = 0;
                comboSL2.Enabled = true;
            }
            if (pinSL3.Checked == false)
            {
                comboSL3.SelectedValue = 0;
                comboSL3.Enabled = true;
            }

            comboAccount.SelectedValue = 0;
            comboBudgetACTYPE.SelectedValue = 0;
            comboAccount.Enabled = true;
            txtBECY.Text = "";
            txtRBECY.Text = "";
            txtBENY.Text = "";
            retrievedForUpdate = false;
            queryMode = false;
            budgetWithAccountsBindingSource.Filter = "";
        }

        //Set Locks on Keys
        private void LockKeys()
        {
            comboFY.Enabled = false;
            comboDept.Enabled = false;
            comboSL1.Enabled = false;
            comboSL2.Enabled = false;
            comboSL3.Enabled = false;
        }    

        //Validate Controls
        private bool validateRecord()
        {
            if (comboBudgetACTYPE.Text.Equals("Virtual"))
            {
                return true;
            }
            else
            {
                bool validationResult = true;
                string validationMessage = "";

                if (Convert.ToString(comboFY.SelectedValue) == "0")
                {
                    validationMessage = "Please Select Financial Year\n";
                    validationResult = false;
                }
                if (Convert.ToString(comboDept.SelectedValue) == "0")
                {
                    validationMessage = "Please Select Departent Name\n";
                    validationResult = false;
                }
                if (Convert.ToString(comboSL1.SelectedValue) == "0")
                {
                    validationMessage = "Please Select SL1 Name\n";
                    validationResult = false;
                }
                if (Convert.ToString(comboSL2.SelectedValue) == "0")
                {
                    validationMessage += "Please Select SL2 Name\n";
                    validationResult = false;
                }
                if (Convert.ToString(comboSL3.SelectedValue) == "0")
                {
                    validationMessage += "Please Select SL3 Name\n";
                    validationResult = false;
                }
                if (txtBECY.Text.Length == 0)
                {
                    validationMessage += "Please provide value for Current Year's Budget Estimate\n";
                    validationResult = false;
                }
                if (txtRBECY.Text.Length == 0)
                {
                    validationMessage += "Please provide value for Current Year's Revised Budget Estimate\n";
                    validationResult = false;
                }
                if (txtBENY.Text.Length == 0)
                {
                    validationMessage += "Please provide value for Next Year's Budget Estimate\n";
                    validationResult = false;
                }
                if (validationResult == false)
                {
                    MessageBox.Show(validationMessage, "Account Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                    return true;
            }
        }
        
        //Filter entries for comboSL2 based on Selection of comboSL1
        private void comboSL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareSL2Combo(Convert.ToString(comboSL1.SelectedValue));
        }

        //Filter entries for comboSL2 based on Selection of comboSL1
        private void comboSL2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareSL3Combo(Convert.ToString(comboSL2.SelectedValue));
        }

        //Filter entries for comboSL2 based on Selection of comboSL1
        private void comboSL3_SelectedIndexChanged(object sender, EventArgs e)
        {        
            if (!(comboBudgetACTYPE.SelectedIndex == 2))
            {
                PrepareAccountsCombo(Convert.ToString(comboSL3.SelectedValue));
            }
        }

        //Execute Form Query
        private void btnQuery_Click(object sender, EventArgs e)
        {
            //If Query Record Mode == false Enter Query Mode
            if (queryMode == false)
            {
                //Disable Coomand Buttons
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                //Rename Query to Get Records
                btnQuery.Text = "Get Records";

                //Set Query Mode to True
                queryMode = true;

            }
            //Else Apply Filter on DGV ans Sow record
            else
            {
                StringBuilder SearchStatement = new StringBuilder();

                SearchStatement.Clear();
                if (Convert.ToInt32(comboFY.SelectedValue) > 0)
                {
                    SearchStatement.Append("PKFYID = " + Convert.ToInt32(comboFY.SelectedValue));
                }
                if (Convert.ToInt32(comboDept.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("DeptId = " + Convert.ToInt32(comboDept.SelectedValue));
                }

                if (Convert.ToInt32(comboSL1.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("SL1ID = " + Convert.ToInt32(comboSL1.SelectedValue));
                }
                if (Convert.ToInt32(comboSL2.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("PKSL2 = " + Convert.ToInt32(comboSL2.SelectedValue));
                }
                if (Convert.ToInt32(comboSL3.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("FKSL3ID = " + Convert.ToInt32(comboSL3.SelectedValue));
                }
                if (Convert.ToInt32(comboAccount.SelectedValue) > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("PKACID = " + Convert.ToInt32(comboAccount.SelectedValue));

                }
                if (txtBECY.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("BECY = " + txtBECY.Text);
                }
                if (txtRBECY.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("RBECY = " + txtRBECY.Text);
                }
                if (txtBENY.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("BENY = " + txtBENY.Text);
                }

                try
                {
                    if (SearchStatement.ToString().Length > 0)
                    {
                        budgetWithAccountsBindingSource.Filter = SearchStatement.ToString();
                    }
                    else
                        MessageBox.Show("Nothing to Quyery. Please select/set values for query in the form", "Query paramters not set", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Set QueryMode to False and Restore Button Caption to Query 
                    queryMode = false;
                    btnQuery.Text = "Query";
                    //Enable Coomand Buttons
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClear.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        //Close the Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //UnPinControls
        private void UnpinControls()
        {
            pinFY.Checked = false;
            pinDept.Checked = false;
            pinSL1.Checked = false;
            pinSL2.Checked = false;
            pinSL3.Checked = false;

        }

        //Pin Financial Year
        private void pinFY_CheckedChanged(object sender, EventArgs e)
        {
            if (pinFY.Checked == true)
            {
                pinFY.BackColor = Color.DarkOrange;
                pinFY.Text = "U";
            }
            else
            {
                pinFY.BackColor = Color.Bisque;
                pinFY.Text = "P";
            }
        }

        //Pin Dept
        private void pinDept_CheckedChanged(object sender, EventArgs e)
        {
            if (pinDept.Checked == true)
            {
                pinDept.BackColor = Color.DarkOrange;
                pinDept.Text = "U";
            }
            else
            {
                pinDept.BackColor = Color.Bisque;
                pinDept.Text = "P";
            }
        }

        //Pin SL1
        private void pinSL1_CheckedChanged(object sender, EventArgs e)
        {
            if (pinSL1.Checked == true)
            {
                pinSL1.BackColor = Color.DarkOrange;
                pinSL1.Text = "U";
            }
            else
            {
                pinSL1.BackColor = Color.Bisque;
                pinSL1.Text = "P";
            }
        }

        //Pin SL2
        private void pinSL2_CheckedChanged(object sender, EventArgs e)
        {
            if (pinSL2.Checked == true)
            {
                pinSL2.BackColor = Color.DarkOrange;
                pinSL2.Text = "U";
            }
            else
            {
                pinSL2.BackColor = Color.Bisque;
                pinSL2.Text = "P";
            }
        }

        //Pin SL3
        private void pinSL3_CheckedChanged(object sender, EventArgs e)
        {
            if (pinSL3.Checked == true)
            {
                pinSL3.BackColor = Color.DarkOrange;
                pinSL3.Text = "U";
            }
            else
            {
                pinSL3.BackColor = Color.Bisque;
                pinSL3.Text = "P";
            }
        }

        //Prevent Non-Numeric Values for CYBE
        private void txtBECY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == 8)))
            {
                e.Handled = true;
            }
        }

        //Prevent Non-Numeric Values for CYRBE
        private void txtRBECY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == 8)))
            {
                e.Handled = true;
            }
        }

        //Prevent Non-Numeric Values for BENY
        private void txtBENY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (e.KeyChar == 8)))
            {
                e.Handled = true;
            }
        }

        //Name Search Form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder SearchStatement = new StringBuilder();

            SearchStatement.Clear();
            if (txtSL1Search.Text.Length > 0)
            {
                SearchStatement.Append(" SL1Name like '%" + txtSL1Search.Text + "%'");
            }
            if (txtSL2Search.Text.Length > 0)
            {
                if (SearchStatement.Length > 0)
                {
                    SearchStatement.Append(" and ");
                }
                SearchStatement.Append(" SL2Name like '%" + txtSL2Search.Text + "%'");
            }
            if (txtSL3Search.Text.Length > 0)
            {
                if (SearchStatement.Length > 0)
                {
                    SearchStatement.Append(" and ");
                }
                SearchStatement.Append(" SL3Name like '%" + txtSL3Search.Text + "%'");
            }
            if (txtAccountNameSearch.Text.Length > 0)
            {
                if (SearchStatement.Length > 0)
                {
                    SearchStatement.Append(" and ");
                }
                SearchStatement.Append(" AccountName like '%" + txtAccountNameSearch.Text + "%'");
            }
            if (txtDeptSearch.Text.Length > 0)
            {
                if (SearchStatement.Length > 0)
                {
                    SearchStatement.Append(" and ");
                }
                SearchStatement.Append(" DeptName like '%" + txtDeptSearch.Text + "%'");
            }

            try
            {
                if (SearchStatement.ToString().Length > 0)
                {
                    budgetWithAccountsBindingSource3.Filter = SearchStatement.ToString();
                }
                else
                    MessageBox.Show("Nothing to Quyery. Please select/set values for query in the form", "Query paramters not set", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check the action permission
            string CanDelete = "CanDelete";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanDelete, formName))
            {
                // write the code for delete
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Clear Name Search Form
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSL1Search.Text = "";
            txtSL2Search.Text = "";
            txtSL3Search.Text = "";
            txtAccountNameSearch.Text = "";
            txtDeptSearch.Text = "";
            budgetWithAccountsBindingSource3.Filter = "";
        }
        // prepare action add, update, delete
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVBudgetAccounts, "BudgetAccount");
            objectsupport.ShowDialog();
        }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVBudgetAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //D.FYName(0), DEPNAME(1), SL3Code(2), AccountName(3), BECY(4), RBECY(5), BENY(6), SL1Name (7), 
                //SL2Name (8), SL3Name (9), SL1ID (10), PKSL2 (11), FKSL3ID (12), C.PKDEPID (13), D.PKFYID (14), ACID (15), PKBUDGETID (16)

                comboFY.SelectedValue = Convert.ToInt32(DGVBudgetAccounts.Rows[e.RowIndex].Cells[14].FormattedValue.ToString());
                comboDept.SelectedValue = Convert.ToInt32(DGVBudgetAccounts.Rows[e.RowIndex].Cells[13].FormattedValue.ToString());
                comboSL1.SelectedValue = Convert.ToInt32(DGVBudgetAccounts.Rows[e.RowIndex].Cells[10].FormattedValue.ToString());
                comboSL2.SelectedValue = Convert.ToInt32(DGVBudgetAccounts.Rows[e.RowIndex].Cells[11].FormattedValue.ToString());
                comboSL3.SelectedValue = Convert.ToInt32(DGVBudgetAccounts.Rows[e.RowIndex].Cells[12].FormattedValue.ToString());
                comboAccount.SelectedValue = Convert.ToInt32(DGVBudgetAccounts.Rows[e.RowIndex].Cells[15].FormattedValue.ToString());

                txtBECY.Text = DGVBudgetAccounts.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtRBECY.Text = DGVBudgetAccounts.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtBENY.Text = DGVBudgetAccounts.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                txtPKBudgetID.Text = DGVBudgetAccounts.Rows[e.RowIndex].Cells[16].FormattedValue.ToString();

                if (DGVBudgetAccounts.Rows[e.RowIndex].Cells[7].FormattedValue.ToString() == "DUMMY SL1")
                {
                    btnMapVirtualAccount.Enabled = true;
                }
                else
                    btnMapVirtualAccount.Enabled = false;
                retrievedForUpdate = true;
                LockKeys();
            }
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            ImportHelp objectimport = new ImportHelp(userId);
            objectimport.ShowDialog();
        }

        private void comboBudgetACTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBudgetACTYPE.SelectedIndex == 2)
            {
                PrepareAccountTypecombo();
                comboAccount.SelectedIndex = 0;
                comboSL1.SelectedIndex = 0;
                comboSL2.SelectedIndex = 0;
                comboSL3.SelectedIndex = 0;
                comboSL1.Enabled = false;
                comboSL2.Enabled = false;
                comboSL3.Enabled = false;
            }
            else
            {
                PrepareAccountsCombo(Convert.ToString(comboSL3.SelectedValue));
                comboSL1.Enabled = true;
                comboSL2.Enabled = true;
                comboSL3.Enabled = true;
                comboAccount.SelectedIndex = 0;
                comboSL1.SelectedIndex = 0;
                comboSL2.SelectedIndex = 0;
                comboSL3.SelectedIndex = 0;
            }
        }

        private void PrepareAccountTypecombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select Distinct VHID, VHNAME from Finance.dbo.VHMst where isActive = 1 order by 2";
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
                comboAccount.DisplayMember = "ListItemDesc"; // will display Name property
                comboAccount.ValueMember = "ListItemID"; // will select Value property
                comboAccount.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label16.Text = DateTime.Now.ToString();
        }

        private void comboAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMapVirtualAccount_Click(object sender, EventArgs e)
        {
            frmVirtualAccount objfrmVirtualAccount = new frmVirtualAccount();
            objfrmVirtualAccount.parentACID = Convert.ToInt32(comboAccount.SelectedValue);
            objfrmVirtualAccount.parentAccount = comboAccount.Text;
            objfrmVirtualAccount.DEPID = Convert.ToInt32(comboDept.SelectedValue);
            objfrmVirtualAccount.DepName = comboDept.Text;
            objfrmVirtualAccount.ShowDialog();

        }
        // prepare action add, update and delete
        private void priviletesaction()
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


