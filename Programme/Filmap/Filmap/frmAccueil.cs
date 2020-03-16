using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmap
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnCreationCompte_Click(object sender, EventArgs e)
        {
            Classes.FilmModel.CreationCompte();

        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

            string pseudo = tbxPseudo.Text;
            string mdp = tbxMotDePasse.Text;
            string erreur = Classes.FilmModel.Connection(pseudo, mdp);

            if (erreur != string.Empty)
            {
                MessageBox.Show(erreur);
            }

        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            Classes.FilmModel.ModeInvite(this);
            this.Visible = false;
        }

    }
}
