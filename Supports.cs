using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class Supports : Form
    {
        DataGridView DGV;
        CheckBox[] box = new CheckBox[20];
        string fileName = null;
        int i = 0;
        public Supports(DataGridView DGV, string fileName)
        {
            InitializeComponent();
            this.DGV = DGV;
            this.fileName = fileName;
        }

        private void Supports_Load(object sender, EventArgs e)
        {
            string[] storename = new string[20];
 
            foreach (DataGridViewColumn column in DGV.Columns)
            {
                if(column.Visible == true)
                {
                    storename[i] = column.HeaderText;
                    i++;
                }                
            }
            for (var j=0; j< i; j++)
            {
                box[j] = new CheckBox();
                box[j].Name = j.ToString();
                box[j].Text = storename[j];
                box[j].AutoSize = true;
                box[j].Location = new Point(20, j * 20); //vertical
                                                         //box.Location = new Point(i * 50, 10); //horizontal

                this.Controls.Add(box[j]);
            }
            
        }

        private void generatePDF_Click(object sender, EventArgs e)
        {
            PdfCreator objectpdfgenerate = new PdfCreator();
            objectpdfgenerate.exportgridpdf(DGV, fileName, box);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (var j = 0; j < i; j++)
            {
               // if (box[j].Checked == true)
                    MessageBox.Show(box[j].Text);
            }
        }
    }
}
