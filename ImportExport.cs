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
    public partial class ImportExport : Form
    {
        string SL1Name, SL2Name, SL3Name;
        int DeptId = 0, ACID = 0;

        public ImportExport()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

        //Instantiate SQL Connection        
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
                    foreach (DataRow row in dtexcel.Rows)
                    {
                        dataGridView.DataSource = dtexcel;
                    }
                    Updateindb();
                    cleartext();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Warning", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Updateindb();
                }

            }
            else
                MessageBox.Show("Please Select the Open", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cleartext()
        {
            tb_path.Text = "";
            dropdown_sheet.SelectedValue = ToString().DefaultIfEmpty() ;
        }

        private void Updateindb()
        {           
            int row = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);

            while (row < dataGridView.Rows.Count - 1)
            {
                SL1Name = dataGridView.Rows[row].Cells[0].FormattedValue.ToString();
                SL2Name = dataGridView.Rows[row].Cells[1].FormattedValue.ToString();
                SL3Name = dataGridView.Rows[row].Cells[2].FormattedValue.ToString();
                DeptId = 0;
                int currentRow = row + 2;

                int test1 = SL1Search();

                int test2 = SL2Serach(test1);


                objSqlConnection.Open();
                SqlCommand myCommand = new SqlCommand("SELECT SL1Name FROM [finance].[dbo].[SL1testing] where SL1Name = '" + SL1Name + "'", objSqlConnection);
                SqlDataReader objDataReader = myCommand.ExecuteReader();

                if (objDataReader.Read())
                {
                    testing1();
                    }
                    else
                    {
                    objSqlConnection.Open();
                    string insertCommand1 = "Insert into [finance].[dbo].[SL1testing] values '" + SL1Name + "'";
                    SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                    try
                    {
                        objInsertCommand1.ExecuteNonQuery();
                        SqlCommand myCommand2 = new SqlCommand("SELECT SL1ID FROM [Finance].[dbo].[SL1testing] where  SL1Name = '" + SL1Name + "'", objSqlConnection);
                        int test = Convert.ToInt32(myCommand2.ExecuteScalar());
                        objSqlConnection.Close();
                        SL2funtion(test);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                objSqlConnection.Open();
                string insertCommand = "Insert into [finance].[dbo].[testingExcell] values ('" + ACID + "', '" + DeptId + "')";
                SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);
                try
                {
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
                row++;

            }
        }

        private int SL2Search(int test)
        {
            return test;
        }

        private int SL1Search()
        {
            int test = 0;
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT SL1Name FROM [finance].[dbo].[SL1testing] where SL1Name = '" + SL1Name + "'", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();

            if (objDataReader.Read())
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL1ID FROM [Finance].[dbo].[SL1testing] where  SL1Name = '" + SL1Name + "'", objSqlConnection);
                SqlDataReader read = myCommand2.ExecuteReader();
                test = Convert.ToInt32(myCommand2.ExecuteReader());
               
            }
            else
            {
                string insertCommand1 = "Insert into [finance].[dbo].[SL1testing] values '" + SL1Name + "'";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT SL1ID FROM [Finance].[dbo].[SL1testing] where  SL1Name = '" + SL1Name + "'", objSqlConnection);
                    test = Convert.ToInt32(myCommand2.ExecuteScalar());
                    SL2funtion(test);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            objSqlConnection.Close();
            return test;
        }

        private void SL2funtion(int SL1ID)
        {
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT SL2ID FROM [finance].[dbo].[SL2testing] where SL1ID = '"+ SL1ID +"' AND SL2Name = '"+ SL2Name +"' ", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();
            if (objDataReader.Read())
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL2ID FROM [Finance].[dbo].[SL2testing] where  SL2Name = '" + SL2Name + "' AND SL1ID = '" + SL1ID + "'", objSqlConnection);
                int test = Convert.ToInt32(myCommand2.ExecuteScalar());
                 objSqlConnection.Close();
                SL3funtion(test);                
            }
            else
            {
                objSqlConnection.Open();
                string insertCommand1 = "Insert into [finance].[dbo].[SL2testing] values('"+SL1ID + "','" + SL2Name + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {                    
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT SL2ID FROM [Finance].[dbo].[SL2testing] where  SL2Name = '" + SL2Name + "' AND SL1ID = '" + SL1ID + "'", objSqlConnection);
                    SL3funtion(Convert.ToInt32(myCommand2.ExecuteScalar()));
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

        private void SL3funtion(int SL2ID)
        {
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT SL3ID FROM [finance].[dbo].[SL3testing] where SL2ID = '" + SL2ID + "' AND SL3Name = '" + SL3Name + "' ", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();
            if (objDataReader.Read())
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL3ID FROM [Finance].[dbo].[SL3testing] where SL2ID = '" + SL2ID + "' AND SL3Name = '" + SL3Name + "' ", objSqlConnection);
                int test = Convert.ToInt32(myCommand2.ExecuteScalar());
                objSqlConnection.Close();
                SLaccountfuntion(test);
            }
            else
            {
                objSqlConnection.Open();
                string insertCommand1 = "Insert into [finance].[dbo].[SL2testing] values('" + SL2ID + "','" + SL3Name + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                {
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT SL3ID FROM [Finance].[dbo].[SL3testing] where  SL2ID = '" + SL2ID + "' AND SL3Name = '" + SL3Name + "' ", objSqlConnection);
                    int test = Convert.ToInt32(myCommand2.ExecuteScalar());
                    objSqlConnection.Close();
                    SLaccountfuntion(test);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SLaccountfuntion(int SL3ID)
        {
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT SL3ID FROM [finance].[dbo].[SL3testing] where SL3ID = '" + SL3ID + "'", objSqlConnection);
            SqlDataReader objDataReader = myCommand.ExecuteReader();
            if (objDataReader.Read())
            {
                SqlCommand myCommand2 = new SqlCommand("SELECT SL3ID FROM [Finance].[dbo].[SL3testing] where SL3ID = '" + SL3ID + "'", objSqlConnection);
                int test = Convert.ToInt32(myCommand2.ExecuteScalar());
                objSqlConnection.Close();
                SLaccountfuntion(test);
            }
            else
            {
                objSqlConnection.Open();
                string insertCommand1 = "Insert into [finance].[dbo].[SL2testing] values('" + SL3ID + "','" + null + "')";
                SqlCommand objInsertCommand1 = new SqlCommand(insertCommand1, objSqlConnection);
                try
                { 
                    objInsertCommand1.ExecuteNonQuery();
                    SqlCommand myCommand2 = new SqlCommand("SELECT SL3ID FROM [Finance].[dbo].[SL3testing] where  SL3ID = '" + SL3ID + "'", objSqlConnection);
                    ACID = Convert.ToInt32(Convert.ToInt32(myCommand2.ExecuteScalar()));
                    objSqlConnection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void TestUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet5.testingExcell' table. You can move, or remove it, as needed.
            this.testingExcellTableAdapter.Fill(this.financeDataSet5.testingExcell);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = txtExport.Text.ToString();

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExport.Text = "";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
