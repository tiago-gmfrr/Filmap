namespace Filmap
{
    partial class frmCreationCompte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreationCompte));
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxPseudo = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.btnCreationCompte = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(26, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(262, 34);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Créer son compte";
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.Location = new System.Drawing.Point(28, 85);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(121, 19);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Votre pseudo :";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.Location = new System.Drawing.Point(28, 141);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(165, 19);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Votre mot de passe :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(28, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Votre email :";
            // 
            // tbxPseudo
            // 
            this.tbxPseudo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPseudo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPseudo.Location = new System.Drawing.Point(201, 84);
            this.tbxPseudo.Name = "tbxPseudo";
            this.tbxPseudo.Size = new System.Drawing.Size(189, 20);
            this.tbxPseudo.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(201, 114);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(189, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMotDePasse.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMotDePasse.Location = new System.Drawing.Point(201, 142);
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.PasswordChar = '•';
            this.tbxMotDePasse.Size = new System.Drawing.Size(189, 20);
            this.tbxMotDePasse.TabIndex = 6;
            // 
            // btnCreationCompte
            // 
            this.btnCreationCompte.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreationCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreationCompte.FlatAppearance.BorderSize = 0;
            this.btnCreationCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreationCompte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreationCompte.Location = new System.Drawing.Point(280, 172);
            this.btnCreationCompte.Name = "btnCreationCompte";
            this.btnCreationCompte.Size = new System.Drawing.Size(110, 26);
            this.btnCreationCompte.TabIndex = 8;
            this.btnCreationCompte.Text = "Créer un compte";
            this.btnCreationCompte.UseVisualStyleBackColor = false;
            this.btnCreationCompte.Click += new System.EventHandler(this.btnCreationCompte_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(201, 172);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(73, 26);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // frmCreationCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(419, 210);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnCreationCompte);
            this.Controls.Add(this.tbxMotDePasse);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPseudo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblTitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCreationCompte";
            this.Text = "Créer son compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxPseudo;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxMotDePasse;
        private System.Windows.Forms.Button btnCreationCompte;
        private System.Windows.Forms.Button btnAnnuler;
    }
}