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
    public partial class frmVAcType : Form
    {
        bool retrievedForUpdate = false;
        private int userId, deptId, roleId;
        string formName;
        public frmVAcType(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void frmVAcType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet15.VATMap' table. You can move, or remove it, as needed.
            this.vATMapTableAdapter.Fill(this.financeDataSet15.VATMap);
            PrepareSL1Combo();
            PrepareSL2Combo("0");
            PrepareSL3Combo("0", "0");
            PrepateAcType();
        }

        private void PrepateAcType()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT ACIDID, AccName FROM [finance].[dbo].[AcName] Order by 2";
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
                comboAccountType.DisplayMember = "ListItemDesc"; // will display Name property
                comboAccountType.ValueMember = "ListItemID"; // will select Value property
                comboAccountType.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void PrepareSL3Combo(string fkSL2, string fkSL1)
        {
            var objSL3Class = new List<SL3Class>();
            objSL3Class.Add(new SL3Class(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "Select PKSL3, SL3Name from Finance.dbo.SL3 where FKSL2ID = " + fkSL2 + " and FKSL1ID ="+ fkSL1 + "order by 2;";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objSL3Class.Add(new SL3Class(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboSL3.DisplayMember = "SL3Name"; // will display Name property
                comboSL3.ValueMember = "PKSL3"; // will select Value property
                comboSL3.DataSource = objSL3Class; // assign list (will populate comboBox1.Items)
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UniqueSL1SL2Sl3"))
                {
                    MessageBox.Show("SL1ID, SL2ID and SL3ID must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void comboSL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareSL2Combo(Convert.ToString(comboSL1.SelectedValue));
        }

        private void comboSL2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareSL3Combo(Convert.ToString(comboSL2.SelectedValue), Convert.ToString(comboSL1.SelectedValue));
        }

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
                    string insertCommand = "Insert into VATMap (FKSL1ID, FKSL2ID, FKSL3ID, VAcName, VAcActive, VAcOrder, VACAddedOn, VACUpdatedOn, VACUpdateBy) values " +
                                            "(@FKSL1ID, @FKSL2ID, @FKSL3ID, @VAcName, @VAcActive, @VAcOrder, @VACAddedOn, @VACUpdatedOn, @VACUpdateBy)";
                    SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                    objInsertCommand.Parameters.AddWithValue("@FKSL1ID", Convert.ToString(comboSL1.SelectedValue));
                    objInsertCommand.Parameters.AddWithValue("@FKSL2ID", Convert.ToString(comboSL2.SelectedValue));
                    objInsertCommand.Parameters.AddWithValue("@FKSL3ID", Convert.ToString(comboSL3.SelectedValue));
                    objInsertCommand.Parameters.AddWithValue("@VAcName", Convert.ToString(comboAccountType.SelectedValue));                    
                    objInsertCommand.Parameters.AddWithValue("@VAcOrder", txtVAcOrder.Text);
                    objInsertCommand.Parameters.AddWithValue("@VACAddedOn", DateTime.Now);
                    objInsertCommand.Parameters.AddWithValue("@VACUpdatedOn", DateTime.Now);
                    objInsertCommand.Parameters.AddWithValue("@VACUpdateBy", userId.ToString()); 
                    if (radioBtnSL3Active.Checked == true)
                        objInsertCommand.Parameters.AddWithValue("@VAcActive", "1");
                    else
                        objInsertCommand.Parameters.AddWithValue("@VAcActive", "0");

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
                        }
                        if (ex.Message.Contains("UniqueSL3SL2SL1"))
                        {
                            MessageBox.Show("SL1ID, SL2ID and SL3 must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);                            
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV  
                    this.vATMapTableAdapter.Fill(this.financeDataSet15.VATMap);
                }
            }
        }

        private void ClearTemplate()
        {
            comboSL1.Enabled = true;
            comboSL1.SelectedValue = 0;
            comboSL2.Enabled = true;
            comboSL2.SelectedValue = 0;
            comboSL3.Enabled = true;
            comboSL3.SelectedValue = 0;
            txtVAcOrder.Text = "";
            radioBtnSL3Active.Checked = false;
            radioBtnSL3InActive.Checked = false;
            retrievedForUpdate = false;
        }

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
            if (Convert.ToString(comboAccountType.SelectedValue) == "0")
            {
                validationMessage += "Please Select Account Type\n";
                validationResult = false;
            }
            if (txtVAcOrder.Text.Length == 0)
            {
                validationMessage += "Please provide value for Account Order\n";
                validationResult = false;
            }
            if (radioBtnSL3Active.Checked == false && radioBtnSL3InActive.Checked == false)
            {
                validationMessage += "Please provide value for Account Active Status\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }

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
                    string updateCommand = "Update VATMap set VAcName = @VAcName, VAcActive = @VAcActive, VAcOrder = @VAcOrder, VACUpdatedOn = @VACUpdatedOn " +
                                            "where FKSL1ID = @FKSL1ID and FKSL2ID = @FKSL2ID and FKSL3ID = @FKSL3ID ";
                    SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                    objUpdateCommand.Parameters.AddWithValue("@FKSL1ID", Convert.ToString(comboSL1.SelectedValue));
                    objUpdateCommand.Parameters.AddWithValue("@FKSL2ID", Convert.ToString(comboSL2.SelectedValue));
                    objUpdateCommand.Parameters.AddWithValue("@FKSL3ID", Convert.ToString(comboSL3.SelectedValue));
                    objUpdateCommand.Parameters.AddWithValue("@VAcName", Convert.ToString(comboAccountType.SelectedValue));
                    objUpdateCommand.Parameters.AddWithValue("@VAcOrder", txtVAcOrder.Text);
                    objUpdateCommand.Parameters.AddWithValue("@VACUpdatedOn", DateTime.Now);
                    objUpdateCommand.Parameters.AddWithValue("@VACUpdateBy", userId.ToString());
                    if (radioBtnSL3Active.Checked == true)
                        objUpdateCommand.Parameters.AddWithValue("@VAcActive", "1");
                    else
                        objUpdateCommand.Parameters.AddWithValue("@VAcActive", "0");

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
                        }
                        if (ex.Message.Contains("UniqueSL3SL2SL1"))
                        {
                            MessageBox.Show("SL1ID, SL2ID and SL3ID must be Unique", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);                           
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.vATMapTableAdapter.Fill(this.financeDataSet15.VATMap);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtVAcOrder.Text = DGVSL3SL2SL1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                comboSL1.SelectedValue = Convert.ToInt32(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                comboSL2.SelectedValue = Convert.ToInt32(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                comboSL3.SelectedValue = Convert.ToInt32(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                comboAccountType.SelectedValue = Convert.ToInt32(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                
                if (Convert.ToBoolean(DGVSL3SL2SL1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString()) == true)
                    radioBtnSL3Active.Checked = true;
                else
                    radioBtnSL3InActive.Checked = true;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (retrievedForUpdate)
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
                    string deleteCommand = "Delete from Finance.dbo.VATMap where FKSL1ID = @FKSL1ID and FKSL2ID = @FKSL2ID and FKSL3ID = @FKSL3ID;";
                    SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                    objDeleteCommand.Parameters.AddWithValue("@FKSL1ID", comboSL1.SelectedValue);
                    objDeleteCommand.Parameters.AddWithValue("@FKSL2ID", comboSL2.SelectedValue);
                    objDeleteCommand.Parameters.AddWithValue("@FKSL3ID", comboSL3.SelectedValue);
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
                    this.vATMapTableAdapter.Fill(this.financeDataSet15.VATMap);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrint objectsupport = new frmPrint(DGVSL3SL2SL1, "SL3");
            objectsupport.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboSL1.SelectedIndex = 0;
            comboSL2.SelectedIndex = 0;
            comboSL3.SelectedIndex = 0;
            comboAccountType.SelectedIndex = 0;
            radioBtnSL3Active.Checked = false;
            radioBtnSL3InActive.Checked = false;
            txtVAcOrder.Text = "";
            comboSL1.Enabled = true;
            comboSL2.Enabled = true;
            comboSL3.Enabled = true; 
        }

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
                }
                else
                    MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

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
    }
}
