using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypesImpression
{
    public partial class frmImpression : Form
    {
        private int _Line = 0;

        public frmImpression()
        {
            InitializeComponent();
        }
        public void printDocument(System.Drawing.Printing.PrintPageEventArgs e)
        {

            /*
             * https://www.codeproject.com/Questions/68575/How-to-print-more-pages-in-C-printdocument
            */
            Font myFont = new Font("m_svoboda", 14, FontStyle.Underline, GraphicsUnit.Point);

            float lineHeight = myFont.GetHeight(e.Graphics) + 50;

            int hauteurTexte = 210;

            float yLineTop = e.MarginBounds.Top;

            for (
			_Line < 3; _Line++)
            {
                if (yLineTop + lineHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                Bitmap bmp = Properties.Resources.titleFilmap;
                Image newImage = bmp;
                e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
                
                e.Graphics.DrawString("Films : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
                bool first = false;
                foreach (object nomFilms in cmbNomFilms.Items)
                {
                    if (first == false)
                    {
                        e.Graphics.DrawString(nomFilms.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(e.MarginBounds.Left, yLineTop + 30));
                        hauteurTexte += 170;
                    }
                    else
                    {
                        e.Graphics.DrawString(nomFilms.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(e.MarginBounds.Left, yLineTop));
                    }
                    yLineTop += lineHeight;
                    first = true;
                   
                }
                e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new PointF(e.MarginBounds.Left, yLineTop));

                yLineTop += lineHeight;
                first = false;
            }

            e.HasMorePages = false;
        }
        private void prntDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prntPreviewDialog.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            prntPreviewDialog.Document = prntDoc;
            prntPreviewDialog.ShowDialog();
        }

        private void btnPrintDocument_Click(object sender, EventArgs e)
        {
            prntDoc.PrinterSettings.PrinterName = cmbPrinter.Text;
            prntDoc.Print();
        }

        private void frmImpression_Load(object sender, EventArgs e)
        {
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                cmbPrinter.Items.Add(printer);
            }
        }
    }
}
