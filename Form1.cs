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

        public string ExamID { get; set; }
        public bool validate { get; set; }
        public bool check = false;
        public int studentnotvalid = 1;
        public int sqlcheck = 0;
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
            //Global = Convert.ToInt32(days * 24 * 60 * 60);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          //  if (Global== 0)
          //  {
               // MessageBox.Show("Time Up");
             //   timer1.Stop();
          //  }
            //int abc =  10;
            //gloabaltest(abc);
            //label2.Text = Global.ToString() + "" + "Min Left";
            //Global--;
        }

        private void gloabaltest(int abc)
        {
            //label1.Text = (10 * 24 * 60 * 60).ToString() + "Min";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            SqlConnection objSqlConnection = new SqlConnection();
            objSqlConnection.ConnectionString ="Data Source=172.16.1.6;User ID=ceo;Password=ceo2111;Initial Catalog=CEO2111;";
            //conn.Open();
            //string cs = ConfigurationManager.ConnectionStrings["WebAPI"].ConnectionString;
            //Instantiate SQL Connection
            //SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("Select ExamID from Exam where  RegOpenDate < = '" + now + "' and RegCloseDate > = '" + now + "'", objSqlConnection);
            SqlDataReader cmd = myCommand.ExecuteReader();
            while (cmd.Read())
            {
                ExamID = cmd["ExamID"].ToString();
            }
            objSqlConnection.Close();
            if (ExamID.ToString() == "")
            {
                validate = false;
            }
            else
            {
                IsActiveCheck(ExamID);
                validate = true;
            }
            MessageBox.Show(ExamID.ToString());
        }

        private void IsActiveCheck(object rollID)
        {
            SqlConnection objSqlConnection = new SqlConnection();
            objSqlConnection.ConnectionString = "Data Source=172.16.1.6;User ID=ceo;Password=ceo2111;Initial Catalog=CEO2111;";

            objSqlConnection.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from RollList where (ExamID = 'O18' or ExamID = 'A19') and RollID = '" + textBox1.Text + "'", objSqlConnection);
            sqlcheck = (Int32)cmd1.ExecuteScalar();
            objSqlConnection.Close();
            if (sqlcheck != 0)
            {

                objSqlConnection.Open();
                SqlCommand cmd = new SqlCommand("select IsActive from RollList where (ExamID = 'O18' or ExamID = 'A19') and RollID = '" + textBox1.Text + "'", objSqlConnection);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (Convert.ToInt32(rd["IsActive"].ToString()) == 1)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                }
                objSqlConnection.Close();
            }
            else
            {
                studentnotvalid = 3;
            }
            MessageBox.Show(check.ToString());
            MessageBox.Show(studentnotvalid.ToString());
        }
    }
}
