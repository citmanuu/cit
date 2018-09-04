using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class frmUsers : Form
    {
        private int userId, deptId, roleId;
        private string formName;
        public frmUsers(int userId, int deptId, int roleId, string formName)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
            this.formName = formName;
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        // DML action
        #region

        private void btAdd_Click(object sender, EventArgs e)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (textBox2.Text.Length < 6)
                    {
                        MessageBox.Show("Password should be more than 6 charecter  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cleartextbox();
                    }
                    else
                    {
                        if (regexItem.IsMatch(textBox2.Text))
                        {
                            MessageBox.Show("Password is not in proper format  ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cleartextbox();
                        }

                        else
                        {
                            if (textBox2.Text == textBox3.Text)
                            {
                                if (regex.Match(textBox4.Text).Success)
                                {
                                    //Connection String 
                                    string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;

                                    //Instantiate SQL Connection
                                    SqlConnection con = new SqlConnection(cs);

                                    // Open the connection
                                    con.Open();

                                    // Get the number of the row in database
                                    //SqlCommand myCommand = new SqlCommand("SELECT COUNT(UserId) FROM [Ldap].[dbo].[Users]", con);
                                    // UserId = Convert.ToInt32(myCommand.ExecuteScalar());
                                    // UserId++;

                                    SqlCommand cmd = new SqlCommand("User_insert", con);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@Name", textBox1.Text.ToString());
                                    cmd.Parameters.AddWithValue("@Password", textBox2.Text.ToString());
                                    cmd.Parameters.AddWithValue("@Email", textBox4.Text.ToString());
                                    cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now);
                                    try
                                    {
                                        bool success = Convert.ToBoolean(cmd.ExecuteScalar());
                                        MessageBox.Show("User is Added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cleartextbox();
                                    }
                                    catch (SqlException ex)
                                    {
                                        if (ex.Message.Contains("Name_Users"))
                                        {
                                            MessageBox.Show("Users already added. Perhaps you want to change.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            textBox1.Focus();
                                            cleartextbox();
                                        }
                                        else if (ex.Message.Contains("Email_Users"))
                                        {
                                            MessageBox.Show("Email already added. Perhaps you want to change.", "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            textBox1.Focus();
                                            cleartextbox();
                                        }
                                         else
                                            MessageBox.Show("The following error occured : " + ex.Message, "Update Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                    finally
                                    {
                                        cleartextbox();
                                        con.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Email should be in proper format ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    cleartextbox();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password is not matching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cleartextbox();
                            }

                        }
                    }
                }
                else
                    MessageBox.Show("Please Insert the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Insert the Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        #endregion

        // support
        #region
        private void cleartextbox()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox1.Focus();
        }
        #endregion
    }
}
