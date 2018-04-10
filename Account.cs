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
    public partial class frmAccount : Form
    {
        bool retrievedForUpdate;
        private int userId, deptId, roleId;
        private string formName;
        public frmAccount(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet.ACCOUNTSVIEW' table. You can move, or remove it, as needed.
            this.financeDataSet.EnforceConstraints = false;
            this.accountsViewTableAdapter.Fill(this.financeDataSet.AccountsView);
            //Prepare SL1, SL2 and SL3 Combos
            PrepareSL1Combo();
            PrepareSL2Combo("0");
            PrepareSL3Combo("0");
            PrepareAccountType();
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
            PrepareBankAccountCombo();
            retrievedForUpdate = false;
        }
        //DML Region
        #region

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
                        string insertCommand = "Insert into Accounts (FKSL3ID, AccountType, AccountName, FKBankAccountID, AcOrder, AcActive) values " +
                                                "(@FKSL3ID, @AccountType, @AccountName, @FKBankAccountID, @AcOrder, @AcActive)";
                        SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objInsertCommand.Parameters.AddWithValue("@FKSL3ID", comboSL3.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@AccountType", comboAccountType.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
                        objInsertCommand.Parameters.AddWithValue("@AcOrder", txtAccountOrder.Text);
                        if (Convert.ToInt32(comboBankAccount.SelectedValue) == 0)
                            objInsertCommand.Parameters.AddWithValue("@FKBankAccountID", DBNull.Value);
                        else
                            objInsertCommand.Parameters.AddWithValue("@FKBankAccountID", comboBankAccount.SelectedValue);

                        if (radioBtnAccountActive.Checked == true)
                            objInsertCommand.Parameters.AddWithValue("@AcActive", "1");
                        else
                            objInsertCommand.Parameters.AddWithValue("@AcActive", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objInsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_Accounts"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtAccountName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGV 
                        this.accountsViewTableAdapter.Fill(this.financeDataSet.AccountsView);
                    }
                }
        }

        //Update Record
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
                        string updateCommand = "Update Accounts set AccountType = @AccountType, AccountName = @AccountName, AcActive = @AcActive, AcOrder = @AcOrder, " +
                                               "FKBankAccountID = @FKBankAccountID where PKACID = @PKACID";
                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@AccountType ", comboAccountType.SelectedValue);
                        objUpdateCommand.Parameters.AddWithValue("@AccountName", txtAccountName.Text);
                        objUpdateCommand.Parameters.AddWithValue("@AcOrder ", txtAccountOrder.Text);
                        objUpdateCommand.Parameters.AddWithValue("@PKACID", txtPKACID.Text);
                        if (Convert.ToInt32(comboBankAccount.SelectedValue) == 0)
                            objUpdateCommand.Parameters.AddWithValue("@FKBankAccountID", DBNull.Value);
                        else
                            objUpdateCommand.Parameters.AddWithValue("@FKBankAccountID", comboBankAccount.SelectedValue);

                        if (radioBtnAccountActive.Checked == true)
                            objUpdateCommand.Parameters.AddWithValue("@AcActive", "1");
                        else
                            objUpdateCommand.Parameters.AddWithValue("@AcActive", "0");

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
                                txtAccountName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGV 
                        this.accountsViewTableAdapter.Fill(this.financeDataSet.AccountsView);
                    }
                }
        }

        //Delete Record
        private void btnDelete_Click(object sender, EventArgs e)
        {
                DialogResult diagResult;
                diagResult = MessageBox.Show("Do you want to delete Record?", "Record Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (diagResult == DialogResult.Yes)
                {
                    //Connection String
                    string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection objSqlConnection = new SqlConnection(cs);

                    //Prepare Delete String
                    string deleteCommand = "Delete from Finance.dbo.Accounts where PKACID = @PKACID;";
                    SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                    objDeleteCommand.Parameters.AddWithValue("@PKACID", txtPKACID.Text);

                    try
                    {
                        objSqlConnection.Open();
                        objDeleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The following error occured: " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.accountsViewTableAdapter.Fill(this.financeDataSet.AccountsView);
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
            string selectCommand = "Select SL1ID, SL1Name from Finance.dbo.SL1 order by 2;";
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
            string selectCommand = "Select PKSL2, SL2Name from Finance.dbo.SL2 where SL1ID = " + fkSL1 + "order by 2";
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
            string selectCommand = "Select PKSL3, SL3Name from Finance.dbo.SL3 where FKSL2ID = " + fkSL2 + "order by 2";
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

        //Prepare Account Type Combo
        private void PrepareAccountType()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));
            objLOVClass.Add(new LOV(1, "Normal Account Type"));
            objLOVClass.Add(new LOV(2, "Composite Account Type"));

            comboAccountType.DisplayMember = "ListItemDesc"; // will display Name property
            comboAccountType.ValueMember = "ListItemID"; // will select Value property
            comboAccountType.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
        }

        //Prepare Bank Account Combo
        private void PrepareBankAccountCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKBANKACC, [BankShortName] + ' (' + SUBSTRING([AccountType],1,1) + '):' + [AccountNumber] FROM [Finance].[dbo].[BankAccountDetails] Order by 1";
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
                comboBankAccount.DisplayMember = "ListItemDesc"; // will display Name property
                comboBankAccount.ValueMember = "ListItemID"; // will select Value property
                comboBankAccount.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        //Seacrh Box Fuctionality
        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder SearchStatement = new StringBuilder();
            try
            {
                SearchStatement.Clear();
                if(txtSL1Seacrh.Text.Length > 0)
                {
                    SearchStatement.Append("SL1Name like '%" + txtSL1Seacrh.Text + "%'");
                }
                if (txtSL2Search.Text.Length > 0)
                {
                    if(SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("SL2Name like '%" + txtSL2Search.Text + "%'");
                }
                if (txtSL3Search.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("SL3Name like '%" + txtSL3Search.Text + "%'");
                }
                if (txtBankAccSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("(BankName like '%" + txtBankAccSearch.Text + "%'  or AccountNumber like '%" + txtBankAccSearch.Text + "%') ");

                }
                if (txtAccountNameSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("AccountName like '%" + txtAccountNameSearch.Text + "%'");
                }


                //Refresh DGV 
                accountsViewBindingSource.Filter = SearchStatement.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        //Clear Filter
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSL1Seacrh.Text = "";
            txtSL2Search.Text = "";
            txtSL3Search.Text = "";
            txtBankAccSearch.Text = "";
            txtAccountNameSearch.Text = "";
            accountsViewBindingSource.Filter = "";
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
            comboSL1.SelectedValue = 0;
            comboSL2.SelectedValue = 0;
            comboSL3.SelectedValue = 0;
            comboAccountType.SelectedValue = 0;
            comboBankAccount.SelectedValue = 0;
            comboSL1.Enabled = true;
            comboSL2.Enabled = true;
            comboSL3.Enabled = true;
            txtAccountName.Text = "";
            txtAccountOrder.Text = "";
            txtAccountName.Text = "";
            radioBtnAccountActive.Checked = false;
            radioBtnAccountInActive.Checked = false;
            retrievedForUpdate = false;
        }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboSL1.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[11].FormattedValue.ToString());
                comboSL2.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[12].FormattedValue.ToString());
                if(DGVAccounts.Rows[e.RowIndex].Cells[13].FormattedValue.ToString() == "")
                {
                    comboBankAccount.SelectedValue = 0;
                    comboBankAccount.Enabled = false;
                }
                else
                {                
                    comboBankAccount.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[13].FormattedValue.ToString());
                    comboBankAccount.Enabled = true;
                }
                comboSL3.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());

                txtAccountName.Text = DGVAccounts.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtAccountOrder.Text = DGVAccounts.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                if (Convert.ToBoolean(DGVAccounts.Rows[e.RowIndex].Cells[7].FormattedValue.ToString()) == true)
                    radioBtnAccountActive.Checked = true;
                else
                    radioBtnAccountInActive.Checked = true;
                txtPKACID.Text = DGVAccounts.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                comboAccountType.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[14].FormattedValue.ToString());

                retrievedForUpdate = true;
                LockKeys();
            }
        }

        private void LockKeys()
        {
            comboSL1.Enabled = false;
            comboSL2.Enabled = false;
            comboSL3.Enabled = false;
        }

        //Validate Controls
        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";
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

            if (txtAccountName.Text.Length == 0)
            {
                validationMessage += "Please provide value for Account Name\n";
                validationResult = false;
            }
            if (txtAccountOrder.Text.Length == 0)
            {
                validationMessage += "Please provide value for Account Order\n";
                validationResult = false;
            }
            if (radioBtnAccountActive.Checked == false && radioBtnAccountInActive.Checked == false)
            {
                validationMessage += "Please provide value for Account Active Status\n";
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

        private void btnPrintRecord_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVAccounts, "Account");
            objectsupport.ShowDialog();
        }
        //Close the Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //prepare the action add, delete, update and print
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

        #endregion


    }
}
