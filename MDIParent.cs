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
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;
        private int userId, deptId,roleId;
        public MDIParent(int userId,int deptId, int roleId)
        {
            InitializeComponent();
            this.userId = userId;
            this.deptId = deptId;
            this.roleId = roleId;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        /*  private void OpenFile(object sender, EventArgs e)
          {
              OpenFileDialog openFileDialog = new OpenFileDialog();
              openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
              openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
              if (openFileDialog.ShowDialog(this) == DialogResult.OK)
              {
                  string FileName = openFileDialog.FileName;
              }
          }

          private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
          {
              SaveFileDialog saveFileDialog = new SaveFileDialog();
              saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
              saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
              if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
              {
                  string FileName = saveFileDialog.FileName;
              }
          }

          private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
          {
              this.Close();
          }
          */
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void sL1MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSL1 objFrmSL1 = new frmSL1();
            objFrmSL1.ShowDialog();
        }

        private void sL2MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSL2 objFrmSL2 = new frmSL2();
            objFrmSL2.ShowDialog();
        }

        private void sL3MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSL3 objFrmSL3 = new frmSL3();
            objFrmSL3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exits = "EXIT";
            CheckingPrivileges objectcheckingform = new CheckingPrivileges();
            if (objectcheckingform.CheckingPrivilegesform(userId, deptId, roleId, exits))
            {
                this.Close();
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bankMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank objFrmBank = new frmBank();
            objFrmBank.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string account = "ACCOUNTS";
            CheckingPrivileges objectforcheckingform = new CheckingPrivileges();
           if (objectforcheckingform.CheckingPrivilegesform(userId,deptId,roleId,account))
            {
                frmAccount objFrmAccount = new frmAccount(userId,deptId,roleId);
                objFrmAccount.ShowDialog();
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBudget objFrmBudget = new frmBudget();
            objFrmBudget.ShowDialog();
        }

        private void billDespatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBillDespatch objFrmBillDespatch = new frmBillDespatch();
            objFrmBillDespatch.ShowDialog();
        }

        private void copyBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCloneDeptBudget objfrmCloneDeptBudget = new frmCloneDeptBudget();
            objfrmCloneDeptBudget.ShowDialog();
        }

        private void demonstrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemonstration objFrmDemonstration = new frmDemonstration();
            objFrmDemonstration.ShowDialog();
        }

        private void addPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void managePrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {
            Printtheusername();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users objectusers = new Users();
            objectusers.ShowDialog();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms objectform = new Forms();
            objectform.ShowDialog();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments objectdepartment = new Departments();
            objectdepartment.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles objectrole = new Roles();
            objectrole.ShowDialog();
        }

        private void addPrivilegesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Privilege objprivilege = new Privilege();
            objprivilege.ShowDialog();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeptPrivileges objectdepartmentprivileges = new DeptPrivileges();
            objectdepartmentprivileges.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help = "HELP";
            CheckingPrivileges objectforcheckingform = new CheckingPrivileges();
            if (objectforcheckingform.CheckingPrivilegesform(userId, deptId, roleId, help))
            {
                MessageBox.Show("Wowwwwwwww ", " Access", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please contact the Administrator ", "No Access", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RolePrivileges objectroleprivileges = new RolePrivileges();
            objectroleprivileges.ShowDialog();
        }

        private void Printtheusername()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["LdapConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT NAME FROM [Ldap].[dbo].[Users] where  UserId = '" + userId + "'", objSqlConnection);
            label1.Text = myCommand.ExecuteScalar().ToString().ToUpper();
            objSqlConnection.Close();
        }
    }
}
