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
            /*int marge = 50;
            int largeurMax = 720;
            int hauteurTexte = 30;
            //e.Graphics.DrawRectangle(new Pen(Color.BlueViolet, 1), marge, marge, largeurMax, 5);
            e.Graphics.DrawString("Ma liste de Films", new Font("Papyrus", 24, FontStyle.Bold),
            Brushes.Black, 260, hauteurTexte);

            Font fConsolas10Bold = new Font("Consolas", 10, FontStyle.Bold);
            Font fConsolas10Regular = new Font("Consolas", 10, FontStyle.Regular);
            Font fArial10Regular = new Font("Arial", 10, FontStyle.Regular);
            Font fArial10Bold = new Font("Arial", 10, FontStyle.Bold);

            Image img = Image.FromFile("ahri.jpg");
            float x = 80.0F;
            float y = 140.0F;

            RectangleF srcRect = new RectangleF(100.0F, 100.0F, 300.0F, 300.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;
            hauteurTexte += 90;
            foreach (string listeFilm in lstFilms)
            {
                e.Graphics.DrawString(" Nom du Film : ", fConsolas10Bold, Brushes.Blue, 60, hauteurTexte);
                e.Graphics.DrawString("Shrek", fArial10Bold, Brushes.Black, 170, hauteurTexte);
                e.Graphics.DrawString("Acteur principal :", fConsolas10Bold, Brushes.Blue, 500, hauteurTexte);
                e.Graphics.DrawString(listeFilm.ToString(), fArial10Bold, Brushes.Black, 645, hauteurTexte);
                e.Graphics.DrawImage(img, x, y, srcRect, units);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 1), marge, hauteurTexte, largeurMax, 350);
                hauteurTexte += 350;
                y += 350;
                if (hauteurTexte > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    hauteurTexte = 30;
                    return;
                }
                e.HasMorePages = false;
            }
     



            string chaineImpression = "";
            int nbCaractParLigne = 87;
            hauteurTexte -= 7;
            while (chaineImpression.Length > 0)
            {
                string ligne = chaineImpression.Substring(0, nbCaractParLigne);
                chaineImpression = chaineImpression.Remove(0, nbCaractParLigne);
                hauteurTexte += 18;
                e.Graphics.DrawString(ligne, fConsolas10Regular, Brushes.Black, 65, hauteurTexte);
                if (chaineImpression.Length < nbCaractParLigne)
                    nbCaractParLigne = chaineImpression.Length;
            }
         */

            /*
             * https://www.codeproject.com/Questions/68575/How-to-print-more-pages-in-C-printdocument
            */
            Font myFont = new Font("m_svoboda", 14, FontStyle.Underline, GraphicsUnit.Point);

            float lineHeight = myFont.GetHeight(e.Graphics) + 50;

            int hauteurTexte = 210;

            float yLineTop = e.MarginBounds.Top;

            for (; _Line < 3; _Line++)
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
