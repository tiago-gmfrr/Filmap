﻿namespace Filmap
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
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.lsbFilmTendance = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbxRecherche
            // 
            this.tbxRecherche.Location = new System.Drawing.Point(12, 12);
            this.tbxRecherche.Name = "tbxRecherche";
            this.tbxRecherche.Size = new System.Drawing.Size(254, 20);
            this.tbxRecherche.TabIndex = 0;
            this.tbxRecherche.TextChanged += new System.EventHandler(this.tbxRecherche_TextChanged);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "Recherche de films",
            "Recherche d\'acteurs"});
            this.cmbFiltre.Location = new System.Drawing.Point(272, 11);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(153, 21);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Comédie"});
            this.comboBox1.Location = new System.Drawing.Point(272, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(437, 343);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lsbFilmTendance);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.tbxRecherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRecherche;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.ListBox lsbFilmTendance;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}