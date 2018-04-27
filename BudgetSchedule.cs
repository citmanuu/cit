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
        bool retrievedForUpdate;

        public BudgetSchedule()
        {
            InitializeComponent();
            retrievedForUpdate = false;
        }

        private void BudgetSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet9.BudgetSchedule' table. You can move, or remove it, as needed.
            this.budgetScheduleTableAdapter.Fill(this.financeDataSet9.BudgetSchedule);
            preparecomboFY();
            preparecomboBType();
        }

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
                    this.budgetScheduleTableAdapter.Fill(this.financeDataSet9.BudgetSchedule);
                }
            }
        }

        private void ClearTemplate()
        {
            comboFY.SelectedIndex = 0;
            comboBType.SelectedIndex = 0;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboFY.SelectedValue = Convert.ToInt32(DGVBS.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
                comboBType.SelectedValue = Convert.ToInt32(DGVBS.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                DateTime dt = DateTime.ParseExact(DGVBS.Rows[e.RowIndex].Cells[3].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dtpFrom.Value = dt;
                DateTime dt1 = DateTime.ParseExact(DGVBS.Rows[e.RowIndex].Cells[4].Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                dtpTo.Value = dt1;
                dtpTo_ValueChanged_1(null, null);

            }
        }

        private void dtpTo_ValueChanged_1(object sender, EventArgs e)
        {
            int days;
            days = (Convert.ToDateTime(dtpTo.Value) - Convert.ToDateTime(dtpFrom.Value)).Days;
            label5.Text = days.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
