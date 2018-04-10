using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    class PdfCreator
    {
        public void exportgridpdf(DataGridView data, string filename, CheckBox[] box, int appearcolumns)
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);

            string[] storename = new string[20];
            int count = 0;
            for(var i =0; i < appearcolumns; i++)
            {
                if (box[i].Checked == true)
                    count++;
            }
            if (count !=0)
            {
                PdfPTable pdftable = new PdfPTable(count);
                pdftable.DefaultCell.Padding = 5;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 6, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 7, iTextSharp.text.Font.NORMAL);

                // Add the logo
                string startupPath = AppDomain.CurrentDomain.BaseDirectory;
                string imagepath = startupPath + "logo1.png";
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagepath);
                image.ScalePercent(60f);

                // Add header

                for (var j = 0; j < data.Columns.Count; j++)
                {

                    foreach (CheckBox box1 in box)
                    {
                        if (box1 == null)
                            continue;
                        else
                        {
                            if (data.Columns[j].HeaderText == box1.Text)
                            {
                                if (box1.Checked == true)
                                {
                                    PdfPCell cell = new PdfPCell(new Phrase(data.Columns[j].HeaderText, font));
                                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                                    pdftable.AddCell(data.Columns[j].HeaderText);
                                }

                            }
                        }

                    }
                }

                //Add datarow 
                foreach (DataGridViewRow row in data.Rows)
                {
                    int j = 0;
                    int i = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (data.Columns[j].Visible == true)
                        {
                            if (box[i].Checked == true)
                            {
                                pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                            }
                            i++;
                        }
                        j++;
                    }
                }
                var savefiledialoge = new SaveFileDialog();
                savefiledialoge.FileName = filename;
                savefiledialoge.DefaultExt = ".pdf";
                if (savefiledialoge.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                        {
                            Document doc = new Document(iTextSharp.text.PageSize.A4, 30, 0, 10, 0);
                            PdfWriter wrf = PdfWriter.GetInstance(doc, stream);
                            doc.Open();
                            doc.Add(image);
                            doc.Add(pdftable);
                            doc.Close();
                            stream.Close();
                        }

                    }
                    catch (Exception)
                    {                        
                        MessageBox.Show("Please close the PDF and then save :EXIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please choose any one of them : EXIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void exportgridviewpdf(DataGridView data, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);
            int count = 0;

            foreach (DataGridViewColumn column in data.Columns)
            {
                if (column.Visible == true)
                    count++;
            }

            PdfPTable pdftable = new PdfPTable(count);
            pdftable.DefaultCell.Padding = 5;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 9, iTextSharp.text.Font.BOLD);

            // Add the logo
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagepath = startupPath + "logo1.png";
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagepath);
            image.ScalePercent(60f);

            // Add the column
            foreach (DataGridViewColumn column in data.Columns)
            {
                if (column.Visible == true)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }
            }

            //Add datarow 
            int j = 0;
            foreach (DataGridViewRow row in data.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (data.Columns[j].Visible == true)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                    j++;
                }
                j = 0;
            }
            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                    {
                        Document doc = new Document(iTextSharp.text.PageSize.A4, 30, 0, 10, 0);
                        PdfWriter wrf = PdfWriter.GetInstance(doc, stream);
                        doc.Open();
                        doc.Add(image);
                        doc.Add(pdftable);
                        doc.Close();
                        stream.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please close the PDF and then save");
                }

            }
        }
    }
}
