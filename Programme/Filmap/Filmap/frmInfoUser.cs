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
    public partial class frmInfoUser : Form
    {
        frmMain _fm;
        Models.Utilisateur utilisateur = new Models.Utilisateur();
        public frmInfoUser(frmMain fm, Models.Utilisateur user)
        {
            _fm = fm;
            utilisateur.Email = user.Email;
            utilisateur.Pseudo = user.Pseudo;
            InitializeComponent();
        }

        private void frmInfoUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fm.Visible = true;
        }

        private void frmInfoUser_Load(object sender, EventArgs e)
        {
            tbxEmail.Text = utilisateur.Email;
            tbxPseudo.Text = utilisateur.Pseudo;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
