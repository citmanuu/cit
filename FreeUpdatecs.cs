using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class FreeUpdatecs : Form
    {
        public FreeUpdatecs()
        {
            InitializeComponent();
        }

        public DataTable ReadExcel(string FileName, string FileExt)
        {

            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (FileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  

            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Payment Records$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error occured " + ex.Message, "Read Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dtexcel;

        }

        private void ReconclieFee()
        {
            //Read First Line
            String BillerId, BankId, BankRefNo, PGIRefNo, Ref1, Ref2, Ref3, Ref4, Ref5, Ref6, Ref7, Ref8, DateofTxn, Amount, Status;
            String PaymentStatus = "", OnlinePaymentId = "";
            int row = 0;
            int refunds = 0, updates = 0;

            //Connection String
            //string cs = @"c:\C:\Users\Acer\Documents\MANUU\Technical\Refund.xlsx"; ;
            //cs = System.Configuration.ConfigurationManager.ConnectionStrings["OnlineAdmission"].ConnectionString;
            //conString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"].ToString();
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection("Data Source=14.139.86.75;Initial Catalog=OnlineAdmission;Persist Security Info=True;User ID=**;Password=*****");

            while (row < dataGridView.Rows.Count - 1)
            {
                PaymentStatus = "";
                BillerId = dataGridView.Rows[row].Cells[0].FormattedValue.ToString();
                BankId = dataGridView.Rows[row].Cells[1].FormattedValue.ToString();
                BankRefNo = dataGridView.Rows[row].Cells[2].FormattedValue.ToString();
                PGIRefNo = dataGridView.Rows[row].Cells[3].FormattedValue.ToString();
                Ref1 = dataGridView.Rows[row].Cells[4].FormattedValue.ToString();
                Ref2 = dataGridView.Rows[row].Cells[5].FormattedValue.ToString();
                Ref3 = dataGridView.Rows[row].Cells[6].FormattedValue.ToString();
                Ref4 = dataGridView.Rows[row].Cells[7].FormattedValue.ToString();
                Ref5 = dataGridView.Rows[row].Cells[8].FormattedValue.ToString();
                Ref6 = dataGridView.Rows[row].Cells[9].FormattedValue.ToString();
                Ref7 = dataGridView.Rows[row].Cells[10].FormattedValue.ToString();
                Ref8 = dataGridView.Rows[row].Cells[11].FormattedValue.ToString();
                DateofTxn = dataGridView.Rows[row].Cells[12].FormattedValue.ToString();
                Amount = dataGridView.Rows[row].Cells[13].FormattedValue.ToString();
                Status = dataGridView.Rows[row].Cells[14].FormattedValue.ToString();
                int currentRow = row + 2;
                //Update Admission Fee
                if (Ref3 == "REG-ADM" && Status.ToUpper() == "SUCCESS")
                {
                    //Find Status of Fee in respect of this candidate
                    string selectCommand = "Select [PaymentStatus], [OnlinePaymentId] from [OnlineAdmission].[dbo].[AdmissionCourse] " +
                                           "where ApplicationNo = '" + Ref2 + "'";
                    SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
                    try
                    {
                        objSqlConnection.Open();
                        SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                        while (objDataReader.Read())
                        {
                            PaymentStatus = Convert.ToString(objDataReader[0]);
                            OnlinePaymentId = Convert.ToString(objDataReader[1]);
                        }
                        objSqlConnection.Close();
                        //Case-I: Fee status is pending in Database and is to be updated
                        if (PaymentStatus.ToUpper() != "SUCCESS")
                        {
                            //Update AdmissionCourse Table
                            UpdateFeeStatus(Amount, DateofTxn, Ref1, Ref2);

                            //Update OnlinePayment Table
                            UpdateOnlinePayment(Ref1, Ref2, DateofTxn, PGIRefNo, BankRefNo);

                            //Add Record to Update Excel File
                            AddUpdateRecord(BillerId, BankId, BankRefNo, PGIRefNo, Ref1, Ref2, Ref3, Ref4, Ref5, Ref6, Ref7, Ref8, DateofTxn, Amount, Status);
                            updates++;
                        }
                        else if (PaymentStatus.ToUpper() == "SUCCESS" && OnlinePaymentId != Ref1)
                        {
                            //Refund Record in Excel File
                            AddRefundRecord(BillerId, BankId, BankRefNo, PGIRefNo, Ref1, Ref2, Ref3, Ref4, Ref5, Ref6, Ref7, Ref8, DateofTxn, Amount, Status);

                            //Add Refund Record in RefundTable
                            AddRefundRecordinDB(BillerId, BankId, BankRefNo, PGIRefNo, Ref1, Ref2, Ref3, Ref4, Ref5, Ref6, Ref7, Ref8, DateofTxn, Amount, Status);

                            refunds++;
                        }
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
                //MessageBox.Show("Row no is: " + currentRow + " Ref5 = " + Ref5) ;
                row++;
            }
        }


        private void UpdateFeeStatus(string amount, string dateofTxn, string ref1, string ref2)
        {
            SqlConnection objSqlConnection = new SqlConnection("Data Source=14.139.86.75;Initial Catalog=OnlineAdmission;Persist Security Info=True;User ID=**;Password=******");

            string updateCommand = "Update [OnlineAdmission].[dbo].[AdmissionCourse] set AmountPaid = " + amount + ", FeeDate = CONVERT(datetime, '" + dateofTxn + "', 105)" +
                                   ", OnlinePaymentId = '" + ref1 + "', PaymentStatus = 'SUCCESS', PaymentMode = 'Online' " +
                                   " where ApplicationNo = '" + ref2 + "'";
            SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

            objUpdateCommand.Parameters.AddWithValue("@amount", Convert.ToDecimal(amount));
            objUpdateCommand.Parameters.AddWithValue("@dateofTxn", dateofTxn);
            objUpdateCommand.Parameters.AddWithValue("@ref1", ref1);
            objUpdateCommand.Parameters.AddWithValue("@ref2", ref2);
            MessageBox.Show(updateCommand);
            try
            {
                objSqlConnection.Open();
                objUpdateCommand.ExecuteNonQuery();
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

        private void UpdateOnlinePayment(string ref1, string ref2, string DateofTxn, string PGIRefNo, string BankRefNo)
        {
            SqlConnection objSqlConnection = new SqlConnection("Data Source=14.139.86.75;Initial Catalog=CEO2111;Persist Security Info=True;User ID=**;Password=*****");

            string updateCommand = "Update [CEO2111].[dbo].[OnlinePayment] set Status = 'SUCCESS', TxnDate = Convert(DateTime, '" + DateofTxn + "', 105), " +
                                    "TxnReferenceNo = '" + PGIRefNo + "', BankReferenceNo = '" + BankRefNo + "' " +
                                    "where FormId = '" + ref2 + "' and [TxnID] = '" + ref1 + "'";
            SqlCommand objUpdateCommand = new SqlCommand(updateCommand, objSqlConnection);

            objUpdateCommand.Parameters.AddWithValue("@ref1", ref1);
            objUpdateCommand.Parameters.AddWithValue("@ref2", ref2);
            try
            {
                objSqlConnection.Open();
                objUpdateCommand.ExecuteNonQuery();
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


        private void AddRefundRecord(string billerId, string bankId, string bankRefNo, string pGIRefNo, string ref1, string ref2, string ref3, string ref4, string ref5, string ref6, string ref7, string ref8, string dateofTxn, string amount, string status)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook worKbooK;
            Microsoft.Office.Interop.Excel.Worksheet worKsheeT;
            Microsoft.Office.Interop.Excel.Range celLrangE;

            //Check if Refund File Already Exists; If Not Create it
            DateTime today = DateTime.Today;
            string RefundFile = @"C:\Users\Acer\Documents\MANUU\Technical\RefundFile-" + today.ToString("dd-MM-yyyy") + ".xlsx";
            int row = 0;
            int col = 0;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                worKbooK = excel.Workbooks.Add(Type.Missing);


                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "Refund Records";

                if (!File.Exists(RefundFile)) //File Does Not Exist; Create Fiel and add Header
                {
                    //worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 8]].Merge();
                    worKsheeT.Cells[1, 1] = "Biller Id";
                    worKsheeT.Cells[1, 2] = "Bank Id Bank";
                    worKsheeT.Cells[1, 3] = "Ref.No.";
                    worKsheeT.Cells[1, 4] = "PGI Ref.No.";
                    worKsheeT.Cells[1, 5] = "Ref.1";
                    worKsheeT.Cells[1, 6] = "Ref.2";
                    worKsheeT.Cells[1, 7] = "Ref.3";
                    worKsheeT.Cells[1, 8] = "Ref.4";
                    worKsheeT.Cells[1, 9] = "Ref.5";
                    worKsheeT.Cells[1, 10] = "Ref.6";
                    worKsheeT.Cells[1, 11] = "Ref.7";
                    worKsheeT.Cells[1, 12] = "Ref.8";
                    worKsheeT.Cells[1, 13] = "Date of Txn";
                    worKsheeT.Cells[1, 14] = "Amount(Rs.Ps)";
                    worKsheeT.Cells[1, 15] = "Status";
                    //                    worKsheeT.Cells.Font.Size = 15;
                    worKbooK.SaveAs(RefundFile); ;
                    worKbooK.Close();
                    excel.Quit();

                }
                //Open file to write record
                worKbooK = excel.Workbooks.Open(RefundFile, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                // worKsheeT = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                celLrangE = worKsheeT.UsedRange;
                row = celLrangE.Rows.Count;
                col = celLrangE.Columns.Count;
                row = row + 1;

                /*    for (rCnt = 1; rCnt <= rw; rCnt++)
                    {
                        for (cCnt = 1; cCnt <= cl; cCnt++)
                        {
                            String str = (string)(celLrangE.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2;
                            //MessageBox.Show(str);
                        }
                    }
                    */
                //Add record to the Refund File
                worKsheeT.Cells[row, 1] = billerId;
                worKsheeT.Cells[row, 2] = bankId;
                worKsheeT.Cells[row, 3] = bankRefNo;
                worKsheeT.Cells[row, 4] = pGIRefNo;
                worKsheeT.Cells[row, 5] = ref1;
                worKsheeT.Cells[row, 6] = ref2;
                worKsheeT.Cells[row, 7] = ref3;
                worKsheeT.Cells[row, 8] = ref4;
                worKsheeT.Cells[row, 9] = ref5;
                worKsheeT.Cells[row, 10] = ref6;
                worKsheeT.Cells[row, 11] = ref7;
                worKsheeT.Cells[row, 12] = ref8;
                worKsheeT.Cells[row, 13] = dateofTxn;
                worKsheeT.Cells[row, 14] = amount;
                worKsheeT.Cells[row, 15] = status;
                worKbooK.Close(true, null, null);
                excel.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                worKsheeT = null;
                celLrangE = null;
                worKbooK = null;
            }
        }


        private void AddUpdateRecord(string billerId, string bankId, string bankRefNo, string pGIRefNo, string ref1, string ref2, string ref3, string ref4, string ref5, string ref6, string ref7, string ref8, string dateofTxn, string amount, string status)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook worKbooK;
            Microsoft.Office.Interop.Excel.Worksheet worKsheeT;
            Microsoft.Office.Interop.Excel.Range celLrangE;

            //Check if Refund File Already Exists; If Not Create it
            DateTime today = DateTime.Today;
            string RefundFile = @"C:\Users\Acer\Documents\MANUU\Technical\UpdateFile-" + today.ToString("dd-MM-yyyy") + ".xlsx";
            int row = 0;
            int col = 0;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                worKbooK = excel.Workbooks.Add(Type.Missing);


                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "Updated Records";

                if (!File.Exists(RefundFile)) //File Does Not Exist; Create Fiel and add Header
                {
                    //worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 8]].Merge();
                    worKsheeT.Cells[1, 1] = "Biller Id";
                    worKsheeT.Cells[1, 2] = "Bank Id Bank";
                    worKsheeT.Cells[1, 3] = "Ref.No.";
                    worKsheeT.Cells[1, 4] = "PGI Ref.No.";
                    worKsheeT.Cells[1, 5] = "Ref.1";
                    worKsheeT.Cells[1, 6] = "Ref.2";
                    worKsheeT.Cells[1, 7] = "Ref.3";
                    worKsheeT.Cells[1, 8] = "Ref.4";
                    worKsheeT.Cells[1, 9] = "Ref.5";
                    worKsheeT.Cells[1, 10] = "Ref.6";
                    worKsheeT.Cells[1, 11] = "Ref.7";
                    worKsheeT.Cells[1, 12] = "Ref.8";
                    worKsheeT.Cells[1, 13] = "Date of Txn";
                    worKsheeT.Cells[1, 14] = "Amount(Rs.Ps)";
                    worKsheeT.Cells[1, 15] = "Status";
                    //                    worKsheeT.Cells.Font.Size = 15;
                    worKbooK.SaveAs(RefundFile); ;
                    worKbooK.Close();
                    excel.Quit();

                }
                //Open file to write record
                worKbooK = excel.Workbooks.Open(RefundFile, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                // worKsheeT = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                celLrangE = worKsheeT.UsedRange;
                row = celLrangE.Rows.Count;
                col = celLrangE.Columns.Count;
                row = row + 1;
                //Add record to the Refund File
                worKsheeT.Cells[row, 1] = billerId;
                worKsheeT.Cells[row, 2] = bankId;
                worKsheeT.Cells[row, 3] = bankRefNo;
                worKsheeT.Cells[row, 4] = pGIRefNo;
                worKsheeT.Cells[row, 5] = ref1;
                worKsheeT.Cells[row, 6] = ref2;
                worKsheeT.Cells[row, 7] = ref3;
                worKsheeT.Cells[row, 8] = ref4;
                worKsheeT.Cells[row, 9] = ref5;
                worKsheeT.Cells[row, 10] = ref6;
                worKsheeT.Cells[row, 11] = ref7;
                worKsheeT.Cells[row, 12] = ref8;
                worKsheeT.Cells[row, 13] = dateofTxn;
                worKsheeT.Cells[row, 14] = amount;
                worKsheeT.Cells[row, 15] = status;
                worKbooK.Close(true, null, null);
                excel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                worKsheeT = null;
                celLrangE = null;
                worKbooK = null;
            }
        }

        private void AddRefundRecordinDB(string billerId, string bankId, string bankRefNo, string pGIRefNo, string ref1, string ref2, string ref3, string ref4, string ref5, string ref6, string ref7, string ref8, string dateofTxn, string amount, string status)
        {
            DateTime today = DateTime.Today;

            SqlConnection objSqlConnection = new SqlConnection("Data Source=14.139.86.75;Initial Catalog=CEO2111;Persist Security Info=True;User ID=**;Password=*****");

            string insertCommand = "Insert into [CEO2111].[dbo].[OnlineRefund] values ('" + billerId + "', '" + bankId + "','" + bankRefNo + "','" +
            pGIRefNo + "','" + ref1 + "','" + ref2 + "','" + ref3 + "','" + ref4 + "','" + ref5 + "','" + ref6 + "','" + ref7 + "','" + ref8 +
            "', convert(datetime, '" + dateofTxn + "', 105), " + amount + ",convert(datetime, '" + today.ToString("dd-MM-yyyy") + "', 105), 'Check with BillDesk')";

            SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);

            try
            {
                objSqlConnection.Open();
                objInsertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message + "     " + insertCommand, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                objSqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            System.Windows.Forms.DialogResult str = openFileDialog.ShowDialog();
            String FileName = openFileDialog.FileName;

            if (FileName.ToString() != "")
            {
                String FileExt = FileName.Substring(FileName.LastIndexOf("."));
                if (FileExt.CompareTo(".xls") == 0 || FileExt.CompareTo(".xlsx") == 0)
                {
                    try
                    {
                        DataTable dtExcel = new DataTable();
                        dtExcel = ReadExcel(FileName, FileExt); //read excel file  
                        dataGridView.Visible = true;
                        dataGridView.DataSource = dtExcel;

                        ReconclieFee();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please choose .xls or .xlsx file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //custom messageBox to show error  
                }
            }
        }
    }
}
