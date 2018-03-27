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
    public partial class frmVirtualAccount : Form
    {
        bool retrievedForUpdate;
        public int parentACID;
        public int DEPID;
        public string DepName;
        public string parentAccount;

        public frmVirtualAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet.VirtualAccoountsView' table. You can move, or remove it, as needed.

            this.virtualAccoountsViewBindingSource.Filter = " FKDEPID = " + DEPID;
            this.virtualAccoountsViewTableAdapter.Fill(this.financeDataSet.VirtualAccoountsView);

            txtDepID.Text = DEPID.ToString();
            txtDepName.Text = DepName;
            txtparentAccount.Text = parentAccount;
            txtPKACID.Text = parentACID.ToString();
            txtDepID.Enabled = false;
            txtDepName.Enabled = false;
            txtparentAccount.Enabled = false;
            txtPKACID.Enabled = false;
            // TODO: This line of code loads data into the 'financeDataSet.ACCOUNTSVIEW' table. You can move, or remove it, as needed.
            this.virtualAccoountsViewTableAdapter.Fill(this.financeDataSet.VirtualAccoountsView);
            //Prepare SL1, SL2 and SL3 Combos
            PrepareSL1Combo();
            PrepareSL2Combo("0");
            PrepareSL3Combo("0");

            PrepareAccountCombo("0");           
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
                    string insertCommand = "Insert into VirtualAccounts (FKDEPID, FKPARENETACID, FKCHILDACID, AccountUpdateBy) values " +
                                            "(@FKDEPID, @FKPARENETACID, @FKCHILDACID, @AccountUpdateBy)";
                    SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                    objInsertCommand.Parameters.AddWithValue("@FKDEPID", txtDepID.Text);
                    objInsertCommand.Parameters.AddWithValue("@FKPARENETACID", txtPKACID.Text);
                    objInsertCommand.Parameters.AddWithValue("@FKCHILDACID", comboAccount.SelectedValue);
                    objInsertCommand.Parameters.AddWithValue("@AccountUpdateBy", "User");
                    try
                    {
                        objSqlConnection.Open();
                        objInsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("PK_VirtualAccounts"))
                        {
                            MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comboAccount.Focus();
                        }
                        else if (ex.Message.Contains("Unique_Parent_Child"))
                        {
                            MessageBox.Show("This Account is already mapped. ", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comboAccount.Focus();
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.virtualAccoountsViewTableAdapter.Fill(this.financeDataSet.VirtualAccoountsView);
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
                    string updateCommand = "Update VirtualAccounts set FKCHILDACID = @FKCHILDACID, " +
                                            "AccountUpdateBy = @AccountUpdateBy where PKVACID = @PKVACID";
                    SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                    objUpdateCommand.Parameters.AddWithValue("@FKCHILDACID", comboAccount.SelectedValue);
                    objUpdateCommand.Parameters.AddWithValue("@AccountUpdateBy", "User");
                    objUpdateCommand.Parameters.AddWithValue("@PKVACID", txtPKVACID.Text);

                    try
                    {
                        objSqlConnection.Open();
                        objUpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("PK_VirtualAccounts"))
                        {
                            MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comboAccount.Focus();
                        }
                        else if (ex.Message.Contains("Unique_Parent_Child"))
                        {
                            MessageBox.Show("This Account is already mapped. ", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comboAccount.Focus();
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.virtualAccoountsViewTableAdapter.Fill(this.financeDataSet.VirtualAccoountsView);
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
                string deleteCommand = "Delete from Finance.dbo.VirtualAccounts where PKVACID = @PKVACID;";
                SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                objDeleteCommand.Parameters.AddWithValue("@PKVACID", txtPKVACID.Text);

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
                this.virtualAccoountsViewTableAdapter.Fill(this.financeDataSet.VirtualAccoountsView);
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
                                    "where A.SL1ID = B.SL1ID AND A.SL1Name <> 'DUMMY SL1' order by 2;";
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
            string selectCommand = "Select PKSL3, SL3Name from Finance.dbo.SL3 where FKSL2ID = " + fkSL2 + " order by 2";
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

        //Prepare Account Combo
        private void PrepareAccountCombo(string FKSL3ID)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select PKACID, AccountName from Finance.dbo.Accounts where FKSL3ID = " + FKSL3ID + "order by 2";
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
                this.virtualAccoountsViewTableAdapter.Fill(this.financeDataSet.VirtualAccoountsView);

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
            virtualAccoountsViewBindingSource.Filter = "";
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
            comboSL1.Enabled = true;
            comboSL2.Enabled = true;
            comboSL3.Enabled = true;
            retrievedForUpdate = false;
        }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtparentAccount.Text = DGVAccounts.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtPKACID.Text = DGVAccounts.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtPKVACID.Text = DGVAccounts.Rows[e.RowIndex].Cells[11].FormattedValue.ToString();
                comboSL1.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                comboSL2.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());
                comboSL3.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[9].FormattedValue.ToString());
                comboAccount.SelectedValue = Convert.ToInt32(DGVAccounts.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
                retrievedForUpdate = true;
            }
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
            if (Convert.ToString(comboAccount.SelectedValue) == "0")
            {
                validationMessage += "Please Select SL3 Name\n";
                validationResult = false;
            }

            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Virtual Account Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //Filter entries for Acounts based on Selection of comboSL3
        private void comboSL3_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareAccountCombo(Convert.ToString(comboSL3.SelectedValue));
        }


        //Close the Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion

    }
}
