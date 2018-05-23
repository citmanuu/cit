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
        DateTime Starting;
        DateTime enddate;
       public  int Global = 0;
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
            ////Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            ////Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);

            string selectCommand = "SELECT FromDate, ToDate FROM [Finance].[dbo].[BudgetSchedule] where BSID = 07";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                objSqlConnection.Open();
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    Starting = Convert.ToDateTime(objDataReader["FromDate"]);
                    enddate = Convert.ToDateTime(objDataReader["Todate"]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Select Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }
            DateTime taday = DateTime.Now;
            int days;
            days = (Convert.ToDateTime(enddate) - Convert.ToDateTime(Starting)).Days;
            //DateTime todat = DateTime.Now;
            //int days = (todat)
            //label1.Text = (days*24*60*60).ToString()+ "Min";
            Global = Convert.ToInt32(days * 24 * 60 * 60);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Global== 0)
            {
                MessageBox.Show("Time Up");
                timer1.Stop();
            }
            int abc =  10;
            //gloabaltest(abc);
            label2.Text = Global.ToString() + "" + "Min Left";
            Global--;
        }

        private void gloabaltest(int abc)
        {
            label1.Text = (10 * 24 * 60 * 60).ToString() + "Min";
        }
    }
}
