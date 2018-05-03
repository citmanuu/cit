using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class ImportHelp : Form
    {
        string SL1Name, SL2Name, SL3Name, DeptName ;
        int DeptId = 0, FKACID = 0,BECY = 0,RBECY = 0,userId =0;
        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
        public ImportHelp(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ImportTesting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet15.testingview' table. You can move, or remove it, as needed.
            this.testingviewTableAdapter3.Fill(this.financeDataSet15.testingview);
            // TODO: This line of code loads data into the 'financeDataSet14.testingview' table. You can move, or remove it, as needed.
            // this.testingviewTableAdapter2.Fill(this.financeDataSet14.testingview);
            // TODO: This line of code loads data into the 'financeDataSet13.testingview' table. You can move, or remove it, as needed.
            // this.testingviewTableAdapter1.Fill(this.financeDataSet13.testingview);
            // TODO: This line of code loads data into the 'financeDataSet13.testingview' table. You can move, or remove it, as needed.
            //this.testingviewTableAdapter1.Fill(this.financeDataSet13.testingview);
            // TODO: This line of code loads data into the 'financeDataSet7.testingview' table. You can move, or remove it, as needed.
            //this.testingviewTableAdapter.Fill(this.financeDataSet7.testingview);
            preparecomboFY();
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
        #region
        // open the Excel Sheet Loacation for select 
        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.tb_path.Text = openFileDialog.FileName; // get the file Name
                }
                if (tb_path.Text.ToString() != "")
                {
                    string conn = string.Empty;
                    String FileExt = tb_path.Text.Substring(tb_path.Text.LastIndexOf("."));
                    if (FileExt.CompareTo(".xls") == 0)
                        conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + tb_path.Text + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                    else
                        conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_path.Text + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  

                    OleDbConnection con = new OleDbConnection(conn);
                    con.Open();
                    dropdown_sheet.DataSource = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null); // Get worksheet Name
                    dropdown_sheet.DisplayMember = "TABLE_NAME";
                    dropdown_sheet.ValueMember = "TABLE_NAME";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        // Load the Excell file into the database
        private void Load_Click(object sender, EventArgs e)
        {
            if (tb_path.Text.ToString() != "")
            {
                try
                {
                    string conn = string.Empty;
                    DataTable dtexcel = new DataTable();
                    String FileExt = tb_path.Text.Substring(tb_path.Text.LastIndexOf("."));
                    if (FileExt.CompareTo(".xls") == 0)
                        conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + tb_path.Text + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
                    else
                        conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_path.Text + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  

                   // select F1 AS SL1Name, F2 AS SL2Name, F3 AS SL3Name

                    OleDbConnection con = new OleDbConnection(conn);
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select F1 AS DeptName, F2 AS SL1Name, F3 AS SL2Name, F4 AS SL3Name, F5 AS BECY, F6 AS RBECY  from [" + dropdown_sheet.SelectedValue + "]", con); //here we read data from workSheet  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable 
                    int count = 0;
                    foreach (DataRow row in dtexcel.Rows)
                    {
                        readthestring(dtexcel, count);
                        count++;
                    }
                    cleartext();
                    this.testingviewTableAdapter3.Fill(this.financeDataSet15.testingview);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Warning", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Please Select the Open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // read the string and store into the stirng 
        private void readthestring(DataTable exceldata, int count)
        {
            DeptName = exceldata.Rows[count][0].ToString().ToUpper();
            SL1Name = exceldata.Rows[count][1].ToString().ToUpper();
            SL2Name = exceldata.Rows[count][2].ToString().ToUpper();
            SL3Name = exceldata.Rows[count][3].ToString().ToUpper();
            BECY = Convert.ToInt32(exceldata.Rows[count][4].ToString());
            RBECY = Convert.ToInt32(exceldata.Rows[count][5].ToString());           
            UpdateDB();
        }

        //update into the database
        private void UpdateDB()
        {
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT DeptId FROM [finance].[dbo].[Department] where DeptName = '" + DeptName + "'", objSqlConnection);
            SqlDataReader cmd = myCommand.ExecuteReader();
           
            if (cmd.Read())
            {
                DeptId = Convert.ToInt32(cmd["DeptId"]);
            }
            objSqlConnection.Close();
            if (DeptId == 0)
            {
                string insertCommand = "Insert into [finance].[dbo].[Department] (DeptName,DeptDescription)values ('" + DeptName + "', NULL)";
                SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }

                objSqlConnection.Open();
                SqlCommand Command = new SqlCommand("SELECT DeptId FROM [finance].[dbo].[Department] where DeptName = '" + DeptName + "'", objSqlConnection);
                SqlDataReader cmddept = Command.ExecuteReader();
               
                if (cmd.Read())
                {
                    DeptId = Convert.ToInt32(cmd["DeptId"]);
                }
                objSqlConnection.Close();
            }

            objSqlConnection.Close();
            int SL1ID = SL1Search();
            int PKSL2ID = SL2Serach(SL1ID);
            int PKSL3 = SL3Search(SL1ID, PKSL2ID);
            FKACID = SLaccountfuntion(PKSL3);



            Int32 budgetId = 0;
            SqlCommand myCommand1 = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[testingExcell] where FKACID = '" + FKACID + "'", objSqlConnection);
            objSqlConnection.Open();
            budgetId = (Int32)myCommand1.ExecuteScalar();
            objSqlConnection.Close();
            if (budgetId == 0)
            {
                string insertCommand = "Insert into [finance].[dbo].[testingExcell] (FKFYID,FKACID ,BECY,RBECY, AddedOn,UpdatedOn, UpdatedBy,FKDeptId)values ('" + comboFY.SelectedValue + "','" + FKACID + "','" + BECY + "','" + RBECY + "','" + DateTime.Now + "','" + DateTime.Now + "','" + userId + "','" + DeptId + "')";
                SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
            }

        }

        //private void Updateindb()
        //{
        //    int row = 0;
        //    SqlConnection objSqlConnection = new SqlConnection(cs);

        //    while (row < dataGridView.Rows.Count - 1)
        //    {
        //        SL1Name = dataGridView.Rows[row].Cells[0].FormattedValue.ToString();
        //        SL2Name = dataGridView.Rows[row].Cells[1].FormattedValue.ToString();
        //        SL3Name = dataGridView.Rows[row].Cells[2].FormattedValue.ToString();
        //        DeptId = 0;
        //        int currentRow = row + 2;

        //        int test1 = SL1Search();
        //        int test2 = SL2Serach(test1);
        //        int test3 = SL3Search(test2);
        //        ACID = SLaccountfuntion(test3);



        //        Int32 test;
        //        SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[testingExcell] where ACID = '" + ACID + "'", objSqlConnection);
        //        objSqlConnection.Open();
        //        test = (Int32)myCommand.ExecuteScalar();
        //        objSqlConnection.Close();

        //        if (test == 0)
        //        {
        //            string insertCommand = "Insert into [finance].[dbo].[testingExcell] (ACID , DeptId)values ('" + ACID + "', '" + DeptId + "')";
        //            SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);
        //            try
        //            {
        //                objSqlConnection.Open();
        //                objInsertCommand.ExecuteNonQuery();
        //            }
        //            catch (SqlException ex)
        //            {
        //                MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            finally
        //            {
        //                objSqlConnection.Close();
        //            }
        //        }

        //        row++;

        //    }
        //}


       //Serach SL1 and insert into the database.

        private int SL1Search()
        {
            Int32 SL1 = 0;
            int SL11 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[SL1testing] where SL1Name = '" + SL1Name + "'", objSqlConnection);
            SL1 = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();

            if (SL1 != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL1ID FROM [Finance].[dbo].[SL1testing] where  SL1Name = '" + SL1Name + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    SL11 = Convert.ToInt32(cmd["SL1ID"]);
                }
                objSqlConnection.Close();
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL1testing](SL1Name,SL1AddedOn,SL1UpdatedOn,SL1UpdatedBy, DeptId) values('" + SL1Name.ToUpper() + "', '"+ DateTime.Now + "','" + DateTime.Now + "','" + userId+"','"+ DeptId + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    objSqlConnection.Close();

                    SqlCommand myCommand2 = new SqlCommand("SELECT SL1ID FROM [Finance].[dbo].[SL1testing] where  SL1Name = '" + SL1Name + "'", objSqlConnection);
                    objSqlConnection.Open();
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        SL11 = Convert.ToInt32(cmd["SL1ID"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return SL11;
        }

        //Serach SL2 and insert into the database.
        private int SL2Serach(int SL1ID)
        {

            Int32 SL2 = 0;
            var SL22 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[SL2testing] where SL1ID = '" + SL1ID + "' AND SL2Name = '" + SL2Name + "' ", objSqlConnection);
            SL2 = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();
            if (SL2 != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT PKSL2ID FROM [Finance].[dbo].[SL2testing] where  SL2Name = '" + SL2Name + "' AND SL1ID = '" + SL1ID + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    SL22 = Convert.ToInt32(cmd["PKSL2ID"]);
                }
                objSqlConnection.Close();
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL2testing] (SL1ID,SL2Name,SL2AddedOn,SL2UpdatedOn,SL2UpdateBy) values('" + SL1ID + "','" + SL2Name.ToUpper() + "','"+ DateTime.Now + "','" + DateTime.Now + "','" + userId +"')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT PKSL2ID FROM [Finance].[dbo].[SL2testing] where  SL2Name = '" + SL2Name + "' AND SL1ID = '" + SL1ID + "'", objSqlConnection);
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        SL22 = Convert.ToInt32(cmd["PKSL2ID"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
            return SL22;
        }

        //Serach SL3 and insert into the database.
        private int SL3Search(int SL1ID, int PKSL2ID)
        {
            Int32 SL3 = 0;
            var SL33 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[SL3testing] where FKSL2ID = '" + PKSL2ID + "' AND SL3Name = '" + SL3Name + "' AND FKSL1ID = '" + SL1ID + "'", objSqlConnection);
            SL3 = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();
            if (SL3 != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT PKSL3ID FROM [Finance].[dbo].[SL3testing] where FKSL2ID = '" + PKSL2ID + "' AND SL3Name = '" + SL3Name + "' AND FKSL1ID = '" + SL1ID + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    SL33 = Convert.ToInt32(cmd["PKSL3ID"]);
                }
                objSqlConnection.Close();
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL3testing] (FKSL1ID, FKSL2ID, SL3Name,SL3AddedOn, SL3UpdatedOn, SL3UpdatedBy )values('" + SL1ID + "','" + PKSL2ID + "', '" + SL3Name.ToUpper() + "', '" + DateTime.Now + "','" + DateTime.Now + "','" + userId + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT PKSL3ID FROM [Finance].[dbo].[SL3testing] where  FKSL2ID = '" + PKSL2ID + "' AND SL3Name = '" + SL3Name + "'AND FKSL1ID = '" + SL1ID + "' ", objSqlConnection);
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        SL33 = Convert.ToInt32(cmd["PKSL3ID"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            objSqlConnection.Close();
            return SL33;
        }

        //Serach account function and insert into the database.
        private int SLaccountfuntion(int PKSL3)
        {
            Int32 SL3 = 0;
            int SL33 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[Accounttesting] where FKSL3ID = '" + PKSL3 + "'", objSqlConnection);
            SL3 = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();
            if (SL3 != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT PKACID FROM [Finance].[dbo].[Accounttesting] where FKSL3ID = '" + PKSL3 + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    SL33 = Convert.ToInt32(cmd["PKACID"]);
                }
                objSqlConnection.Close();


            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[Accounttesting] (FKSL3ID,AccountAddedOn,AccountUpdatedOn, AccountUpdatedBy, DeptId)values('" + PKSL3 + "','" + DateTime.Now + "','" + DateTime.Now + "','" + userId + "','" + DeptId + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT PKACID FROM [Finance].[dbo].[Accounttesting] where  FKSL3ID = '" + PKSL3 + "'", objSqlConnection);
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        SL33 = Convert.ToInt32(cmd["PKACID"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            objSqlConnection.Close();
            return SL33;
        }

        private void cleartext()
        {
            tb_path.Text = "";
            dropdown_sheet.SelectedValue = ToString().DefaultIfEmpty();
        }
        #endregion
    }
}
