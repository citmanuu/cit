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
    public partial class frmBank : Form
    {
        bool retrievedForUpdateOfBank;
        bool retrievedForUpdateOfAccount;
        StringBuilder SearchString = new StringBuilder();
        private int userId, deptId, roleId;
        string formName;

        public frmBank(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            retrievedForUpdateOfBank = false;
            retrievedForUpdateOfAccount = false;
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void frmBank_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'financeDataSet.BankMaster' table. You can move, or remove it, as needed.
            this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);

            //Prepare Filter for BankAccountDetails
            PrepareFilterForBankAccountDetails(0);

            // TODO: This line of code loads data into the 'financeDataSet.BankAccountDetails' table. You can move, or remove it, as needed.
            this.bankAccountDetailsTableAdapter.Fill(this.financeDataSet.BankAccountDetails);

            //Fill Account Tpes Combo
            PrepareAccountTypesCombo();

            //Disable AccountTypeCombo
            comboAcType.Enabled = false;

            // prepare action add, update, delete, print
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
        }


        #region 
        //Add Bank Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
                //If Form Controls are validated proceed to add record
                if (validateRecord())
                {
                    //Check if we are not Updating Record
                    if (!retrievedForUpdateOfBank)
                    {

                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string insertCommand = "Insert into bankMaster (BankName) values (@BankName, @BankShortName)";
                        SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objInsertCommand.Parameters.AddWithValue("@BankName", txtBankName.Text);
                        objInsertCommand.Parameters.AddWithValue("@BankShortName", txtBankShortName.Text);
                        try
                        {
                            objSqlConnection.Open();
                            objInsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_BankMaster"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            if (ex.Message.Contains("Unique_BankName"))
                            {
                                MessageBox.Show("Bank Name already exists", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGVBank
                        this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);
                    }
                }
        }

        //Add Bank Account Record
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
                //If Form Controls are validated proceed to add record
                if (validateAccountRecord())
                {
                    //Check if we are not Updating Record
                    if (!retrievedForUpdateOfAccount)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string insertCommand = "Insert into BankAccount (FKAccountType, AccountNumber, FKBankID) values " +
                                                "(@FKAccountType, @AccountNumber, @FKBankID)";
                        SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objInsertCommand.Parameters.AddWithValue("@FKBankID", txtBankID.Text);
                        objInsertCommand.Parameters.AddWithValue("@AccountNumber", txtAccountNo.Text);
                        objInsertCommand.Parameters.AddWithValue("@FKAccountType", comboAcType.SelectedValue);

                        try
                        {
                            objSqlConnection.Open();
                            objInsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_BankAccount"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            if (ex.Message.Contains("Unique_Bank_AccountNo"))
                            {
                                MessageBox.Show("Bank Account already exists", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGVBank
                        this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);
                        //Refresh DGVBankAccounts
                        this.bankAccountDetailsTableAdapter.Fill(this.financeDataSet.BankAccountDetails);

                    }
                }
        }

        //Update Bank Record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
               //If Form Controls are validated proceed to add record
                if (validateRecord())
                {
                    //Check if we are not Updating Record
                    if (retrievedForUpdateOfBank)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string updateCommand = "Update BankMaster set BankName = @BankName, BankShortName = @BankShortName where BankID = @BankID";

                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@BankID", txtBankID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@BankName", txtBankName.Text);
                        objUpdateCommand.Parameters.AddWithValue("@BankShortName", txtBankShortName.Text);

                        try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Record Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_BankMaster"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            if (ex.Message.Contains("Unique_BankName"))
                            {
                                MessageBox.Show("Bank Name must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            if (ex.Message.Contains("Unique_BankShortName"))
                            {
                                MessageBox.Show("Bank Short Name must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGVBank
                        this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);
                        ClearTemplate();
                    }
                }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
                //If Form Controls are validated proceed to add record
                if (validateAccountRecord())
                {
                    //Check if we are not Updating Record
                    if (retrievedForUpdateOfAccount)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string updateCommand = "Update BankAccount set FKAccountType = @FKAccountType, AccountNumber = @AccountNumber " +
                                                "where PKBANKACC = @PKBANKACC";

                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@FKAccountType", comboAcType.SelectedValue);
                        objUpdateCommand.Parameters.AddWithValue("@AccountNumber", txtAccountNo.Text);
                        objUpdateCommand.Parameters.AddWithValue("@PKBANKACC", txtPKBANKACC.Text);


                        try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Record Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_BankAccount"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            if (ex.Message.Contains("Unique_Bank_AccountNo"))
                            {
                                MessageBox.Show("Bank Account No and Type already exist.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGVBank
                        //this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);
                        //Refresh DGVBankAccounts
                        this.bankAccountDetailsTableAdapter.Fill(this.financeDataSet.BankAccountDetails);
                        ClearTemplate();
                    }
                }
        }
        
        
         //Delete Bank Record
        private void btnDelete_Click(object sender, EventArgs e)
        {
                DialogResult diagResult;
                if (txtBankID.Text == "")
                {
                    MessageBox.Show("Please select a Record!", "Record Deletion Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    diagResult = MessageBox.Show("Do you want to delete Record?", "Record Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (diagResult == DialogResult.Yes)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);

                        //Prepare Delete String
                        string deleteCommand = "Delete from Finance.dbo.BankMaster where BankID = @BankID;";
                        SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                        objDeleteCommand.Parameters.AddWithValue("@BankID", txtBankID.Text);

                        try
                        {
                            objSqlConnection.Open();
                            objDeleteCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("FK_BankAccount_BankMaster"))
                            {
                                MessageBox.Show("Bank Account(s) exist(s) for the the Bank. Cannot Delete Recotrd!! ", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured: " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGVBank
                        this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);
                        ClearTemplate();
                    }
                }
        }

        //Delete Bank Account Record
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
                DialogResult diagResult;
                if (txtBankNameForAcc.Text == "")
                {
                    MessageBox.Show("Please select a Record!", "Record Deletion Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    diagResult = MessageBox.Show("Do you want to delete Record?", "Record Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (diagResult == DialogResult.Yes)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);

                        //Prepare Delete String
                        string deleteCommand = "Delete from Finance.dbo.BankAccount where PKBANKACC = @PKBANKACC;";
                        SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                        objDeleteCommand.Parameters.AddWithValue("@PKBANKACC", txtPKBANKACC.Text);

                        try
                        {
                            objSqlConnection.Open();
                            objDeleteCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("FK_BankAccount_BankMaster"))
                            {
                                MessageBox.Show("Bank Account(s) exist(s) for the the Bank. Cannot Delete Recotrd!! ", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBankName.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured: " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGVBank
                        //this.bankMasterTableAdapter.Fill(this.financeDataSet.BankMaster);
                        //Refresh DGVBankAccounts
                        this.bankAccountDetailsTableAdapter.Fill(this.financeDataSet.BankAccountDetails);

                        ClearTemplate();
                    }
                }
        }

        //Prepare AccountTypes LOV
        private void PrepareAccountTypesCombo()
        { 
            var objLOV = new List<LOV>();
            objLOV.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select PKGEM, GEMDESC from Finance.dbo.GENMST where GEMID = 1 order by 2;";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOV.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboAcType.DisplayMember = "ListItemDesc"; // will display Name property
                comboAcType.ValueMember = "ListItemID"; // will select Value property
                comboAcType.DataSource = objLOV; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured: " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        #endregion


        //Support Functions/Methods Region
        #region

        private void btnClear_Click(object sender, EventArgs e)
            {
                ClearTemplate();
            }

        //Clear Template Method
        private void ClearTemplate()
            {
            txtBankID.Text = "";
            txtBankName.Text = "";
            txtBankShortName.Text = "";
            txtAccountNo.Text = "";
            txtBankNameForAcc.Text = "";
            comboAcType.SelectedValue = 0;

            comboAcType.Enabled = false;
            txtAccountNo.Enabled = false;
            txtBankID.Enabled = false;
            txtBankName.Enabled = true;

            retrievedForUpdateOfAccount = false;
            retrievedForUpdateOfBank = false;
        }

         //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVBanks_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    txtBankID.Text = DGVBanks.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtBankShortName.Text = DGVBanks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtBankName.Text = DGVBanks.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtBankNameForAcc.Text = DGVBanks.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtBankShortNameRO.Text = DGVBanks.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();


                retrievedForUpdateOfBank = true;
                    PrepareFilterForBankAccountDetails(e.RowIndex);
                    LockKeys();
                }
            }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVBankAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBankNameForAcc.Text = DGVBankAccounts.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                comboAcType.SelectedValue = Convert.ToInt32(DGVBankAccounts.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                txtAccountNo.Text = DGVBankAccounts.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtPKBANKACC.Text = DGVBankAccounts.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                retrievedForUpdateOfAccount = true;
                //PrepareFilterForBankAccountDetails(e.RowIndex);
                LockKeys();
            }

        }

        //Lock Fields Before Edit
        private void LockKeys()
        {
            txtBankID.Enabled = false;
            comboAcType.Enabled = true;
            txtAccountNo.Enabled = true;
        }

        //Validate Controls
        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (txtBankName.Text.Length == 0)
            {
                validationMessage += "Please provide value for Bank Name\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Bank Record Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        
        private bool validateAccountRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (txtBankNameForAcc.Text.Length == 0)
            {
                validationMessage += "Please Select a Bank from upper grid.\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Bank Account Record Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        //Prevent Non-Numeric Values for SL1Order
        /*
        private void txtSL2Order_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
            }
            else
            {
                e.Handled = true;
            }

        }
        */

        //Clear Form and Adjust Locks on Controls
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        //Close Form
        private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        private void button4_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrint objectsupport = new frmPrint(DGVBanks, "Bank");
            objectsupport.ShowDialog();
        }

        private void btnPrintAccount_Click(object sender, EventArgs e)
        {
            frmPrint objectsupport = new frmPrint(DGVBankAccounts, "BankAccounts");
            objectsupport.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Prepare Filter for Bank Accounts
        private void PrepareFilterForBankAccountDetails(int row)
        {
            try
            {
                SearchString.Clear();
                SearchString.Append("FKBankID = " + DGVBanks.Rows[row].Cells[0].FormattedValue.ToString());
                bankAccountDetailsBindingSource.Filter = SearchString.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // prepare action add, update, delete
        private void prepareaction()
        {
            string CanAdd = "CanAdd";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanAdd, formName))
            {
                btnAdd.Enabled = true;
                btnAddAccount.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnAddAccount.Enabled = false;
            }

            string CanUpdate = "CanUpdate";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanUpdate, formName))
            {
                btnUpdate.Enabled = true;
                btnUpdateAccount.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdateAccount.Enabled = false;
            }
            string CanDelete = "CanDelete";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanDelete, formName))
            {
                btnDelete.Enabled = true;
                btnDeleteAccount.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnDeleteAccount.Enabled = false;
            }
            string CanPrint = "CanPrint";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanPrint, formName))
            {
                btnPrint.Enabled = true;
                btnPrintAccount.Enabled = true;
            }
            else
            {
                btnPrintAccount.Enabled = false;
                btnPrint.Enabled = false;
            }
        }
        #endregion

    }
}
