using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem.Forms
{
    public partial class HowToDownload : Form
    {
        public HowToDownload()
        {
            InitializeComponent();
        }

        private void label_close_MouseEnter(object sender, EventArgs e) // когато мишката е в/у хикса да светне хикса
        {
            label_close.ForeColor = Color.Red; // X става червен
        }

        private void label_close_MouseLeave(object sender, EventArgs e) // когато мишката се отдръне
        {
            label_close.ForeColor = Color.Ivory; //цветът се връща
        }

        private void label_close_Click(object sender, EventArgs e) // като се натисне хикса се излиза от апликацията
        {
            if (MessageBox.Show("Изкате ли да излезете от приложението?", "Излизане", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button_pdf_Click(object sender, EventArgs e)
        {
            //if (dataGridView_all.Rows.Count > 0)
            //{
        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "PDF (*.pdf)|*.pdf";
        //        sfd.FileName = "Output.pdf";
        //        bool fileError = false;
        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            if (File.Exists(sfd.FileName))
        //            {
        //                try
        //                {
        //                    File.Delete(sfd.FileName);
        //                }
        //                catch (IOException ex)
        //                {
        //                    fileError = true;
        //                    MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
        //                }
        //            }
        //            if (!fileError)
        //            {
        //                try
        //                {
        //                    PdfPTable pdfTable = new PdfPTable( dataGridView_all.Columns.Count);
        //                    pdfTable.DefaultCell.Padding = 3;
        //                    pdfTable.WidthPercentage = 100;
        //                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

        //                    foreach (DataGridViewColumn column in dataGridView_all.Columns)
        //                    {
        //                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
        //                        pdfTable.AddCell(cell);
        //                    }

        //                    foreach (DataGridViewRow row in dataGridView_all.Rows)
        //                    {
        //                        foreach (DataGridViewCell cell in row.Cells)
        //                        {
        //                            pdfTable.AddCell(Convert.ToString(cell.Value));
        //                        }
        //                    }

        //                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
        //                    {
        //                        Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
        //                        PdfWriter.GetInstance(pdfDoc, stream);
        //                        pdfDoc.Open();
        //                        pdfDoc.Add(pdfTable);
        //                        pdfDoc.Close();
        //                        stream.Close();
        //                    }

        //                    MessageBox.Show("Data Exported Successfully !!!", "Info");
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error :" + ex.Message);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Record To Export !!!", "Info");
        //    }
        }
    }
}
