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
    public partial class VirtuaHead : Form
    {
        public VirtuaHead()
        {
            InitializeComponent();
        }

        private void VirtuaHead_Load(object sender, EventArgs e)
        {
            preparedcomboVH();
            preparedcombosl1();
            preparedcombosl2("0");
            preparedcombosl3("0");
            preparedcomboaccount();
        }

        private void preparedcomboaccount()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT ACIDID, AccName FROM [finance].[dbo].[AcName] Order by 2";
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
                comboACCOUNT.DisplayMember = "ListItemDesc"; // will display Name property
                comboACCOUNT.ValueMember = "ListItemID"; // will select Value property
                comboACCOUNT.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        // support  
        #region
        private void preparedcombosl3(string fkSL2)
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

        private void preparedcombosl2(string fkSL1)
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

        private void preparedcombosl1()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT SL1ID, SL1Name FROM [finance].[dbo].[SL1] Order by 2";
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

        private void preparedcomboVH()
        {
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));

            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String
            string selectCommand = "SELECT VHID, VHNAME FROM [finance].[dbo].[VHMst] where VHID = 1 Order by 2";
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
                comboVH.DisplayMember = "ListItemDesc"; // will display Name property
                comboVH.ValueMember = "ListItemID"; // will select Value property
                comboVH.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        private void comboSL2_SelectedIndexChanged(object sender, EventArgs e)
        {
            preparedcombosl3(Convert.ToString(comboSL2.SelectedValue));
        }

        private void comboSL1_SelectedIndexChanged(object sender, EventArgs e)
        {
            preparedcombosl2(Convert.ToString(comboSL1.SelectedValue));
        }
        #endregion
    }
}
