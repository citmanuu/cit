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
using System.Globalization;

namespace MANUUFinance
{
    public partial class BudgetSchedule : Form
    {
        public int GlobalId = 0;
        private int userId, deptId, roleId;
        private string formName;
        bool retrievedForUpdate =  false;

        public BudgetSchedule(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            retrievedForUpdate = false;
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void BudgetSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet12.BudgetSchedule' table. You can move, or remove it, as needed.
            this.budgetScheduleTableAdapter3.Fill(this.financeDataSet12.BudgetSchedule);
            preparecomboFY();
            preparecomboBType();
        }

        // Preparation of Combo
        #region

        private void preparecomboBType()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKBTID, BUDTYPE FROM [finance].[dbo].[BudgetType] Order by 2";
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
                comboBType.DisplayMember = "ListItemDesc"; // will display Name property
                comboBType.ValueMember = "ListItemID"; // will select Value property
                comboBType.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void preparecomboFY()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKFYID, FYName FROM [finance].[dbo].[FinancialYear] Order by 2";
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
                MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        #endregion

        // CURD Operation
        #region
        private void btnAdd_Click(object sender, EventArgs e)
        {
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
                    objSqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("budget_schedule", objSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FYID", comboFY.SelectedValue);
                    cmd.Parameters.AddWithValue("@BType", comboBType.SelectedValue);
                    cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value);
                    cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value);
                    cmd.Parameters.AddWithValue("@BSAddedon", DateTime.Now);
                    cmd.Parameters.AddWithValue("@BSupdatedon", DateTime.Now);
                    cmd.Parameters.AddWithValue("@BSupdateBy", (new SqlCommand("SELECT Name FROM [finance].[dbo].[Users] where userId = '" + userId + "'", objSqlConnection).ExecuteScalar().ToString()));

                    try
                    {
                        bool sucess = Convert.ToBoolean(cmd.ExecuteScalar());
                        if (sucess)
                        {
                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        else
                        {
                            MessageBox.Show("Some Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearTemplate();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Please check Data entry: " + ex.Message, "Dublication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGVBank 
                    this.budgetScheduleTableAdapter3.Fill(this.financeDataSet12.BudgetSchedule);
                }
            }           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
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
                    objSqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("bS_update", objSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BSID", GlobalId);
                    cmd.Parameters.AddWithValue("@FYID", comboFY.SelectedValue);
                    cmd.Parameters.AddWithValue("@BType", comboBType.SelectedValue);
                    cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value);
                    cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value);
                    cmd.Parameters.AddWithValue("@BSupdatedon", DateTime.Now);
                    cmd.Parameters.AddWithValue("@BSupdateBy", (new SqlCommand("SELECT Name FROM [finance].[dbo].[Users] where userId = '" + userId + "'", objSqlConnection).ExecuteScalar().ToString()));


                    try
                    {
                        bool sucess = Convert.ToBoolean(cmd.ExecuteScalar());
                        if (sucess)
                        {
                            MessageBox.Show("Record Updated Successfully", "Record Updatation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                        else
                        {
                            MessageBox.Show("Some Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearTemplate();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Please check Data entry: " + ex.Message, "Dublication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGVBank 
                    this.budgetScheduleTableAdapter3.Fill(this.financeDataSet12.BudgetSchedule);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete the Budget Schedule?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (validateRecord())
                {
                    //Connection String 
                    string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection objSqlConnection = new SqlConnection(cs);

                    // Open the connection
                    objSqlConnection.Open();
                    // Get the number of the row in database
                    SqlCommand cmd = new SqlCommand("bS_update", objSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BSID", GlobalId);
                    cmd.Parameters.AddWithValue("@FYID", comboFY.SelectedValue);
                    cmd.Parameters.AddWithValue("@BType", comboBType.SelectedValue);
                    cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value);
                    cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value);
                    cmd.Parameters.AddWithValue("@BSupdatedon", DateTime.Now);
                    cmd.Parameters.AddWithValue("@BSupdateBy", (new SqlCommand("SELECT Name FROM [finance].[dbo].[Users] where userId = '" + userId + "'", objSqlConnection).ExecuteScalar().ToString()));

                    try
                    {
                        bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                        if (!success)
                        {
                            MessageBox.Show("Record Deleted Successfully", "Record Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTemplate();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGVBank 
                    this.budgetScheduleTableAdapter3.Fill(this.financeDataSet12.BudgetSchedule);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PdfCreator objectpdfcreator = new PdfCreator();
            objectpdfcreator.exportgridviewpdf(DGVBS, "BudgetSchedule");
        }
        #endregion

        // Supporting Operation
        #region
        private void ClearTemplate()
        {
            comboFY.SelectedIndex = 0;
            comboBType.SelectedIndex = 0;
            comboFY.Enabled = true;
            comboBType.Enabled = true;
            retrievedForUpdate = false;

        }

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";
            if (this.comboFY.SelectedIndex == 0)
            {
                validationMessage += "Please provide Financial Year\n";
                validationResult = false;
            }
            if (this.comboBType.SelectedIndex == 0)
            {
                validationMessage += "Please provide Budget Type\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClearRecord_Click(object sender, EventArgs e)
        {
            ClearTemplate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboFY.SelectedValue = Convert.ToInt32(DGVBS.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                comboBType.SelectedValue = Convert.ToInt32(DGVBS.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                dtpFrom.Value = Convert.ToDateTime(DGVBS.Rows[e.RowIndex].Cells[3].Value);
                dtpTo.Value = Convert.ToDateTime(DGVBS.Rows[e.RowIndex].Cells[4].Value);
                retrievedForUpdate = true;
                dtpTo_ValueChanged_1(null, null);
                BSIDcalculate();
                LockKeys();
            }
        }

        private void BSIDcalculate()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            objSqlConnection.Open();
            GlobalId = Convert.ToInt32(new SqlCommand("SELECT BSID FROM [finance].[dbo].[BudgetSchedule] where  FYID = '"+ comboFY.SelectedValue +"' AND BType =  '"+ comboBType.SelectedValue +"' AND FromDate = '"+ dtpFrom.Value + "' AND ToDate = '"+dtpTo.Value +"'", objSqlConnection).ExecuteScalar().ToString());
        }

        private void LockKeys()
        {
            comboFY.Enabled = false;
            comboBType.Enabled = false;
        }

        private void dtpTo_ValueChanged_1(object sender, EventArgs e)
        {
            int days;
            days = (Convert.ToDateTime(dtpTo.Value) - Convert.ToDateTime(dtpFrom.Value)).Days;
            label5.Text = days.ToString();
        }
        #endregion
    }
}
