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
    public partial class frmBillDespatchs : Form
    {
        bool retrievedForUpdate;
        bool queryMode, printVoucher = false;
        DateTime today = DateTime.Today;
        private int userId, deptId, roleId;
        string formName;
        int BilledAmount = 0, BECY = 0, currentspentamount = 0, FKACID = 0, PKBillID;
        public int spendamount { get; set; }
        public frmBillDespatchs(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        #region // Support

        private void frmBillDespatchs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet23.BillMst' table. You can move, or remove it, as needed.
            this.billMstTableAdapter.Fill(this.financeDataSet23.BillMst);
            txtPKBillID.Text = "0";
            txtBillDate.Text = today.ToString("dd/MM/yyyy");
            retrievedForUpdate = false;
            queryMode = false;
            PrepareDeptCombo();
            PrepareBillTypeCombo();
            PrepareBillStatusCombo();
            comboBillTypeSub.Enabled = false;
            btnClear.Enabled = false;

            if (new AdministratorLogin().administratorLogin(userId))
            {
                prepareaction();
            }

        }
       
        private void PrepareBillStatusCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] WHERE GEMID = 3 Order by 2";
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
                comboBillStatus.DisplayMember = "ListItemDesc"; // will display Name property
                comboBillStatus.ValueMember = "ListItemID"; // will select Value property
                comboBillStatus.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void comboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboDept.SelectedIndex != 0)
            {
                Preparebudgetactype();
            }
        }

        private void comboBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBillType.SelectedValue) == 13)
            {
                comboBillTypeSub.Enabled = false;
                PreparecomboBillTypeSub();
                PrepareEmployeesCombo();
            }
            else
            {
                comboBillTypeSub.Enabled = true;
                PreparecomboBillTypeSub();
            }
        }

        private void comboBillTypeSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareBeneficiaryCombo();
        }

        private void PrepareBeneficiaryCombo()
        {
            //Prepare Medical Combo
            if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 3)
            {
                //PrepareEmployeeCombo();
            }
            //Prepare Student Combo
            else if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 4)
            {
                PrepareStudentsCombo();
            }
            //Prepare Employee Combo
            else if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 11)
            {
                PrepareEmployeesCombo();
            }
            else if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 12)
            {
                PrepareSuppliersCombo();
            }
        }

        private void comboBudgetACTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBudgetACTYPE.SelectedValue) == 16)
            {
                preparedFY();
                comboSL1.Enabled = false;
                comboSL2.Enabled = false;
                comboSL3.Enabled = false;
            }
            else if (comboBudgetACTYPE.SelectedIndex != 0)
            {
                preparedFY();
                comboSL1.Enabled = true;
                comboSL2.Enabled = true;
                comboSL3.Enabled = true;
            }
        }

        private void preparedcomboSL3(int fkSL2)
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

        private void preparedcomboSL2(int fkSL1)
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

        private void preparedcomboSL1(int SL1ID)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));
            string selectCommand = null;
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            if (SL1ID != 0)
            {
                selectCommand = "SELECT SL1ID, SL1Name FROM [finance].[dbo].[SL1] where SL1ID = '" + SL1ID + "' Order by 2";
            }
            else
            {
                selectCommand = "SELECT SL1ID, SL1Name FROM [finance].[dbo].[SL1] Order by 2";
            }

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

        private void preparedFY()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKFYID, FYName FROM [Finance].[dbo].[FinancialYear] Order by 1";
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
                MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void comboSL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSL1.SelectedIndex != 0)
                preparedcomboSL2(Convert.ToInt32(comboSL1.SelectedValue));
        }

        private void comboSL2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSL2.SelectedIndex != 0)
                preparedcomboSL3(Convert.ToInt32(comboSL2.SelectedValue));
        }

        private void comboSL3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSL3.SelectedIndex != 0)
            {
                PrepareAccountNameCombo(0);
            }

        }

        private int PrepareAccount(int AccountType)
        {
            int account = 0;
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKACID FROM [Finance].[dbo].[Accounts] WHERE FKSL3ID = '" + AccountType + "'";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    account = Convert.ToInt32(objDataReader[0]);
                    break;
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
            return account;
        }

        private void PrepareAccountNameCombo(int AccountType)
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));
            string selectCommand = null;
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            if (AccountType != 0)
            {
                selectCommand = "SELECT PKACID, AccountName + ' (' +  SL3Code + ')' FROM [Finance].[dbo].[BudgetWithAccounts] WHERE DeptId = '" + comboDept.SelectedValue + "' and PKACID = '" + AccountType + "'and PKFYID = '" + comboFY.SelectedValue + "' Order by 1";
            }
            else
            {
                selectCommand = "SELECT PKACID, AccountName + ' (' +  SL3Code + ')' FROM [Finance].[dbo].[BudgetWithAccounts] WHERE DeptId = '" + comboDept.SelectedValue + "' and PKFYID = '" + comboFY.SelectedValue + "' Order by 1";
            }

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
                comboAccountName.DisplayMember = "ListItemDesc"; // will display Name property
                comboAccountName.ValueMember = "ListItemID"; // will select Value property
                comboAccountName.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void comboFY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBudgetACTYPE.SelectedValue) == 16 && comboFY.SelectedIndex != 0)
            {
                preparedcomboSL1(26);
                preparedcomboSL2(138);
                preparedcomboSL3(197);
                comboSL1.SelectedIndex = 1;
                comboSL2.SelectedIndex = 1;
                comboSL3.SelectedIndex = 1;
                PrepareAccountNameCombo(117);

            }
            else if (comboFY.SelectedIndex != 0)
            {
                preparedcomboSL1(0);
            }
        }

        private void PrepareSuppliersCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKSUPID, SUPPLIERNAME FROM [Finance].[dbo].[SUPPLIER] Order by 1";
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
                comboBeneficiery.DisplayMember = "ListItemDesc"; // will display Name property
                comboBeneficiery.ValueMember = "ListItemID"; // will select Value property
                comboBeneficiery.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void PrepareStudentsCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKSTUID, StuFname + ' ' + ISNULL(StuMname,'') + ' ' + ISNULL(StuLname,'') + ' (' + EnrollmentNo + ')' FROM [Finance].[dbo].[Student] WHERE FkStuDeptID = " + comboDept.SelectedValue + " Order by 1";
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
                comboBeneficiery.DisplayMember = "ListItemDesc"; // will display Name property
                comboBeneficiery.ValueMember = "ListItemID"; // will select Value property
                comboBeneficiery.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void PrepareEmployeesCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKEMPID, EMPFNAME + ' ' + ISNULL(EMPMNAME,'') + ' ' + ISNULL(EMPLNAME,'') + ' (' + EMPIDCardNo + ')' FROM [Finance].[dbo].[EMP] WHERE FKEmpPostDeptID = " + comboDept.SelectedValue + " Order by 1";
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
                comboBeneficiery.DisplayMember = "ListItemDesc"; // will display Name property
                comboBeneficiery.ValueMember = "ListItemID"; // will select Value property
                comboBeneficiery.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void PreparecomboBillTypeSub()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] WHERE GEMID = 2 Order by 1";
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
                comboBillTypeSub.DisplayMember = "ListItemDesc"; // will display Name property
                comboBillTypeSub.ValueMember = "ListItemID"; // will select Value property
                comboBillTypeSub.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void Preparebudgetactype()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] where GEMID = 5 Order by 2";
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
                comboBudgetACTYPE.DisplayMember = "ListItemDesc"; // will display Name property
                comboBudgetACTYPE.ValueMember = "ListItemID"; // will select Value property
                comboBudgetACTYPE.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void PrepareBillTypeCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT PKGEM, GEMDESC FROM [Finance].[dbo].[GENMST] WHERE GEMID = 4 Order by 1";
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
                comboBillType.DisplayMember = "ListItemDesc"; // will display Name property
                comboBillType.ValueMember = "ListItemID"; // will select Value property
                comboBillType.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void PrepareDeptCombo()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT DeptId, DeptName FROM [Finance].[dbo].[Department] Order by 1";
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
                comboDept.DisplayMember = "ListItemDesc"; // will display Name property
                comboDept.ValueMember = "ListItemID"; // will select Value property
                comboDept.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";

            if (Convert.ToString(comboDept.SelectedValue) == "0")
            {
                validationMessage = "Please Select Department\n";
                validationResult = false;
            }
            if (Convert.ToString(comboBillType.SelectedValue) == "0")
            {
                validationMessage += "Please Select Bill Type.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboBeneficiery.SelectedValue) == "0")
            {
                validationMessage += "Please Select Beneficiery.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboBillStatus.SelectedValue) != "5")
            {
                validationMessage += "Bill Status can only be 'Send to Accounts' at this Stage.\n";
                validationResult = false;
            }
            if (txtBillNarration.Text.Length <= 0)
            {
                validationMessage += "Please provide some narration for Bill.\n";
                validationResult = false;
            }
            if (Convert.ToString(comboAccountName.SelectedValue) == "0")
            {
                validationMessage += "Please select Account Name.\n";
                validationResult = false;
            }
            if (txtBillAmount.Text.Length <= 0)
            {
                validationMessage += "Please provide value for amount.\n";
                validationResult = false;
            }

            if (txtBillAmount.Text != "")
            {
                if (Convert.ToInt32(txtBillAmount.Text) > Convert.ToInt32(txtAccountBalance.Text))
                {
                    validationMessage += "Amount is exceed from balance amount.\n";
                    validationResult = false;
                }
            }

            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Bill Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        #endregion

        #region // DML
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void comboAccountName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAccountName.SelectedIndex != 0)
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);
                string sqlcommad1 = "Select RBECY FROM [dbo].[BudgetWithAccounts] where PKACID = '" + comboAccountName.SelectedValue + "' AND PKFYID ='" + comboFY.SelectedValue + "' and DeptId = '" + comboDept.SelectedValue + "'";
                SqlCommand objsqlCommand1 = new SqlCommand(sqlcommad1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    SqlDataReader objDataReader1 = objsqlCommand1.ExecuteReader();
                    while (objDataReader1.Read())
                    {
                        if (!objDataReader1[0].Equals(DBNull.Value))
                        {
                            BilledAmount = Convert.ToInt32(objDataReader1[0]);
                            break;
                        }
                        else
                        {
                            BilledAmount = 0;
                        }
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
                calculatespentamount();
                txtAccountBalance.Text = (BilledAmount - spendamount).ToString();
            }
        }

        private void comboACID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnClear.Enabled = true;
            txtPKBillID.Text = comboACID.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtBillNumber.Text = comboACID.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtBillNarration.Text = comboACID.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            comboDept.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[6].FormattedValue.ToString());
            comboBillType.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[9].FormattedValue.ToString());
            if (comboACID.Rows[e.RowIndex].Cells[9].FormattedValue.ToString() != "Advance Payment")
            {
                if ((comboACID.Rows[e.RowIndex].Cells[4].FormattedValue.ToString()) != "")
                {
                    comboBillTypeSub.SelectedIndex = 3;
                    comboBeneficiery.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                }
                if (comboACID.Rows[e.RowIndex].Cells[5].FormattedValue.ToString() != "")
                {
                    comboBillTypeSub.SelectedIndex = 2;
                    comboBeneficiery.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
                }
                if (comboACID.Rows[e.RowIndex].Cells[7].FormattedValue.ToString() != "")
                {
                    comboBillTypeSub.SelectedIndex = 4;
                    comboBeneficiery.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
                }
            }
            else
            {
                if (comboACID.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() != "")
                {
                    comboBillTypeSub.SelectedIndex = 0;
                    comboBeneficiery.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
                }
            }
            comboBillStatus.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[8].FormattedValue.ToString());

            if (FKACID != 117)
            {
                comboBudgetACTYPE.SelectedIndex = 1;
                comboFY.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[13].FormattedValue.ToString());
                comboSL1.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[14].FormattedValue.ToString());
                comboSL2.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[15].FormattedValue.ToString());
                comboSL3.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[16].FormattedValue.ToString());
            }
            else if (FKACID == 117)
            {
                comboBudgetACTYPE.SelectedIndex = 2;
                comboFY.SelectedValue = Convert.ToInt32(comboACID.Rows[e.RowIndex].Cells[13].FormattedValue.ToString());
                comboSL1.SelectedValue = 26;
                comboSL2.SelectedValue = 138;
                comboSL3.SelectedValue = 197;
            }
            comboAccountName.SelectedValue = FKACID;
            comboAccountName_SelectedIndexChanged(null, null);
            calculatespentamount();
            calculatecurrent();
            txtAccountBalance.Text = ((BilledAmount - spendamount) + currentspentamount).ToString();
            txtBillAmount.Text = currentspentamount.ToString();
            LockKeys();
            printVoucher = true;
            retrievedForUpdate = true;

        }

        private void LockKeys()
        {
            comboFY.Enabled = false;
            comboDept.Enabled = false;
            comboSL1.Enabled = false;
            comboSL2.Enabled = false;
            comboSL3.Enabled = false;
        }

        private void calculatecurrent()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String           

            string selectCommand = "Select FKACID,Amount FROM [dbo].[BillDtl] where " +
                "FKBillID = '" + txtPKBillID.Text + "'";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader cmd = objSelectCommand.ExecuteReader();
                if (cmd.Read())
                {
                    FKACID = Convert.ToInt32(cmd["FKACID"]);
                    currentspentamount = Convert.ToInt32(cmd["Amount"]);
                }
                else
                {
                    FKACID = 0;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            ClearTemplate();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder SearchStatement = new StringBuilder();
            try
            {
                SearchStatement.Clear();
                if (txtBillNumberSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("BillNumber like '%" + txtBillNumberSearch.Text + "%'");
                }

                if (txtBillNarrationSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("BillNarration like '%" + txtBillNarrationSearch.Text + "%'");
                }
                //Refresh DGV 

                if (dateTimePicker1.Value == dateTimePicker2.Value)
                {
                    billMstBindingSource.Filter = SearchStatement.ToString();
                }
                else
                {
                    billMstBindingSource.Filter = "BillCreatedOn >= '" + dateTimePicker1.Value + "' And " + "BillCreatedOn <= '" + dateTimePicker2.Value + "'";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exception");
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            billMstBindingSource.Filter = "";
            txtBillNumberSearch.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void ClearTemplate()
        {

            comboDept.SelectedValue = 0;
            comboBillType.SelectedValue = 0;
            comboBeneficiery.SelectedValue = 0;
            comboBillStatus.SelectedValue = 0;
            comboBillTypeSub.Enabled = false;
            comboBillTypeSub.SelectedIndex = 0;
            comboBillType.Enabled = true;
            txtBillNarration.Text = "";
            retrievedForUpdate = false;
            queryMode = false;
            comboAccountName.SelectedIndex = 0;
            comboBudgetACTYPE.SelectedIndex = 0;
            comboFY.SelectedIndex = 0;
            txtBillAmount.Text = "";
            txtAccountBalance.Text = "";
            txtBillNumber.Text = "";
            txtPKBillID.Text = "";
            comboSL1.SelectedValue = 0;
            comboSL2.SelectedValue = 0;
            comboSL3.SelectedValue = 0;
            comboDept.Enabled = true;
            comboFY.Enabled = true;
            comboDept.Enabled = true;
            comboSL1.Enabled = true;
            comboSL2.Enabled = true;
            comboSL3.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printVoucher)
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);
                //Prepare Update String

                string selectCommand = "Select d.DeptName, b.BECY, f.SL2Name, f.SL3Name, g.FYName " +
                                           "from  BillMst a, Budget b,  Department d, BillDtl e, BudgetWithAccounts f, FinancialYear g  " +
                                           "where  a.FKDepID = d.DeptId and a.BillNumber = '" + txtBillNumber.Text + "' AND e.FKACID = b.FKACID  and e.FKFYID = b.FKFYID and e.FKBillID = a.PKBillID AND e.FKACID = f.PKACID AND E.FKFYID = G.PKFYID";
                List<VoucherPrint> objvoucherClass = new List<VoucherPrint>();

                SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                    while (objDataReader.Read())
                    {
                        BECY = Convert.ToInt32(objDataReader[1].ToString());
                        objvoucherClass.Add(new VoucherPrint(objDataReader[0].ToString(), Convert.ToInt32(objDataReader[1]), objDataReader[2].ToString(), objDataReader[3].ToString(), objDataReader[4].ToString()));
                        break;
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
                calculatespentamount();
                frmVoucherPrintHelp objectsupport = new frmVoucherPrintHelp(objvoucherClass, BilledAmount, currentspentamount);
                objectsupport.ShowDialog();
            }
            else
                MessageBox.Show("Please Select the DataGridView ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            printVoucher = false;
        }

        private void calculatespentamount()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String           

            string selectCommand1 = "Select sum(Amount) FROM [dbo].[BillDtl] where FKACID = '" + comboAccountName.SelectedValue + "' AND FKFYID ='" + comboFY.SelectedValue + "'";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand1, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    if (!objDataReader[0].Equals(DBNull.Value))
                    {
                        spendamount = Convert.ToInt32(objDataReader[0]);
                        break;
                    }
                    else
                    {
                        spendamount = 0;
                    }
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
                    //Get Value for BillNumber
                    string sqlCommand = "Select Count(PKBillID) FROM [dbo].[BillMst] where year(BillCreatedOn) = " + today.ToString("yyyy");
                    SqlCommand objsqlCommand = new SqlCommand(sqlCommand, objSqlConnection);

                    //Prepare for record addition

                    SqlCommand objSqlCmd = new SqlCommand("BillAddorEdit", objSqlConnection);
                    objSqlCmd.CommandType = CommandType.StoredProcedure;
                    SetCommandParameters(ref objSqlCmd);
                    try
                    {
                        objSqlConnection.Open();
                        if (txtPKBillID.Text == "0")
                        {
                            txtBillNumber.Text = today.ToString("yyyy") + "/" +
                                                 Convert.ToString((Convert.ToInt32(objsqlCommand.ExecuteScalar()) + 1)).PadLeft(5, '0');
                            objSqlCmd.Parameters.AddWithValue("@BillNumber", txtBillNumber.Text);
                            //objSqlCmd.Parameters.AddWithValue("@PKBillId",  0);
                            txtPKBillID.Text = Convert.ToString(objSqlCmd.ExecuteScalar());
                        }

                        //Add Bill Detail Record 
                        if (Convert.ToInt32(comboAccountName.SelectedValue) >= 0 && txtPKBillID.Text != "0")
                        {
                            SqlCommand objSqlBillDtlCmd = new SqlCommand("BillDtlAddorEdit", objSqlConnection);
                            objSqlBillDtlCmd.CommandType = CommandType.StoredProcedure;

                            objSqlBillDtlCmd.Parameters.Clear();
                            objSqlBillDtlCmd.Parameters.AddWithValue("@PKBillDtlID", 0);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@FKBillID", txtPKBillID.Text);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@FKACID", Convert.ToInt32(comboAccountName.SelectedValue));
                            objSqlBillDtlCmd.Parameters.AddWithValue("@Amount", txtBillAmount.Text);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@BillDtlUpdatedOn", today);
                            objSqlBillDtlCmd.Parameters.AddWithValue("@BillDtlUpdatedBy", "User");
                            objSqlBillDtlCmd.Parameters.AddWithValue("@FKFYID", comboFY.SelectedValue);
                            objSqlBillDtlCmd.ExecuteScalar();

                            MessageBox.Show("Record Added Successfully", "Record Addition Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("PK_BillMst"))
                        {
                            MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBillNarration.Focus();
                        }
                        else if (ex.Message.Contains("Unique_BillNumber"))
                        {
                            MessageBox.Show("Bill Number already exists.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBillNarration.Focus();
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.billMstTableAdapter.Fill(this.financeDataSet23.BillMst);
                }
            }
        }

        private void SetCommandParameters(ref SqlCommand objSqlCommand)
        {
            objSqlCommand.Parameters.AddWithValue("@PKBillId", 0); // Convert.ToInt32(txtPKBillID.Text));
            objSqlCommand.Parameters.AddWithValue("@BillNarration", txtBillNarration.Text);
            objSqlCommand.Parameters.AddWithValue("@FKDepID", comboDept.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@FKBillType", comboBillType.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@FKBillStatus", comboBillStatus.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@BillUpdatedOn", today);
            objSqlCommand.Parameters.AddWithValue("@BillUpdatedBy", "User");
            objSqlCommand.Parameters.AddWithValue("@SL1", comboSL1.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@SL2", comboSL2.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@SL3", comboSL3.SelectedValue);
            objSqlCommand.Parameters.AddWithValue("@FKFYID", comboFY.SelectedValue);


            //If Bill Type is of Employee (11); Assign Beneficiery Combo Value to Employee column
            if (Convert.ToInt32(comboBillType.SelectedValue) == 14 ||
                Convert.ToInt32(comboBillType.SelectedValue) == 15)
            {
                if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 11)
                {
                    objSqlCommand.Parameters.AddWithValue("@FKEmpID", comboBeneficiery.SelectedValue);
                    objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                    objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);
                }
                if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 3)
                {
                    objSqlCommand.Parameters.AddWithValue("@FKEmpID", DBNull.Value);
                    objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                    objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);
                }
                if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 4)
                {
                    objSqlCommand.Parameters.AddWithValue("@FKEmpID", DBNull.Value);
                    objSqlCommand.Parameters.AddWithValue("@FKStuID", comboBeneficiery.SelectedValue);
                    objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);
                }
                if (Convert.ToInt32(comboBillTypeSub.SelectedValue) == 12)
                {
                    objSqlCommand.Parameters.AddWithValue("@FKEmpID", DBNull.Value);
                    objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                    objSqlCommand.Parameters.AddWithValue("@FKSupID", comboBeneficiery.SelectedValue);
                }
            }
            else //If Bill Type is of Medical (3); Assign Beneficiery Combo Value to ............column
            if (Convert.ToInt32(comboBillType.SelectedValue) == 13)
            {
                objSqlCommand.Parameters.AddWithValue("@FKEmpID", comboBeneficiery.SelectedValue);
                objSqlCommand.Parameters.AddWithValue("@FKStuID", DBNull.Value);
                objSqlCommand.Parameters.AddWithValue("@FKSupID", DBNull.Value);
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

                    string updateCommand = "Update [dbo].[BillMst] set BillNarration = @BillNarration, FKDepID = @FKDepID, " +
                                           "FKEmpID = @FKEmpID, FKStuID = @FKStuID, FKSupID = @FKSupID, FKBillStatus = @FKBillStatus, " +
                                            "FKBillType = @FKBillType, BillUpdatedOn=@BillUpdatedOn, SL1=@SL1, SL2=@SL2, SL3=@SL3 where PKBillID = @PKBillID";
                    SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

                    objUpdateCommand.Parameters.AddWithValue("@BillUpdatedOn", today);
                    objUpdateCommand.Parameters.AddWithValue("@PKBillID", txtPKBillID.Text);

                    SetCommandParameters(ref objUpdateCommand);

                    try
                    {
                        objSqlConnection.Open();
                        objUpdateCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully", "Record Update `Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTemplate();
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Message.Contains("PK_BillMst"))
                        {
                            MessageBox.Show("Record already added. Perhaps you want to update.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBillNarration.Focus();
                        }
                        else
                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                    //Refresh DGV 
                    this.billMstTableAdapter.Fill(this.financeDataSet23.BillMst);
                }

            }
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
                    string deleteCommand = "Delete from Finance.dbo.BillMst where PKBillID= @PKBillID;";
                    SqlCommand objDeleteCommand = new SqlCommand(deleteCommand, objSqlConnection);

                    objDeleteCommand.Parameters.AddWithValue("@PKBillID", txtPKBillID.Text);

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
                        this.billMstTableAdapter.Fill(this.financeDataSet23.BillMst);
                    }
                }
            }
            else
            {
                MessageBox.Show("The following error occured: ", "Check the DGF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
