using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class ManagePrivilege : Form
    {
        public ManagePrivilege()
        {
            InitializeComponent();
        }

        private void assignUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeptPrivileges objassignuser = new DeptPrivileges();
            objassignuser.ShowDialog();
        }

        private void privilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void departmentPrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolePrivilegesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
