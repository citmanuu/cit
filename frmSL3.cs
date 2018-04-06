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
    public partial class frmSL3 : Form
    {
        bool retrievedForUpdate = false;
        private int userId, deptId, roleId;
        string formName;
        public frmSL3(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void frmSL3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet.SL3SL2SL1' table. You can move, or remove it, as needed.
            this.sL3SL2SL1TableAdapter.Fill(this.financeDataSet.SL3SL2SL1);
            // TODO: This line of code loads data into the 'financeDataSet.SL3SL2SL1' table. You can move, or remove it, as needed.
            try
            {
                this.sL3SL2SL1TableAdapter.Fill(this.financeDataSet.SL3SL2SL1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "====" + ex.Source + "===" + ex.StackTrace, "Hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Prepare Combo for Showing SL1 and SL2 
            PrepareSL1Combo();
            PrepareSL2Combo("0");
            prepareaction();
            if (userId != 5 || userId != 6 || userId != 7)
            {
                prepareaction();
            }
        }

        //DML Region
        #region

        //Prepare SL1Combo
        private void PrepareSL1Combo()
        {
            var objSL1Class = new List<SL1Class>();
            objSL1Class.Add(new SL1Class(0, "-- Please Select --"));

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
                    objSL1Class.Add(new SL1Class(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboSL1.DisplayMember = "SL1Name"; // will display Name property
                comboSL1.ValueMember = "SL1ID"; // will select Value property
                comboSL1.DataSource = objSL1Class; // assign list (will populate comboBox1.Items)
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
        private void PrepareSL2Combo(string fkSL1)
        {
            var objSL2Class = new List<SL2Class>();
            objSL2Class.Add(new SL2Class(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select PKSL2, SL2Name from Finance.dbo.SL2 where SL1ID = " + fkSL1 + "order by 2;";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objSL2Class.Add(new SL2Class(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboSL2.DisplayMember = "SL2Name"; // will display Name property
                comboSL2.ValueMember = "SL2ID"; // will select Value property
                comboSL2.DataSource = objSL2Class; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UniqueSL1SL2Sl3"))
                {
                    MessageBox.Show("SL1ID, SL2ID and SL3ID must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSL3Name.Focus();
                }
                else
                    MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        //Add Record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check the action permission
            string CanAdd = "CanAdd";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanAdd, formName))
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
                        string insertCommand = "Insert into SL3 (FKSL1ID, FKSL2ID, SL3ID, SL3Name, SL3Active, SL3Order) values " +
                                                "(@FKSL1ID, @FKSL2ID, @SL3ID, @SL3Name, @SL3Active, @SL3Order)";
                        SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objInsertCommand.Parameters.AddWithValue("@FKSL1ID", Convert.ToString(comboSL1.SelectedValue));
                        objInsertCommand.Parameters.AddWithValue("@FKSL2ID", comboSL2.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@SL3ID", txtSL3ID.Text);
                        objInsertCommand.Parameters.AddWithValue("@SL3Name", txtSL3Name.Text);
                        objInsertCommand.Parameters.AddWithValue("@SL3Order", txtSL3Order.Text);
                        if (radioBtnSL3Active.Checked == true)
                            objInsertCommand.Parameters.AddWithValue("@SL3Active", "1");
                        else
                            objInsertCommand.Parameters.AddWithValue("@SL3Active", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objInsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_SL3"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL3Name.Focus();
                            }
                            if (ex.Message.Contains("UniqueSL3SL2SL1"))
                            {
                                MessageBox.Show("SL1ID, SL2ID and SL3 must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL3Name.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGV 
                        this.sL3SL2SL1TableAdapter.Fill(this.financeDataSet.SL3SL2SL1);
                    }
                }
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Update Record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check the action permission
            string CanUpdate = "CanUpdate";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanUpdate, formName))
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
                        string updateCommand = "Update SL3 set SL3Name = @SL3Name, SL3Active = @SL3Active, SL3Order = @SL3Order, @SL3ID = SL3ID " +
                                                "where PKSL3 = @PKSL3";
                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@SL3Name", txtSL3Name.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL3Order", txtSL3Order.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL3ID", txtSL3ID.Text);
                        objUpdateCommand.Parameters.AddWithValue("@PKSL3", txtPKSL3.Text);

                        if (radioBtnSL3Active.Checked == true)
                            objUpdateCommand.Parameters.AddWithValue("@SL3Active", "1");
                        else
                            objUpdateCommand.Parameters.AddWithValue("@SL3Active", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_SL3"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL3Name.Focus();
                            }
                            if (ex.Message.Contains("UniqueSL3SL2SL1"))
                            {
                                MessageBox.Show("SL1ID, SL2ID and SL3ID must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL3Name.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                        //Refresh DGV 
                        this.sL3SL2SL1TableAdapter.Fill(this.financeDataSet.SL3SL2SL1);
                    }
                }
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Delete Record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check the action permission
            string CanDelete = "CanDelete";
            if (new CheckingPrivileges().CheckingPrivilegesaction(userId, deptId, roleId, CanDelete, formName))
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
                    string deleteCommand = "Delete from Finance.dbo.SL3 where PKSL3 = @PKSL3;";
                    SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                    objDeleteCommand.Parameters.AddWithValue("@PKSL3", txtPKSL3.Text);

                    try
                    {
                        objSqlConnection.Open();
                        objDeleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.sL3SL2SL1TableAdapter.Fill(this.financeDataSet.SL3SL2SL1);
                }
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        #endregion


        //Support Methods Region
        #region
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        //Clear Template Method
        private void ClearTemplate()
        {
            comboSL1.Enabled = true;
            comboSL1.SelectedValue = 0;
            comboSL2.Enabled = true;
            comboSL2.SelectedValue = 0;
            txtSL3ID.Enabled = true;
            txtSL3ID.Text = "";
            txtSL3Name.Text = "";
            txtSL3Order.Text = "";
            radioBtnSL3Active.Checked = false;
            radioBtnSL3InActive.Checked = false;
            retrievedForUpdate = false;
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
            if (txtSL3ID.Text.Length == 0)
            {
                validationMessage += "Please provide value for SL3 ID\n";
                validationResult = false;
            }
            if (txtSL3Name.Text.Length == 0)
            {
                validationMessage += "Please provide value for SL3 Name\n";
                validationResult = false;
            }
            if (txtSL3Order.Text.Length == 0)
            {
                validationMessage += "Please provide value for SL3 Order\n";
                validationResult = false;
            }
            if (radioBtnSL3Active.Checked == false && radioBtnSL3InActive.Checked == false)
            {
                validationMessage += "Please provide value for SL3 Active Status\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "SL3 Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        //If Value of SL3 is Zero, Set SL3Name = ComboSelection for SL2
        private void txtSL3ID_TextChanged(object sender, EventArgs e)
        {
            if (txtSL3ID.Text == "0")
            {
                txtSL3Name.Text = comboSL2.Text;
                txtSL3Name.Enabled = false;
            }
            else
                txtSL3Name.Enabled = true;
        }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVSL3SL2SL1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPKSL3.Text = DGVSL3SL2SL1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtSL3Code.Text = DGVSL3SL2SL1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                comboSL1.SelectedValue = Convert.ToInt32(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                comboSL2.SelectedValue = Convert.ToInt32(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                txtSL3Name.Text = DGVSL3SL2SL1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                if (Convert.ToBoolean(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString()) == true)
                    radioBtnSL3Active.Checked = true;
                else
                    radioBtnSL3InActive.Checked = true;
                txtSL3Order.Text = DGVSL3SL2SL1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();
                txtSL3ID.Text = Convert.ToString(Convert.ToInt32(txtSL3Code.Text.Substring(5)));

                retrievedForUpdate = true;
                LockKeys();

            }
        }

        //Lock Fields Before Edit
        private void LockKeys()
        {
            comboSL1.Enabled = false;
            comboSL2.Enabled = false;
            txtSL3ID.Enabled = false;
        }
        
        //Prevent Non-Numeric Values for SL1Order
        private void txtSL3Order_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        //Prevent Non-Numeric Values for SL1ID
        private void txtSL3ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVSL3SL2SL1, "SL3");
            objectsupport.ShowDialog();
        }


        //Close Form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #endregion


    }
}
