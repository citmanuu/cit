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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users objadduser = new Users();
            objadduser.ShowDialog();
        }

        private void addFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms objaddform = new Forms();
            objaddform.ShowDialog();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departments objadddepartment = new Departments();
            objadddepartment.ShowDialog();
        }

        private void addRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles objaddrole = new Roles();
            objaddrole.ShowDialog();
        }
    }
}
