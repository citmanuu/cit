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
    public partial class Departments : Form
    {
        bool retrievedForUpdate = false;
        int GlobalId = 0;
        public Departments()
        {
            InitializeComponent();
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ldapDataSet.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.ldapDataSet.Department);

        }

        private void DGVForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = DGVForm.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                richTextBox1.Text = DGVForm.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                retrievedForUpdate = true;
                string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand myCommand = new SqlCommand("SELECT DeptId FROM [Ldap].[dbo].[Department] where DeptName = '" + textBox1.Text + "'", con);
                GlobalId = int.Parse(myCommand.ExecuteScalar().ToString());
                con.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                //Connection String 
                string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection con = new SqlConnection(cs);

                // Open the connection
                con.Open();
                // Get the number of the row in database
                SqlCommand cmd = new SqlCommand("department_insert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DeptName", textBox1.Text.ToString().ToUpper());
                cmd.Parameters.AddWithValue("@DeptDescription", richTextBox1.Text.ToString().ToUpper());
                bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                if (success)
                {
                    MessageBox.Show("Department is Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.departmentTableAdapter.Fill(this.ldapDataSet.Department);
                    con.Close();
                    cleartextbox();

                }
                else
                {
                    MessageBox.Show("Please check your Department Name", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cleartextbox();
                }
            }
        }

        private bool validateRecord()
        {
                bool validationResult = true;
                string validationMessage = "";
                if (textBox1.Text.Length == 0)
                {
                    validationMessage += "Please provide Department Name\n";
                    validationResult = false;
                }
                if (richTextBox1.Text.Length == 0)
                {
                    validationMessage += "Please provide Description\n";
                    validationResult = false;
                }
                if (richTextBox1.Text.Length >= 250)
                {
                    validationMessage += "Please provide only 250 charecters in description box\n";
                    validationResult = false;
                }
                if (validationResult == false)
                {
                    MessageBox.Show(validationMessage, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                    return true;
        }

        private void cleartextbox()
        {
            textBox1.Text = String.Empty;
            richTextBox1.Text = String.Empty;
            retrievedForUpdate = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder SearchStatement = new StringBuilder();
            try
            {
                SearchStatement.Clear();
                if (txtDeptNameSearch.Text.Length > 0)
                {
                    if (SearchStatement.Length > 0)
                    {
                        SearchStatement.Append(" and ");
                    }
                    SearchStatement.Append("DeptName like '%" + txtDeptNameSearch.Text + "%'");
                }
                //Refresh DGV 
                departmentBindingSource.Filter = SearchStatement.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtDeptNameSearch.Text = "";
            departmentBindingSource.Filter = null;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //If Form Controls are validated proceed to update record
            if (validateRecord())
            {
                //Check if we are not Updating Record
                if (retrievedForUpdate)
                {
                    //Connection String 
                    string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection con = new SqlConnection(cs);
                    // Open the connection
                    con.Open();
                    SqlCommand cmd = new SqlCommand("department_update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeptId", GlobalId);
                    cmd.Parameters.AddWithValue("@DeptName", textBox1.Text.ToString().ToUpper());
                    cmd.Parameters.AddWithValue("@DeptDescription", richTextBox1.Text.ToString().ToUpper());
                    bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (success)
                    {
                        MessageBox.Show("Department is Updated", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.departmentTableAdapter.Fill(this.ldapDataSet.Department);
                        con.Close();
                        cleartextbox();

                    }
                    else
                    {
                        MessageBox.Show("Please check your Department Name", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartextbox();
                    }
                }

            }
        }

        private void btClearRecord_Click(object sender, EventArgs e)
        {
            cleartextbox();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete the department?", "Alert",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (validateRecord())
                {
                    //Connection String 
                    string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;

                    //Instantiate SQL Connection
                    SqlConnection con = new SqlConnection(cs);

                    // Open the connection
                    con.Open();
                    // Get the number of the row in database
                    SqlCommand cmd = new SqlCommand("department_delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DeptName", textBox1.Text);

                    bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                    if (success)
                    {
                        MessageBox.Show("Department is Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.departmentTableAdapter.Fill(this.ldapDataSet.Department);
                        con.Close();
                        cleartextbox();
                    }
                    else
                    {
                        MessageBox.Show("Please select the department", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cleartextbox();
                    }
                }
                
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
