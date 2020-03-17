namespace Filmap
{
    partial class frmListeFilms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitreFilmPrefere = new System.Windows.Forms.Label();
            this.tbxFilmsPrefere = new System.Windows.Forms.TextBox();
            this.lblFilmPrefere = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitreFilmPrefere
            // 
            this.lbTitreFilmPrefere.AutoSize = true;
            this.lbTitreFilmPrefere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitreFilmPrefere.ForeColor = System.Drawing.Color.White;
            this.lbTitreFilmPrefere.Location = new System.Drawing.Point(15, 62);
            this.lbTitreFilmPrefere.Name = "lbTitreFilmPrefere";
            this.lbTitreFilmPrefere.Size = new System.Drawing.Size(39, 13);
            this.lbTitreFilmPrefere.TabIndex = 0;
            this.lbTitreFilmPrefere.Text = "Titres";
            // 
            // tbxFilmsPrefere
            // 
            this.tbxFilmsPrefere.Location = new System.Drawing.Point(72, 59);
            this.tbxFilmsPrefere.Multiline = true;
            this.tbxFilmsPrefere.Name = "tbxFilmsPrefere";
            this.tbxFilmsPrefere.ReadOnly = true;
            this.tbxFilmsPrefere.Size = new System.Drawing.Size(216, 337);
            this.tbxFilmsPrefere.TabIndex = 9;
            // 
            // lblFilmPrefere
            // 
            this.lblFilmPrefere.AutoSize = true;
            this.lblFilmPrefere.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmPrefere.Location = new System.Drawing.Point(12, 9);
            this.lblFilmPrefere.Name = "lblFilmPrefere";
            this.lblFilmPrefere.Size = new System.Drawing.Size(288, 34);
            this.lblFilmPrefere.TabIndex = 10;
            this.lblFilmPrefere.Text = "Mes films préférés :";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetour.Location = new System.Drawing.Point(215, 412);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(73, 26);
            this.btnRetour.TabIndex = 11;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // frmListeFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(306, 450);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.lblFilmPrefere);
            this.Controls.Add(this.tbxFilmsPrefere);
            this.Controls.Add(this.lbTitreFilmPrefere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmListeFilms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mes listes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.listeFilmsPrefere_FormClosing);
            this.Load += new System.EventHandler(this.listeFilmsPrefere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxFilmsPrefere;
        private System.Windows.Forms.Label lbTitreFilmPrefere;
        private System.Windows.Forms.Label lblFilmPrefere;
        private System.Windows.Forms.Button btnRetour;
    }
}