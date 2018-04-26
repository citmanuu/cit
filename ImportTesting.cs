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
    public partial class ImportTesting : Form
    {
        string SL1Name, SL2Name, SL3Name;
        int DeptId = 0, ACID = 0;
        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

        public ImportTesting()
        {
            InitializeComponent();
        }

        private void ImportTesting_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet7.testingview' table. You can move, or remove it, as needed.
            this.testingviewTableAdapter.Fill(this.financeDataSet7.testingview);
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
                    dropdown_sheet.DataSource = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null); // Get sheet Name
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

                    OleDbConnection con = new OleDbConnection(conn);
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select F1 AS SL1Name, F2 AS SL2Name, F3 AS SL3Name from [" + dropdown_sheet.SelectedValue + "]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable 
                    int count = 0;
                    foreach (DataRow row in dtexcel.Rows)
                    {
                        //dataGridView.DataSource = dtexcel;
                        readthestring(dtexcel, count);
                        count++;
                    }
                    cleartext();
                    this.testingviewTableAdapter.Fill(this.financeDataSet7.testingview);
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
        private void readthestring(DataTable abc, int count)
        {
            SL1Name = abc.Rows[count][0].ToString();
            SL2Name = abc.Rows[count][1].ToString();
            SL3Name = abc.Rows[count][2].ToString();
            UpdateDB();
        }

        //update into the database
        private void UpdateDB()
        {
            SqlConnection objSqlConnection = new SqlConnection(cs);
            DeptId = 0;
            int test1 = SL1Search();
            int test2 = SL2Serach(test1);
            int test3 = SL3Search(test2);
            ACID = SLaccountfuntion(test3);



            Int32 test;
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[testingExcell] where ACID = '" + ACID + "'", objSqlConnection);
            objSqlConnection.Open();
            test = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();

            if (test == 0)
            {
                string insertCommand = "Insert into [finance].[dbo].[testingExcell] (ACID , DeptId)values ('" + ACID + "', '" + DeptId + "')";
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
            Int32 test = 0;
            int test1 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[SL1testing] where SL1Name = '" + SL1Name + "'", objSqlConnection);
            objSqlConnection.Open();
            test = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();

            if (test != 0)
            {

                SqlCommand myCommand2 = new SqlCommand("SELECT SL1ID FROM [Finance].[dbo].[SL1testing] where  SL1Name = '" + SL1Name + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    test1 = Convert.ToInt32(cmd["SL1ID"]);
                }
                objSqlConnection.Close();
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL1testing](SL1Name) values('" + SL1Name + "')";
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
                        test1 = Convert.ToInt32(cmd["SL1ID"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return test1;
        }

        //Serach SL2 and insert into the database.
        private int SL2Serach(int test1)
        {

            Int32 test = 0;
            var test2 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[SL2testing] where SL1ID = '" + test1 + "' AND SL2Name = '" + SL2Name + "' ", objSqlConnection);
            objSqlConnection.Open();
            test = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();
            if (test != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL2ID FROM [Finance].[dbo].[SL2testing] where  SL2Name = '" + SL2Name + "' AND SL1ID = '" + test1 + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    test2 = Convert.ToInt32(cmd["SL2ID"]);
                }
                objSqlConnection.Close();
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL2testing] (SL1ID,SL2Name) values('" + test1 + "','" + SL2Name + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT SL2ID FROM [Finance].[dbo].[SL2testing] where  SL2Name = '" + SL2Name + "' AND SL1ID = '" + test1 + "'", objSqlConnection);
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        test2 = Convert.ToInt32(cmd["SL2ID"]);
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
            return test2;
        }

        //Serach SL3 and insert into the database.
        private int SL3Search(int test2)
        {
            Int32 test = 0;
            var test3 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[SL3testing] where SL2ID = '" + test2 + "' AND SL3Name = '" + SL3Name + "' ", objSqlConnection);
            objSqlConnection.Open();
            test = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();
            if (test != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL3ID FROM [Finance].[dbo].[SL3testing] where SL2ID = '" + test2 + "' AND SL3Name = '" + SL3Name + "' ", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    test3 = Convert.ToInt32(cmd["SL3ID"]);
                }
                objSqlConnection.Close();
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL3testing] (SL2ID, SL3Name)values('" + test2 + "','" + SL3Name + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT SL3ID FROM [Finance].[dbo].[SL3testing] where  SL2ID = '" + test2 + "' AND SL3Name = '" + SL3Name + "' ", objSqlConnection);
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        test3 = Convert.ToInt32(cmd["SL3ID"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            objSqlConnection.Close();
            return test3;
        }

        //Serach account function and insert into the database.
        private int SLaccountfuntion(int SL3ID)
        {
            Int32 test = 0;
            int test1 = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            SqlCommand myCommand = new SqlCommand("SELECT count(*) FROM [finance].[dbo].[Accounttesting] where SL3ID = '" + SL3ID + "'", objSqlConnection);
            objSqlConnection.Open();
            test = (Int32)myCommand.ExecuteScalar();
            objSqlConnection.Close();
            if (test != 0)
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT AccountId FROM [Finance].[dbo].[Accounttesting] where SL3ID = '" + SL3ID + "'", objSqlConnection);
                objSqlConnection.Open();
                SqlDataReader cmd = myCommand2.ExecuteReader();
                if (cmd.Read())
                {
                    test1 = Convert.ToInt32(cmd["AccountId"]);
                }
                objSqlConnection.Close();


            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[Accounttesting] (SL3ID,AccountName)values('" + SL3ID + "','" + null + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objSqlConnection.Open();
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT AccountId FROM [Finance].[dbo].[Accounttesting] where  SL3ID = '" + SL3ID + "'", objSqlConnection);
                    SqlDataReader cmd = myCommand2.ExecuteReader();
                    if (cmd.Read())
                    {
                        test1 = Convert.ToInt32(cmd["AccountId"]);
                    }
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            objSqlConnection.Close();
            return test1;
        }

        private void cleartext()
        {
            tb_path.Text = "";
            dropdown_sheet.SelectedValue = ToString().DefaultIfEmpty();
        }
        #endregion
    }
}
