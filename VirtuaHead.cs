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
    public partial class frmVirtuaHead : Form
    {
        bool retrievedForUpdate = false;
        private int userId, deptId, roleId;
        string formName;
        int GlobalId = 0;
        public frmVirtuaHead(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void VirtuaHead_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet17.VirtualHeadView' table. You can move, or remove it, as needed.
           // this.virtualHeadViewTableAdapter.Fill(this.financeDataSet17.VirtualHeadView);
            preparedcomboVH();
            preparedcombosl1();
            preparedcombosl2("0");
            preparedcombosl3("0");
            preparedcomboaccount();
            preparedDGV();
            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }
        }

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

        private void preparedDGV()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            if (new AdministratorLogin().administratorLogin(userId))
            {
                SqlDataAdapter sqldb = new SqlDataAdapter("SELECT  A.SL1Name, B.SL2Name, C.SL3Name, D.AccName FROM dbo.SL1 AS A, dbo.SL2 AS B, dbo.SL3 AS C, dbo.AcName AS D, dbo.VHDtl AS E, dbo.VHMst AS F where E.FKVHID = F.VHID AND E.FKSL1ID = A.SL1ID AND E.FKSL2ID = B.PKSL2 AND E.FKSL3ID = C.PKSL3 AND E.FKACID = D.ACIDID AND E.DeptId = '"+deptId+"'", objSqlConnection);
                DataTable dtb1 = new DataTable();
                sqldb.Fill(dtb1);
                DGVVH.DataSource = dtb1;
            }
            else
            {
                SqlDataAdapter sqldb = new SqlDataAdapter("SELECT  A.SL1Name, B.SL2Name, C.SL3Name, D.AccName FROM dbo.SL1 AS A, dbo.SL2 AS B, dbo.SL3 AS C, dbo.AcName AS D, dbo.VHDtl AS E, dbo.VHMst AS F where E.FKVHID = F.VHID AND E.FKSL1ID = A.SL1ID AND E.FKSL2ID = B.PKSL2 AND E.FKSL3ID = C.PKSL3 AND E.FKACID = D.ACIDID", objSqlConnection);
                DataTable dtb1 = new DataTable();
                sqldb.Fill(dtb1);
                DGVVH.DataSource = dtb1;
            }
        }

        private void preparedcomboaccount()
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
                comboACCOUNT.DisplayMember = "ListItemDesc"; // will display Name property
                comboACCOUNT.ValueMember = "ListItemID"; // will select Value property
                comboACCOUNT.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        // support  
        #region
        private void preparedcombosl3(string fkSL2)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKSL3, SL3Name FROM [finance].[dbo].[SL3] where FKSL2ID = " + fkSL2 + " Order by 2";
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
                MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void preparedcombosl2(string fkSL1)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKSL2, SL2Name FROM [finance].[dbo].[SL2] where SL1ID = " + fkSL1 + " Order by 2";
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
                MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void preparedcombosl1()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT SL1ID, SL1Name FROM [finance].[dbo].[SL1] Order by 2";
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
                MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void preparedcomboVH()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT VHID, VHNAME FROM [finance].[dbo].[VHMst] Order by 2";
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
                comboVH.DisplayMember = "ListItemDesc"; // will display Name property
                comboVH.ValueMember = "ListItemID"; // will select Value property
                comboVH.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void comboSL2_SelectedIndexChanged(object sender, EventArgs e)
        {
            preparedcombosl3(Convert.ToString(comboSL2.SelectedValue));
        }

        private void comboSL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preparedcombosl2(Convert.ToString(comboSL1.SelectedValue));
        }

        private void ClearTemplate()
        {
            comboVH.SelectedIndex = 0;
            comboSL1.SelectedIndex = 0;
            comboSL2.SelectedIndex = 0;
            comboSL3.SelectedIndex = 0;
            comboACCOUNT.SelectedIndex = 0;
        }

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (Convert.ToString(comboVH.SelectedValue) == "0")
            {
                validationMessage = "Please Select Financial Year\n";
                validationResult = false;
            }
            if (Convert.ToString(comboSL1.SelectedValue) == "0")
            {
                validationMessage = "Please Select Departent Name\n";
                validationResult = false;
            }
            if (Convert.ToString(comboSL2.SelectedValue) == "0")
            {
                validationMessage = "Please Select SL1 Name\n";
                validationResult = false;
            }
            if (Convert.ToString(comboSL3.SelectedValue) == "0")
            {
                validationMessage += "Please Select SL2 Name\n";
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

        private void DGVVH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboVH.Text = "Contingency";
                comboSL1.Text = DGVVH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                comboSL2.Text = DGVVH.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                comboSL3.Text = DGVVH.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                comboACCOUNT.Text = DGVVH.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                retrievedForUpdate = true;
                LockKeys();
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT VHDTLID FROM [finance].[dbo].[VHDtl] where FKSL1ID = '" + comboSL1.SelectedValue + "' AND FKSL2ID = '" + comboSL2.SelectedValue + "'AND FKSL3ID = '" + comboSL3.SelectedValue + "' AND FKACID = '" + comboACCOUNT.SelectedValue + "'", con);
                GlobalId = Convert.ToInt32(myCommand.ExecuteScalar().ToString());
                con.Close();
            }
        }

        private void LockKeys()
        {
            comboVH.Enabled = false;
            comboSL1.Enabled = false;
            comboSL2.Enabled = false;
            comboSL3.Enabled = false;
        }
        #endregion

        // DML 
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
                    string insertCommand = "INSERT INTO [dbo].[VHDtl] (FKSL1ID, FKSL2ID, FKSL3ID, FKACID, FKVHID,DeptId) " +
                                            "VALUES (@FKSL1ID, @FKSL2ID, @FKSL3ID, @FKACID, @FKVHID, @DeptId)";

                    SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

                    objInsertCommand.Parameters.AddWithValue("@FKSL1ID", comboSL1.SelectedValue);
                    objInsertCommand.Parameters.AddWithValue("@FKSL2ID", comboSL2.SelectedValue);
                    objInsertCommand.Parameters.AddWithValue("@FKSL3ID", comboSL3.SelectedValue);
                    objInsertCommand.Parameters.AddWithValue("@FKACID", comboACCOUNT.SelectedValue);
                    objInsertCommand.Parameters.AddWithValue("@FKVHID", comboVH.SelectedValue);
                    objInsertCommand.Parameters.AddWithValue("@DeptId", deptId);

                    try
                    {
                        objSqlConnection.Open();
                        objInsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //this.virtualHeadViewTableAdapter.Fill(this.financeDataSet17.VirtualHeadView);
                    preparedDGV();
                }
            }
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

                    string updateCommand = "Update [dbo].[VHDtl] set FKSL1ID = @FKSL1ID, FKSL2ID = @FKSL2ID, FKSL3ID = @FKSL3ID, FKACID = @FKACID, DeptId=@DeptId " +
                                           "where VHDTLID = '"+ GlobalId + "'";

                    SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);
                    objUpdateCommand.Parameters.AddWithValue("@FKSL1ID", comboSL1.SelectedValue);
                    objUpdateCommand.Parameters.AddWithValue("@FKSL2ID", comboSL2.SelectedValue);
                    objUpdateCommand.Parameters.AddWithValue("@FKSL3ID", comboSL3.SelectedValue);
                    objUpdateCommand.Parameters.AddWithValue("@FKACID", comboACCOUNT.SelectedValue);
                    objUpdateCommand.Parameters.AddWithValue("@FKVHID", comboVH.SelectedValue);
                    objUpdateCommand.Parameters.AddWithValue("@DeptId", deptId);

                    try
                    {
                        objSqlConnection.Open();
                        objUpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //this.virtualHeadViewTableAdapter.Fill(this.financeDataSet17.VirtualHeadView);
                    preparedDGV();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete ?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);

                //Prepare Delete String
                string deleteCommand = "Delete from Finance.dbo.VHDtl where VHDTLID= '"+GlobalId +"';";
                SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

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
                //this.virtualHeadViewTableAdapter.Fill(this.financeDataSet17.VirtualHeadView);
                //preparedDGV();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboVH.SelectedIndex = 0;
            comboSL1.SelectedIndex = 0;
            comboSL2.SelectedIndex = 0;
            comboSL3.SelectedIndex = 0;
            comboACCOUNT.SelectedIndex = 0;

            comboSL1.Enabled = true;
            comboSL2.Enabled = true;
            comboSL3.Enabled = true;
            comboVH.Enabled = true;
            retrievedForUpdate = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Supports objectsupport = new Supports(DGVVH, "VirtualHead");
            objectsupport.ShowDialog();
        }
    }
}
