namespace Filmap
{
    partial class frmMain
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
            this.tbxRecherche = new System.Windows.Forms.TextBox();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.lsbFilmTendance = new System.Windows.Forms.ListBox();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.Location = new System.Drawing.Point(12, 12);
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(254, 20);
            this.tbxRecherche.TabIndex = 0;
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "Film par nom",
            "Film par catégorie",
            "Acteur par nom"});
            this.cmbFiltre.Location = new System.Drawing.Point(272, 11);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(109, 21);
            this.cmbFiltre.TabIndex = 2;
            // 
            // lsbFilmTendance
            // 
            this.lsbFilmTendance.FormattingEnabled = true;
            this.lsbFilmTendance.Location = new System.Drawing.Point(12, 38);
            this.lsbFilmTendance.Name = "lsbFilmTendance";
            this.lsbFilmTendance.Size = new System.Drawing.Size(254, 290);
            this.lsbFilmTendance.TabIndex = 3;
            this.lsbFilmTendance.DoubleClick += new System.EventHandler(this.lsbFilmTendance_DoubleClick);
            // 
            // btnRecherche
            // 
            this.btnRecherche.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRecherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRecherche.FlatAppearance.BorderSize = 0;
            this.btnRecherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecherche.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecherche.Location = new System.Drawing.Point(271, 38);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(110, 26);
            this.btnRecherche.TabIndex = 9;
            this.btnRecherche.Text = "Recherche";
            this.btnRecherche.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(403, 343);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.lsbFilmTendance);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.tbxRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Filmap";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.ListBox lsbFilmTendance;
        private System.Windows.Forms.Button btnRecherche;
    }
}