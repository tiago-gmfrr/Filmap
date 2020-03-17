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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbxRecherche = new System.Windows.Forms.TextBox();
            this.lsbFilmTendance = new System.Windows.Forms.ListBox();
            this.cmbFiltreGenre = new System.Windows.Forms.ComboBox();
            this.msConnecte = new System.Windows.Forms.MenuStrip();
            this.tsmMonProfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVoirMesInfos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVoirMesListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeDeconnecter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouterFilmPrefere = new System.Windows.Forms.Button();
            this.btnAjouterFilmAvoir = new System.Windows.Forms.Button();
            this.msConnecte.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.Location = new System.Drawing.Point(12, 35);
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(254, 20);
            this.tbxRecherche.TabIndex = 0;
            this.tbxRecherche.TextChanged += new System.EventHandler(this.tbxRecherche_TextChanged);
            // 
            // lsbFilmTendance
            // 
            this.lsbFilmTendance.FormattingEnabled = true;
            this.lsbFilmTendance.Location = new System.Drawing.Point(12, 61);
            this.lsbFilmTendance.Name = "lsbFilmTendance";
            this.lsbFilmTendance.Size = new System.Drawing.Size(254, 290);
            this.lsbFilmTendance.TabIndex = 3;
            this.lsbFilmTendance.DoubleClick += new System.EventHandler(this.lsbFilmTendance_DoubleClick);
            // 
            // cmbFiltreGenre
            // 
            this.cmbFiltreGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltreGenre.FormattingEnabled = true;
            this.cmbFiltreGenre.Items.AddRange(new object[] {
            "Pas de filtre"});
            this.cmbFiltreGenre.Location = new System.Drawing.Point(272, 35);
            this.cmbFiltreGenre.Name = "cmbFiltreGenre";
            this.cmbFiltreGenre.Size = new System.Drawing.Size(153, 21);
            this.cmbFiltreGenre.TabIndex = 4;
            this.cmbFiltreGenre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltreGenre_SelectedIndexChanged);
            // 
            // msConnecte
            // 
            this.msConnecte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMonProfil});
            this.msConnecte.Location = new System.Drawing.Point(0, 0);
            this.msConnecte.Name = "msConnecte";
            this.msConnecte.Size = new System.Drawing.Size(437, 24);
            this.msConnecte.TabIndex = 5;
            this.msConnecte.Text = "menuStrip1";
            this.msConnecte.Visible = false;
            // 
            // tsmMonProfil
            // 
            this.tsmMonProfil.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVoirMesInfos,
            this.tsmVoirMesListe,
            this.tsmSeDeconnecter});
            this.tsmMonProfil.Name = "tsmMonProfil";
            this.tsmMonProfil.Size = new System.Drawing.Size(75, 20);
            this.tsmMonProfil.Text = "Mon profil";
            // 
            // tsmVoirMesInfos
            // 
            this.tsmVoirMesInfos.Name = "tsmVoirMesInfos";
            this.tsmVoirMesInfos.Size = new System.Drawing.Size(180, 22);
            this.tsmVoirMesInfos.Text = "Voir mes infos";
            this.tsmVoirMesInfos.Click += new System.EventHandler(this.tsmVoirMesListes_Click);
            // 
            // tsmVoirMesListe
            // 
            this.tsmVoirMesListe.Name = "tsmVoirMesListe";
            this.tsmVoirMesListe.Size = new System.Drawing.Size(180, 22);
            this.tsmVoirMesListe.Text = "Voir mes listes";
            this.tsmVoirMesListe.Click += new System.EventHandler(this.tsmVoirMesListe_Click);
            // 
            // tsmSeDeconnecter
            // 
            this.tsmSeDeconnecter.Name = "tsmSeDeconnecter";
            this.tsmSeDeconnecter.Size = new System.Drawing.Size(180, 22);
            this.tsmSeDeconnecter.Text = "Se déconnecter";
            this.tsmSeDeconnecter.Click += new System.EventHandler(this.tsmSeDeconnecter_Click);
            // 
            // btnAjouterFilmPrefere
            // 
            this.btnAjouterFilmPrefere.Location = new System.Drawing.Point(272, 61);
            this.btnAjouterFilmPrefere.Name = "btnAjouterFilmPrefere";
            this.btnAjouterFilmPrefere.Size = new System.Drawing.Size(153, 38);
            this.btnAjouterFilmPrefere.TabIndex = 6;
            this.btnAjouterFilmPrefere.Text = "Ajouter à la liste de films préférés";
            this.btnAjouterFilmPrefere.UseVisualStyleBackColor = true;
            this.btnAjouterFilmPrefere.Visible = false;
            this.btnAjouterFilmPrefere.Click += new System.EventHandler(this.btnAjouterFilmPrefere_Click);
            // 
            // btnAjouterFilmAvoir
            // 
            this.btnAjouterFilmAvoir.Location = new System.Drawing.Point(272, 105);
            this.btnAjouterFilmAvoir.Name = "btnAjouterFilmAvoir";
            this.btnAjouterFilmAvoir.Size = new System.Drawing.Size(153, 38);
            this.btnAjouterFilmAvoir.TabIndex = 7;
            this.btnAjouterFilmAvoir.Text = "Ajouter à la liste de films à regarder";
            this.btnAjouterFilmAvoir.UseVisualStyleBackColor = true;
            this.btnAjouterFilmAvoir.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(437, 363);
            this.Controls.Add(this.btnAjouterFilmAvoir);
            this.Controls.Add(this.btnAjouterFilmPrefere);
            this.Controls.Add(this.cmbFiltreGenre);
            this.Controls.Add(this.lsbFilmTendance);
            this.Controls.Add(this.tbxRecherche);
            this.Controls.Add(this.msConnecte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msConnecte;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msConnecte.ResumeLayout(false);
            this.msConnecte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.ListBox lsbFilmTendance;
        private System.Windows.Forms.ComboBox cmbFiltreGenre;
        private System.Windows.Forms.MenuStrip msConnecte;
        private System.Windows.Forms.ToolStripMenuItem tsmMonProfil;
        private System.Windows.Forms.ToolStripMenuItem tsmVoirMesInfos;
        private System.Windows.Forms.ToolStripMenuItem tsmVoirMesListe;
        private System.Windows.Forms.ToolStripMenuItem tsmSeDeconnecter;
        private System.Windows.Forms.Button btnAjouterFilmPrefere;
        private System.Windows.Forms.Button btnAjouterFilmAvoir;
    }
}