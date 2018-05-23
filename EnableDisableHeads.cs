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
    public partial class EnableDisableHeads : Form
    {
        string VHNAME = null;
        int VHID = 0;
        public EnableDisableHeads()
        {
            InitializeComponent();
        }

        private void EnableDisableHeads_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financeDataSet7.VHMst' table. You can move, or remove it, as needed.
            this.vHMstTableAdapter.Fill(this.financeDataSet7.VHMst);

        }

        private void SAVE_Click(object sender, EventArgs e)
        {
           //Connection String
             string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
           //Instantiate SQL Connection
             SqlConnection objSqlConnection = new SqlConnection(cs);
            //Prepare Update String            
             string updateCommand = "Update [dbo].[VHMst] set VHNAME = @VHNAME,isActive = @isActive where VHID = '" + VHID + "'";

            SqlCommand objInsertCommand = new SqlCommand(updateCommand, objSqlConnection);

            objInsertCommand.Parameters.AddWithValue("@VHNAME", VHNAME.ToString());
            if(radioActive.Checked == true)
            {
                objInsertCommand.Parameters.AddWithValue("@isActive", true);
            }
            else
            {
                objInsertCommand.Parameters.AddWithValue("@isActive", false);
            }
                   
                    try
                    {
                        objSqlConnection.Open();
                        objInsertCommand.ExecuteNonQuery();
                        MessageBox.Show("Record Save Successfully", "Record Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                        this.vHMstTableAdapter.Fill(this.financeDataSet7.VHMst);
                    }
        }

        private void DGVVH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(DGVVH.Rows[e.RowIndex].Cells[2].FormattedValue.ToString()).Equals(true))
                {
                    radioActive.Checked = true;
                }
                else
                    radioDeactive.Checked = true;
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT VHNAME FROM [finance].[dbo].[VHMst] where VHID = '" + Convert.ToInt32(DGVVH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString())+ "'" , con);
                VHNAME = myCommand.ExecuteScalar().ToString();                
                VHID  = Convert.ToInt32( DGVVH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());                
                con.Close();
            }
        }
    }
}
