using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmap
{
    public partial class frmCreationCompte : Form
    {
        string pseudo = "";
        string email = "";
        string motDePasse = "";

        public frmCreationCompte()
        {
            InitializeComponent();
        }

        public string Pseudo { get => pseudo; set => tbxPseudo.Text = value; }
        public string Email { get => email; set => tbxEmail.Text = value; }
        public string MotDePasse { get => motDePasse; set => tbxMotDePasse.Text = value; }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCreationCompte_Click(object sender, EventArgs e)
        {
            pseudo = tbxPseudo.Text;
            email = tbxEmail.Text;
            motDePasse = tbxMotDePasse.Text;
            if (pseudo != "" && email != "" && motDePasse != "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vous devez remplir tous les champs");
            }         
        }
    }
}
