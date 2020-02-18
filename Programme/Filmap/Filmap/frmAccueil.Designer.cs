namespace Filmap
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.lblAccueil = new System.Windows.Forms.Label();
            this.lblPseudo = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.tbxPseudo = new System.Windows.Forms.TextBox();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnInvite = new System.Windows.Forms.Button();
            this.btnCreationCompte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAccueil
            // 
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.BackColor = System.Drawing.Color.Firebrick;
            this.lblAccueil.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccueil.Location = new System.Drawing.Point(242, 49);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(385, 41);
            this.lblAccueil.TabIndex = 0;
            this.lblAccueil.Text = "Veuillez vous identifier";
            this.lblAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPseudo
            // 
            this.lblPseudo.AutoSize = true;
            this.lblPseudo.BackColor = System.Drawing.Color.Firebrick;
            this.lblPseudo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPseudo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPseudo.Location = new System.Drawing.Point(168, 165);
            this.lblPseudo.Name = "lblPseudo";
            this.lblPseudo.Size = new System.Drawing.Size(179, 29);
            this.lblPseudo.TabIndex = 1;
            this.lblPseudo.Text = "Votre pseudo :";
            this.lblPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.BackColor = System.Drawing.Color.Firebrick;
            this.lblMotDePasse.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotDePasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMotDePasse.Location = new System.Drawing.Point(101, 232);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(246, 29);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Votre mot de passe :";
            this.lblMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPseudo
            // 
            this.tbxPseudo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxPseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPseudo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPseudo.Location = new System.Drawing.Point(381, 165);
            this.tbxPseudo.Multiline = true;
            this.tbxPseudo.Name = "tbxPseudo";
            this.tbxPseudo.Size = new System.Drawing.Size(223, 29);
            this.tbxPseudo.TabIndex = 3;
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxMotDePasse.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMotDePasse.Location = new System.Drawing.Point(381, 232);
            this.tbxMotDePasse.Multiline = true;
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.PasswordChar = '•';
            this.tbxMotDePasse.Size = new System.Drawing.Size(223, 29);
            this.tbxMotDePasse.TabIndex = 4;
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.Firebrick;
            this.btnConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(494, 284);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(110, 26);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnInvite
            // 
            this.btnInvite.BackColor = System.Drawing.Color.Firebrick;
            this.btnInvite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInvite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvite.Location = new System.Drawing.Point(494, 316);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Size = new System.Drawing.Size(110, 26);
            this.btnInvite.TabIndex = 6;
            this.btnInvite.Text = "Mode invité";
            this.btnInvite.UseVisualStyleBackColor = false;
            this.btnInvite.Click += new System.EventHandler(this.btnInvite_Click);
            // 
            // btnCreationCompte
            // 
            this.btnCreationCompte.BackColor = System.Drawing.Color.Firebrick;
            this.btnCreationCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreationCompte.FlatAppearance.BorderSize = 0;
            this.btnCreationCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreationCompte.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreationCompte.Location = new System.Drawing.Point(381, 284);
            this.btnCreationCompte.Name = "btnCreationCompte";
            this.btnCreationCompte.Size = new System.Drawing.Size(110, 26);
            this.btnCreationCompte.TabIndex = 7;
            this.btnCreationCompte.Text = "Créer un compte";
            this.btnCreationCompte.UseVisualStyleBackColor = false;
            this.btnCreationCompte.Click += new System.EventHandler(this.btnCreationCompte_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(836, 452);
            this.Controls.Add(this.btnCreationCompte);
            this.Controls.Add(this.btnInvite);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.tbxMotDePasse);
            this.Controls.Add(this.tbxPseudo);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblPseudo);
            this.Controls.Add(this.lblAccueil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAccueil";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue dans Filmap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.Label lblPseudo;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox tbxPseudo;
        private System.Windows.Forms.TextBox tbxMotDePasse;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnInvite;
        private System.Windows.Forms.Button btnCreationCompte;
    }
}

