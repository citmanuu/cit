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
            string sl1master = "SL-1 MASTER";
            frmSL1 objFrmSL1 = new frmSL1(userId, deptId, roleId, sl1master);
            objFrmSL1.ShowDialog();
        }

        private void sL2MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sl2master = "SL-2 MASTER";
            frmSL2 objFrmSL2 = new frmSL2(userId, deptId, roleId, sl2master);
            objFrmSL2.ShowDialog();
        }

        private void sL3MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sl3master = "SL-3 MASTER";
            frmSL3 objFrmSL3 = new frmSL3(userId, deptId, roleId, sl3master);
            objFrmSL3.ShowDialog();
        }
        private void bankMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bankmaster = "BANK MASTER";
            frmBank objFrmBank = new frmBank(userId, deptId, roleId, bankmaster);
            objFrmBank.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string account = "ACCOUNT";
            frmAccount objFrmAccount = new frmAccount(userId,deptId,roleId, account);
            objFrmAccount.ShowDialog();
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string budget = "BUDGET";
            frmBudget objFrmBudget = new frmBudget(userId, deptId, roleId, budget);
            objFrmBudget.ShowDialog();
        }

        private void billDespatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string billdispatch = "BILL DISPATCH";
            frmBillDespatch objFrmBillDespatch = new frmBillDespatch(userId, deptId, roleId, billdispatch);
            objFrmBillDespatch.ShowDialog();
        }

        private void copyBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string copybudget = "COPY BUDGET";
            frmCloneDeptBudget objfrmCloneDeptBudget = new frmCloneDeptBudget(userId, deptId, roleId, copybudget);
            objfrmCloneDeptBudget.ShowDialog();
        }

        private void demonstrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDemonstration objFrmDemonstration = new frmDemonstration();
            //objFrmDemonstration.ShowDialog();
        }
        private void MDIParent_Load(object sender, EventArgs e)
        {
            Printtheusername();
            if (new AdministratorLogin().administratorLogin(userId))
            {
                preparationofmenu();
            }
            else
                preparationofadminmenu();
        }

        private void preparationofadminmenu()
        {
            List<ToolStripMenuItem> menuname = menuitemcheck();
            foreach (var menuName in menuname)
            {
                 menuName.Visible = true;
            }

        }

        private void preparationofmenu()
        {
            List<string> formname = new CheckingPrivileges().CheckingPrivilegesformcheck(userId, deptId, roleId);
            List<ToolStripMenuItem> menuname = menuitemcheck();
            if (formname.Count != 0)
            {
                foreach (var formNameId in formname)
                {
                    foreach (var menuName in menuname)
                    {
                        if (formNameId.Equals(menuName.ToString().ToUpper()))
                        {
                            menuName.Visible = true;
                        }
                    }

                }

                foreach(var formNameId in formname)
                {
                  //  MessageBox.Show(formNameId);
                }
            }
        }
        private List<ToolStripMenuItem> menuitemcheck()
        {
            List<ToolStripMenuItem> allItems = new List<ToolStripMenuItem>();
            foreach (ToolStripMenuItem toolItem in menuStrip1.Items)
            {
               // allItems.Add(toolItem);
                //add sub items
                allItems.AddRange(GetItems(toolItem));
            }
            return allItems;
        }

        private IEnumerable<ToolStripMenuItem> GetItems(ToolStripMenuItem item)
        {
            if (item is ToolStripMenuItem)
            {
                foreach (var dropDownItem in item.DropDownItems.OfType<ToolStripMenuItem>())
                {
                    if (dropDownItem.HasDropDownItems)
                    {
                        foreach (ToolStripMenuItem subItem in GetItems(dropDownItem))
                            yield return subItem;
                    }
                    yield return dropDownItem;
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string user = "USER";
            Users objectuseradd = new Users(userId, deptId, roleId, user);
            objectuseradd.ShowDialog();
        }
        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string department = "DEPARTMENT";
            Departments objectdepartmentadd = new Departments(userId, deptId, roleId, department);
            objectdepartmentadd.ShowDialog();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string form = "FORM";
            Forms objectformadd = new Forms(userId, deptId, roleId, form);
            objectformadd.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string roles = "ROLES";
            Roles objectrolesadd = new Roles(userId, deptId, roleId, roles);
            objectrolesadd.ShowDialog();
        }

        private void departemtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string deptartmentPrivileges = "DEPT PRIVILEGES";
            deptartmentPrivileges abjectmappingdept = new deptartmentPrivileges(userId, deptId, roleId, deptartmentPrivileges);
            abjectmappingdept.ShowDialog();
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string roleprivileges = "ROLE PRIVILEGES";
            RolePrivileges objectmappingroles = new RolePrivileges(userId, deptId, roleId, roleprivileges);
            objectmappingroles.ShowDialog();
        }

        private void budgetPurposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string budgetpurpose = "BUDGET PURPOSE";
            frmBudgetPurpose objectbudgetpurpose = new frmBudgetPurpose(userId, deptId, roleId, budgetpurpose);
            objectbudgetpurpose.ShowDialog();
        }

        private void budgetScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string budgetschedule = "BUDGET SCHEDULE";
            BudgetSchedule objectbudgetschedule = new BudgetSchedule(userId, deptId, roleId, budgetschedule );
                objectbudgetschedule.ShowDialog();
        }

        private void virtualHeadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string virtuahead = "VIRTUAL HEAD";
            frmVirtuaHead objectvirtualhead = new frmVirtuaHead(userId, deptId, roleId, virtuahead);
            objectvirtualhead.ShowDialog();
        }

        private void vAcountMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string vActType = "frmVAcType";
            frmVAcType objectvirtualhead = new frmVAcType(userId, deptId, roleId, vActType);
            objectvirtualhead.ShowDialog();
        }

        private void addPrivilegesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string addprivileges = "ADD PRIVILEGES";
            Privilege objectaddprivileges = new Privilege(userId, deptId, roleId, addprivileges);
            objectaddprivileges.ShowDialog();
        }
        private void Printtheusername()
        {
            //Connection String
            string cs = ConfigurationManager.ConnectionStrings["FinanceConnectionString"].ConnectionString;
            //Instantiate SQL Connection
            SqlConnection objSqlConnection = new SqlConnection(cs);
            objSqlConnection.Open();
            SqlCommand myCommand = new SqlCommand("SELECT NAME FROM [Finance].[dbo].[Users] where  UserId = '" + userId + "'", objSqlConnection);
            label1.Text = myCommand.ExecuteScalar().ToString().ToUpper();
            objSqlConnection.Close();
        }
    }
}
