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
    public partial class frmSL2 : Form
    {
        bool retrievedForUpdate;
        private int userId, deptId, roleId;
        string formName;
        public frmSL2(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void frmSL2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet13.SL2SL1' table. You can move, or remove it, as needed.
            this.sL2SL1TableAdapter1.Fill(this.financeDataSet13.SL2SL1);
            //Prepare Combo for Showing Account Types
            PrepareSL1Combo();
            retrievedForUpdate = false;
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
        }

        //DML Region
        #region 

        //Add Record
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
                        string insertCommand = "Insert into SL2 (SL1ID, SL2ID, SL2Name, SL2Active, SL2Order) values " +
                                                "(@SL1ID, @SL2ID, @SL2Name, @SL2Active, @SL2Order)";
                        SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                        objInsertCommand.Parameters.AddWithValue("@SL1ID", comboSL1.SelectedValue);
                        objInsertCommand.Parameters.AddWithValue("@SL2ID", GetMaxSL2ID());
                        objInsertCommand.Parameters.AddWithValue("@SL2Name", txtSL2Name.Text);
                        objInsertCommand.Parameters.AddWithValue("@SL2Order", txtSL2Order.Text);
                        if (radioBtnSL2Active.Checked == true)
                            objInsertCommand.Parameters.AddWithValue("@SL2Active", "1");
                        else
                            objInsertCommand.Parameters.AddWithValue("@SL2Active", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objInsertCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_SL2"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL2Name.Focus();
                            }
                            if (ex.Message.Contains("Unique_SL1_SL2"))
                            {
                                MessageBox.Show("SL1ID and SL2ID must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL2Name.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                    //Refresh DGV 
                    this.sL2SL1TableAdapter1.Fill(this.financeDataSet13.SL2SL1);
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
                        string updateCommand = "Update SL2 set SL2Name = @SL2Name, SL2Active = @SL2Active, SL2Order = @SL2Order " +
                                                "where PKSL2 = @PKSL2";
                        SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                        objUpdateCommand.Parameters.AddWithValue("@SL2Name", txtSL2Name.Text);
                        objUpdateCommand.Parameters.AddWithValue("@SL2Order", txtSL2Order.Text);
                        objUpdateCommand.Parameters.AddWithValue("@PKSL2", txtPKSL2.Text);

                        if (radioBtnSL2Active.Checked == true)
                            objUpdateCommand.Parameters.AddWithValue("@SL2Active", "1");
                        else
                            objUpdateCommand.Parameters.AddWithValue("@SL2Active", "0");

                        try
                        {
                            objSqlConnection.Open();
                            objUpdateCommand.ExecuteNonQuery();
                            MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Message.Contains("PK_SL2"))
                            {
                                MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL2Name.Focus();
                            }
                            if (ex.Message.Contains("Unique_SL1_SL2"))
                            {
                                MessageBox.Show("SL1ID and SL2ID must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtSL2Name.Focus();
                            }
                            else
                                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        finally
                        {
                            objSqlConnection.Close();
                        }
                    //Refresh DGV 
                    this.sL2SL1TableAdapter1.Fill(this.financeDataSet13.SL2SL1);
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
                    string deleteCommand = "Delete from Finance.dbo.SL2 where PKSL2 = @PKSL2;";
                    SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                    objDeleteCommand.Parameters.AddWithValue("@PKSL2", txtPKSL2.Text);

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
                  this.sL2SL1TableAdapter1.Fill(this.financeDataSet13.SL2SL1);
            }
           }

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
                MessageBox.Show("The following error occured (SL1->GetMaxSL1Code): " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        #endregion



        //Support Functions/Methods Region
        #region

        //Get Value for SL2ID for selected SL1 ID
        private int GetMaxSL2ID()
        {
            string MaxSL2ID = "";
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select Isnull(max(SL2ID), '0') from Finance.dbo.SL2 where SL1ID = @SL1ID;";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            objSelectCommand.Parameters.AddWithValue("@SL1ID", Convert.ToString(comboSL1.SelectedValue));
            try
            {
                objSqlConnection.Open();
                MaxSL2ID = Convert.ToString(objSelectCommand.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured (SL1->GetMaxSL1Code): " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
            return Convert.ToInt32(MaxSL2ID) + 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        //Clear Template Method
        private void ClearTemplate()
        {
            comboSL1.SelectedValue = 0;
            txtSL2ID.Text = "";
            txtSL2Name.Text = "";
            txtSL2Order.Text = "";
            radioBtnSL2Active.Checked = false;
            radioBtnSL2InActive.Checked = false;            
            retrievedForUpdate = false;
            comboSL1.Enabled = true;
            comboSL1.SelectedIndex = 0;
            txtSL2ID.Enabled = true;
            txtSL2ID.Text = "";
            txtSL2Code.Text = "";
            txtPKSL2.Text = "";
        }

        //Trasfer Record to Template from the row where user has clicked the mouse
        private void DGVSL2SL1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
            txtPKSL2.Text = DGVSL2SL1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                if (DGVSL2SL1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "")
                {
                    comboSL1.SelectedValue = "";
                }
                else
                    comboSL1.SelectedValue = Convert.ToInt32(DGVSL2SL1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                if (DGVSL2SL1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString() == "")
                {
                    txtSL2ID.Text = "";
                }
                else
                    txtSL2ID.Text = DGVSL2SL1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtSL2Name.Text = DGVSL2SL1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            if (Convert.ToBoolean(DGVSL2SL1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString()) == true)
                radioBtnSL2Active.Checked = true;
            else
                radioBtnSL2InActive.Checked = true;
            txtSL2Order.Text = DGVSL2SL1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            txtSL2Code.Text = DGVSL2SL1.Rows[e.RowIndex].Cells[8].FormattedValue.ToString();

            retrievedForUpdate = true;
            LockKeys();
        }
        }

        //Lock Fields Before Edit
        private void LockKeys()
        {
            comboSL1.Enabled = false;
            txtSL2ID.Enabled = false;
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
            if (txtSL2Name.Text.Length == 0)
            {
                validationMessage += "Please provide value for SL2 Name\n";
                validationResult = false;
            }
            if (txtSL2Order.Text.Length == 0)
            {
                validationMessage += "Please provide value for SL2 Order\n";
                validationResult = false;
            }
            if (radioBtnSL2Active.Checked == false && radioBtnSL2InActive.Checked == false)
            {
                validationMessage += "Please provide value for SL2 Active Status\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "SL2 Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

        //Prevent Non-Numeric Values for SL1Order
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVSL2SL1, "SL2");
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
