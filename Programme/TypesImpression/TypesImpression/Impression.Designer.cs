namespace TypesImpression
{
    partial class frmImpression
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpression));
            this.prntPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.prntDoc = new System.Drawing.Printing.PrintDocument();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintDocument = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.pcbImages = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbNomFilms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxBudget = new System.Windows.Forms.TextBox();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPrinter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImages)).BeginInit();
            this.SuspendLayout();
            // 
            // prntPreviewDialog
            // 
            this.prntPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prntPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prntPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.prntPreviewDialog.Document = this.prntDoc;
            this.prntPreviewDialog.Enabled = true;
            this.prntPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("prntPreviewDialog.Icon")));
            this.prntPreviewDialog.Name = "prntPreviewDialog";
            this.prntPreviewDialog.Visible = false;
            // 
            // prntDoc
            // 
            this.prntDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prntDoc_PrintPage);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::TypesImpression.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(729, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(253, 114);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintDocument.Image = global::TypesImpression.Properties.Resources.print_5121;
            this.btnPrintDocument.Location = new System.Drawing.Point(729, 255);
            this.btnPrintDocument.Name = "btnPrintDocument";
            this.btnPrintDocument.Size = new System.Drawing.Size(253, 114);
            this.btnPrintDocument.TabIndex = 3;
            this.btnPrintDocument.Text = "Print Document";
            this.btnPrintDocument.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintDocument.UseVisualStyleBackColor = true;
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPreview.Image = global::TypesImpression.Properties.Resources.aaa3;
            this.btnPrintPreview.Location = new System.Drawing.Point(729, 135);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(253, 114);
            this.btnPrintPreview.TabIndex = 2;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // pcbImages
            // 
            this.pcbImages.Image = global::TypesImpression.Properties.Resources.titleFilmap;
            this.pcbImages.Location = new System.Drawing.Point(346, 12);
            this.pcbImages.Name = "pcbImages";
            this.pcbImages.Size = new System.Drawing.Size(302, 90);
            this.pcbImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbImages.TabIndex = 1;
            this.pcbImages.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type of Films : ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Films Préféres",
            "Films à voir",
            "Acteurs Préféres"});
            this.comboBox1.Location = new System.Drawing.Point(200, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // cmbNomFilms
            // 
            this.cmbNomFilms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomFilms.FormattingEnabled = true;
            this.cmbNomFilms.Items.AddRange(new object[] {
            "Titanic",
            "Inception",
            "The life of Tiago Gama",
            "Tiago gama is boring"});
            this.cmbNomFilms.Location = new System.Drawing.Point(200, 200);
            this.cmbNomFilms.Name = "cmbNomFilms";
            this.cmbNomFilms.Size = new System.Drawing.Size(216, 28);
            this.cmbNomFilms.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Actor : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name Of Film :";
            // 
            // tbxBudget
            // 
            this.tbxBudget.Enabled = false;
            this.tbxBudget.Location = new System.Drawing.Point(200, 257);
            this.tbxBudget.Multiline = true;
            this.tbxBudget.Name = "tbxBudget";
            this.tbxBudget.Size = new System.Drawing.Size(216, 28);
            this.tbxBudget.TabIndex = 11;
            // 
            // tbxNote
            // 
            this.tbxNote.Enabled = false;
            this.tbxNote.Location = new System.Drawing.Point(200, 306);
            this.tbxNote.Multiline = true;
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(216, 28);
            this.tbxNote.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Note IMDB :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Choose Printer : ";
            // 
            // cmbPrinter
            // 
            this.cmbPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrinter.FormattingEnabled = true;
            this.cmbPrinter.Location = new System.Drawing.Point(507, 409);
            this.cmbPrinter.Name = "cmbPrinter";
            this.cmbPrinter.Size = new System.Drawing.Size(216, 28);
            this.cmbPrinter.TabIndex = 14;
            // 
            // frmImpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 514);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPrinter);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNomFilms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintDocument);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.pcbImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImpression";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmap Printing";
            this.Load += new System.EventHandler(this.frmImpression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog prntPreviewDialog;
        private System.Drawing.Printing.PrintDocument prntDoc;
        private System.Windows.Forms.PictureBox pcbImages;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnPrintDocument;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbNomFilms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxBudget;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPrinter;
    }
}

