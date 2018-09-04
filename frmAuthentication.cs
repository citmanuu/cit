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
    public partial class frmAuthentication : Form
    {
        public int userId { get; set; }
        public int tempId { get; set; }

        public frmAuthentication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateRecord())
            {
                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                //Instantiate SQL Connection
                SqlConnection con = new SqlConnection(cs);

                // Open the connection
                con.Open();
                // Get the number of the row in database
                SqlCommand cmd = new SqlCommand("User_Validation", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                userId = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                switch (userId)
                {
                    case -1:
                        MessageBox.Show("password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cleartextbox();
                        break;
                    default:
                        this.Close();
                        MDIParent objectmdiparent = new MDIParent(userId, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
                        objectmdiparent.ShowDialog();
                        break;
                }
            }

        }

        private bool validateRecord()
        {
            bool validationResult = true;
            string validationMessage = "";
            if (textBox1.Text.Length == 0)
            {
                validationMessage += "Please provide User Name\n";
                validationResult = false;
            }
            if (textBox2.Text.Length == 0)
            {
                validationMessage += "Please provide Password\n";
                validationResult = false;
            }
            if (comboBox1.SelectedValue == null)
            {
                validationMessage += "Please Select Department\n";
                validationResult = false;
            }
            if (comboBox2.SelectedValue == null)
            {
                validationMessage += "Please Select Role\n";
                validationResult = false;
            }
            if (validationResult == false)
            {
                MessageBox.Show(validationMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
                return true;
        }

        private void preparationofcombo()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);

            // Open the connection
            objSqlConnection.Open();
            tempId = int.Parse(new SqlCommand("SELECT UserId FROM [Finance].[dbo].[Users] where Name = '" + textBox1.Text + "'", objSqlConnection).ExecuteScalar().ToString());
            var objLOVClass = new List<LOV>();
            objLOVClass.Add(new LOV(0, "-- Please Select --"));
            //Prepare Update String                
            string selectCommand = "SELECT a.DeptId, a.DeptName FROM [Finance].[dbo].[Department] as a inner join [Finance].[dbo].[UserDept] as b on a.DeptId = b.DeptId where b.UserId = '" + tempId + "'Order by 1";
            SqlCommand objSelectCommand = new SqlCommand(selectCommand, objSqlConnection);
            try
            {
                SqlDataReader objDataReader = objSelectCommand.ExecuteReader();
                while (objDataReader.Read())
                {
                    objLOVClass.Add(new LOV(Convert.ToInt32(objDataReader[0]), Convert.ToString(objDataReader[1])));
                }
                // Bind combobox list to the items
                comboBox1.DisplayMember = "ListItemDesc"; // will display Name property
                comboBox1.ValueMember = "ListItemID"; // will select Value property
                comboBox1.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

            //Instantiate SQL Connection
            SqlConnection con = new SqlConnection(cs);

            // Open the connection
            con.Open();
            // Get the number of the row in database
            SqlCommand cmd = new SqlCommand("User_Validation_combopre", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            userId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            switch (userId)
            {
                case -1:
                    MessageBox.Show("Username is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cleartextbox();
                    textBox1.Focus();
                    break;
                default:
                    preparationofcombo();
                    break;
            }
        }

        private void cleartextbox()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedValue) == 0)
            {
                 
            }
            else
            {
                var objLOVClass = new List<LOV>();
                objLOVClass.Add(new LOV(0, "-- Please Select --"));

                //Connection String
                string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
                //Instantiate SQL Connection
                SqlConnection objSqlConnection = new SqlConnection(cs);
                //Prepare Update String                
                string selectCommand = "SELECT a.RoleId, a.RoleName FROM [Finance].[dbo].[RoleMST] as a inner join [Finance].[dbo].[DeptRoleUser] as b on a.RoleId = b.RoleId where b.DeptId = '" + Convert.ToInt32(comboBox1.SelectedValue) + "' AND b.UserId = '" +tempId+ "' Order by 1";
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
                    comboBox2.DisplayMember = "ListItemDesc"; // will display Name property
                    comboBox2.ValueMember = "ListItemID"; // will select Value property
                    comboBox2.DataSource = objLOVClass; // assign list (will populate comboBox1.Items)
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

        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }
    }
}
