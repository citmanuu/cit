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

            string selectCommand = "SELECT FromDate, ToDate FROM [Finance].[dbo].[BudgetSchedule] where BSID = 11";
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
            //DateTime taday = DateTime.Now.ToString("dd-MM-yyyy");

            int days = (enddate - Starting).Days;
            label1.Text = days.ToString();
        }
    }
}
