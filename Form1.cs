using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace MANUUFinance
{
    public partial class pdfsupports : Form
    {
        DataGridView DVGtest;
        public pdfsupports(DataGridView DVGtest)
        {
            InitializeComponent();
            this.DVGtest = DVGtest;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Name is testing : " + txtName.Text,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void openPDF()
        //{
        //    //string pdfDoc = @"C:/Users/cit/Desktop/citmanuu/bin\Debug/test.pdf";
        //    //PdfReader pdfreader = new PdfReader(Request.MapPath("pdfDoc"));

        //}
    }
}
