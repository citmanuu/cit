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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the Application?", "Financial Management Application",
         MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication objectauthentication = new Authentication();
            objectauthentication.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrator objectadmin = new Administrator();
            objectadmin.ShowDialog();
        }
    }
}
