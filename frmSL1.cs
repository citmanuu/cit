using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MANUUFinance
{
    public partial class frmSL1 : Form
    {
        bool retrievedForUpdate;
        private int userId, deptId, roleId;
        string formName;
        public frmSL1(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Prepare Combo for Showing Account Types
            PrepareAccountTypesCombo();
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
            retrievedForUpdate = false;

            // TODO: This line of code loads data into the 'financeDataSet.SL1' table. You can move, or remove it, as needed.
            this.sL1TableAdapter.Fill(this.financeDataSet.SL1);

        }

        #region //DML Procedures
        //Add Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (retrievedForUpdate == false && validateRecord() == true)
                {
                    if (txtSL1ID.Text.Length == 0)
                    {
                        //Set Values for SL1ID, SL1UCode, SL1Code
                        txtSL1ID.Text = Convert.ToString(Convert.ToInt32(GetMaxSL1ID()) + 1);

                        txtSL1Code.Text = "S" + ((Convert.ToInt32(txtSL1ID.Text) < 9) ? "0" + txtSL1ID.Text : txtSL1ID.Text);
                        txtSL1UCode.Text = ((Convert.ToInt32(txtSL1ID.Text) < 9) ? "0" + txtSL1ID.Text : txtSL1ID.Text);

                        radioBtnSL1Active.Checked = true;
                    }
                    //Check if Record is populated
                    if (txtSL1Name.Text.Length > 0)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string insertCommand = "Insert into SL1 (SL1Code, SL1Name, ScheduleID, SL1Active, SL1Order, GroupID, AcTypeID, DeptId) values " +
                                                "(@SL1Code, @SL1Name, @ScheduleID, @SL1Active, @SL1Order, @GroupID, @AcTypeID, @DeptId)";
                        SqlCommand objUpdateCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@SL1ID", txtSL1ID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL1Name", txtSL1Name.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL1Order", txtSL1Order.Text);
                        objUpdateCommand.Parameters.AddWithValue("@GroupID", txtGroupID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL1Code", txtSL1Code.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL1UC", txtSL1UCode.Text);
                        objUpdateCommand.Parameters.AddWithValue("@ScheduleID", txtScheduleID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@AcTypeID", comboAcType.SelectedValue);
                        objUpdateCommand.Parameters.AddWithValue("@DeptId", deptId);

                        if (radioBtnSL1Active.Checked == true)
                            objUpdateCommand.Parameters.AddWithValue("@SL1Active", "1");
                        else
                            objUpdateCommand.Parameters.AddWithValue("@SL1Active", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_SL1"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL1Name.Focus();
                            }
                            if (ex.Message.Contains("Unique_SL1Code"))
                            {
                                MessageBox.Show("SL1Code must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL1Code.Focus();
                            }
                            else if (ex.Message.Contains("Unique_SL1Name"))
                            {
                                MessageBox.Show("Schedule Name must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL1Name.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        this.sL1TableAdapter.Fill(this.financeDataSet.SL1);
                    }
                }
        }

        //Update record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                if (validateRecord())
                {
                    //Check if Record is populated
                    if (txtSL1ID.Text.Length > 0)
                    {
                        //Connection String
                        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                        //Instantiate SQL Connection
                        SqlConnection objSqlConnection = new SqlConnection(cs);
                        //Prepare Update String
                        string updateCommand = "Update SL1 set SL1Name = @SL1Name, SL1Active = @SL1Active, " +
                                               "SL1Order = @SL1Order, GroupID = @GroupID, AcTypeId = @AcTypeId where SL1ID = @SL1ID";
                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@SL1Name", txtSL1Name.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL1Order", txtSL1Order.Text);
                        objUpdateCommand.Parameters.AddWithValue("@GroupID", txtGroupID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL1ID", txtSL1ID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@AcTypeId", comboAcType.SelectedValue);
                        if (radioBtnSL1Active.Checked == true)
                            objUpdateCommand.Parameters.AddWithValue("@SL1Active", "1");
                        else
                            objUpdateCommand.Parameters.AddWithValue("@SL1Active", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            retrievedForUpdate = false;
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("Unique_SL1Name"))
                                MessageBox.Show("Schedule Name must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        this.sL1TableAdapter.Fill(this.financeDataSet.SL1);
                        ClearTemplate();
                    }
                    else
                    {
                        MessageBox.Show("Please select record from the Grid.", "Record not selected..", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    string deleteCommand = "Delete from Finance.dbo.SL1 where SL1ID = @SL1ID;";
                    SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                    objDeleteCommand.Parameters.AddWithValue("@SL1ID", txtSL1ID.Text);

                    try
                    {
                        objSqlConnection.Open();
                        objDeleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The following error occured (SL1->GetMaxSL1Code): " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    this.sL1TableAdapter.Fill(this.financeDataSet.SL1);
                }
        }


        //Prepare AccountTypes Combo
        private void PrepareAccountTypesCombo()
        {
            var acTypeRecord = new List<AcTypeClass>();
            acTypeRecord.Add(new AcTypeClass(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select * from Finance.dbo.AcTypes order by 2;";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    acTypeRecord.Add(new AcTypeClass(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboAcType.DisplayMember = "AcTypeName"; // will display Name property
                comboAcType.ValueMember = "AcTypeId"; // will select Value property
                comboAcType.DataSource = acTypeRecord; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured (SL1->GetMaxSL1Code): " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }


        #endregion

        #region 
        //Support Function
        private bool validateRecord()
        {
            if(Convert.ToString(comboAcType.SelectedValue) == "0")
            {
                MessageBox.Show("Please Select Account Type", "Account type Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
                
        }

        //Lock Keys for Update
        private void LockKeys()
        {
            txtSL1Code.Enabled = false;
            txtScheduleID.Enabled = false;
            txtSL1UCode.Enabled = false;
        }

        //Prevent Non-Numeric Values for SL1Order
        private void txtSL1Order_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
     
        //Generate New Value for Sl1ID and related Fields
        private string GetMaxSL1ID()
        {
            string MaxSL1ID = "";
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select MAX(SL1ID) from Finance.dbo.SL1;";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                MaxSL1ID = Convert.ToString(objSelectCommand.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured (SL1->GetMaxSL1Code): " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
            if (MaxSL1ID == "")
            {
                return "0";
            }
            else
                return MaxSL1ID;
        }

        //Get Record for Editing
        private void DGVSL1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSL1ID.Text = DGVSL1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtSL1Code.Text = DGVSL1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtSL1UCode.Text = DGVSL1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                comboAcType.SelectedValue = Convert.ToInt32(DGVSL1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                txtScheduleID.Text = DGVSL1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtSL1Name.Text = DGVSL1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtGroupID.Text = DGVSL1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                if (DGVSL1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString() == "1")
                    radioBtnSL1Active.Checked = true;
                else
                    radioBtnSL1InActive.Checked = true;
                txtSL1Order.Text = DGVSL1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                retrievedForUpdate = true;
                LockKeys();
            }
        }
        
        //Clear Controls
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        //Clear Template Method
        private void ClearTemplate()
        {
            txtSL1ID.Text = "";
            txtScheduleID.Text = "";
            txtSL1Code.Text = "";
            txtSL1Name.Text = "";
            txtGroupID.Text = "";
            txtSL1UCode.Text = "";
            txtGroupID.Text = "";
            txtSL1Order.Text = "";
            radioBtnSL1Active.Checked = false;
            radioBtnSL1InActive.Checked = false;
            comboAcType.SelectedValue = 0;
            txtSL1Code.Enabled = true;
            txtScheduleID.Enabled = true;
            retrievedForUpdate = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVSL1, "SL1");
            objectsupport.ShowDialog();
        }

        private void DGVSL1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // prepare the action add, update, delete
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
        //Close Form
        private void button1_Click(object sender, EventArgs e)
     {
        this.Close();
     }
        #endregion 

    }
}
