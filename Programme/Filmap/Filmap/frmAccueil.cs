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

            string pseudo = "";
            string email = "";
            string mdp = "";
            frmCreationCompte signupForm = new frmCreationCompte();
            signupForm.ShowDialog();

            pseudo = signupForm.Pseudo;
            email = signupForm.Email;
            mdp = signupForm.MotDePasse;

            Classes.dbConnection.AjouterUser(pseudo, email, mdp);
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

            string pseudo = tbxPseudo.Text;
            string mdp = tbxMotDePasse.Text;

            if (pseudo != "" && mdp != "")
            {
                if (Classes.dbConnection.Connection(pseudo, mdp))
                {
                    MessageBox.Show("gg mec");
                }
                else
                {
                    MessageBox.Show("Le pseudo ou le mot de passe est erroné");
                    tbxMotDePasse.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(this);

            frmMain.Show();
            this.Visible = false;
        }

    }
}
