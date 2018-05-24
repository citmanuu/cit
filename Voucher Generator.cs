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
    public partial class Voucher_Generator : Form
    {
        public Voucher_Generator()
        {
            InitializeComponent();
        }

        private void btnVaucherPrint_Click(object sender, EventArgs e)
        {
            Voucher obj = voucherBindingSource.Current as Voucher;
            if (obj != null)
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);
                objSqlConnection.Open();

                string query = "  select A.DeptName, B.BECY, B.FKFYID,B.AccountBalance,C.BillAmount from Department A, Budget B, BillMst C where C.FKDepID = A.DeptId";                
            }            
        }
    }
}
