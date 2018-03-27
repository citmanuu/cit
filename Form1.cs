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
    public partial class frmDemonstration : Form
    {
        public frmDemonstration()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Name is: " + txtName.Text,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
