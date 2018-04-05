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
        public void exportgridpdf(DataGridView data, string filename, CheckBox[] box)
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);

            string[] storename = new string[20];
            int i = 0;
            foreach (DataGridViewColumn column in data.Columns)
            {
                if (column.Visible == true)
                {
                    storename[i] = column.HeaderText;
                    i++;
                }
            }
            PdfPTable pdftable = new PdfPTable(i);
            pdftable.DefaultCell.Padding = 5;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 7, iTextSharp.text.Font.NORMAL);

            // Add the logo
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagepath = startupPath + "logo1.png";
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagepath);
            image.ScalePercent(60f);

            #region
            // Add header
            
            for(var j=0; j< data.Columns.Count;j++)
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
                                pdftable.AddCell(new Phrase(data.Columns[j].HeaderText, font));                            
                                //ddMessageBox.Show(data.Columns[j].HeaderText);
                            }

                        }
                    }

                }
            }





            //int mn = 0;

            //foreach (DataGridViewColumn column in data.Columns)
            //{
            //    if ((column.HeaderText).Equals(box[mn].Text))
            //    {
            //        //   string columns = box[j].Text;
            //        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            //        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            //        pdftable.AddCell(column.HeaderText);
            //        // MessageBox.Show(box[mn].Text);
            //        mn++;
            //    }
            //}
            ////PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
            ////cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
            ////pdftable.AddCell(cell);
            //// }

            ////Add datarow 
            ////foreach (DataGridViewRow row in data.Rows)
            ////{
            ////    int j = 0;
            ////    foreach (DataGridViewCell cell in row.Cells)
            ////    {
            ////        if (box[j].Checked == true)
            ////        {
            ////            pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
            ////        }
            ////        j++;
            ////    }
            ////}
            ////int s = 0;
            ////for (int m = 0; m < data.Rows.Count; m++)
            ////{
            ////    for (int n = 0; n < data.Columns.Count; n++)
            ////    {
            ////        if (data.Columns[n].Name == storename[s])
            ////        {
            ////            if(box[s].Checked == true)
            ////            {
            ////                pdftable.AddCell(new Phrase(DataGridCell[n,m].Value.ToString(),text));
            ////            }
            ////            s++;
            ////        }
            ////    }
            ////}

            //var savefiledialoge = new SaveFileDialog();
            //savefiledialoge.FileName = filename;
            //savefiledialoge.DefaultExt = ".pdf";
            //if (savefiledialoge.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
            //        {
            //            Document doc = new Document(iTextSharp.text.PageSize.A4, 30, 0, 10, 0);
            //            PdfWriter wrf = PdfWriter.GetInstance(doc, stream);
            //            doc.Open();
            //            doc.Add(image);
            //            doc.Add(pdftable);
            //            doc.Close();
            //            stream.Close();
            //        }

            //    }
            //    catch (Exception )
            //    {
            //        MessageBox.Show("Please close the PDF and then save");
            //    }

            //}
            #endregion

                //foreach (DataGridViewColumn c in data.Columns)
                //{
                //    //for (var j = 0; j < i; j++)
                //    //{
                //    //    if (box[j].Checked == true && c.HeaderText == box[j].Text)
                //    if (c.Visible == true)
                //    {
                //        PdfPCell cell = new PdfPCell(new Phrase(c.HeaderText));
                //        cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                //        pdftable.AddCell(cell);
                //    }
                //    //}
                //}

                //Set Color of Alternating row

                //if (i % 2 != 0)

                //{

                //    cell.BackgroundColor = new Color(System.Drawing.ColorTranslator.FromHtml("#dce0bc"));

                //}

                //PdfPTable pdftablecount = new PdfPTable(i);
                //int m = 0;
                //for (int k = 0; k < data.Rows.Count - 1; k++)
                //{
                //    for (int j = 0; j < data.Columns.Count - 1; j++)
                //    {
                //        if (data.Columns[j].HeaderText == box[m].Text && box[m].Checked == true)
                //        {
                //            pdftablecount.AddCell(new Phrase(data[j, k].Value.ToString(), text));
                //            m++;
                //        }
                //    }
                //}

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
        public void exportgridviewpdf(DataGridView data, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1257, BaseFont.EMBEDDED);

            PdfPTable pdftable = new PdfPTable(data.Columns.Count);
            pdftable.DefaultCell.Padding = 5;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 8, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 7, iTextSharp.text.Font.BOLD);

            // Add the logo
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string imagepath = startupPath + "logo1.png";
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagepath);
            image.ScalePercent(60f);

            // Add the column
            foreach (DataGridViewColumn column in data.Columns)
            {

                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }

            //Add datarow 
            foreach (DataGridViewRow row in data.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {

                   pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
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
                    MessageBox.Show("Please close the PDF and then save");
                }

            }
        }
    }
}
