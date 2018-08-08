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
                    this.sL3SL2SL1TableAdapter1.Fill(this.financeDataSet13.SL3SL2SL1);
                }
            }
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
