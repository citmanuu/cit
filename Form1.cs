using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Configuration;
using System.Data.SqlClient;

namespace MANUUFinance
{
    public partial class pdfsupports : Form
    {
        public pdfsupports()
        {
            InitializeComponent();
        }

        private void pdfsupports_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void loadform()
       {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);

            SqlDataAdapter sqldb = new SqlDataAdapter("SELECT A.PKACID, A.FKSL3ID, A.AccountName, A.AcOrder, A.AcActive, A.FKBankAccountID, B.BankName, B.AccountType AS BankAccountType, B.AccountNumber, C.SL1ID, C.PKSL2, C.SL1Name, C.SL2Name, C.SL3Name, C.SL3Code, A.AccountType " +
                                    "FROM dbo.Accounts AS A LEFT OUTER JOIN dbo.BankAccountDetails AS B ON A.FKBankAccountID = B.PKBANKACC INNER JOIN dbo.SL3SL2SL1 AS C ON A.FKSL3ID = C.PKSL3 where A.DeptId = '"+ 4 +"'", objSqlConnection);
            DataTable dtb1 = new DataTable();
            sqldb.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
        }
    }
}
