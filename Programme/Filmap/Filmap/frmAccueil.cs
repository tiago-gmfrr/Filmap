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
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnCreationCompte_Click(object sender, EventArgs e)
        {
            frmCreationCompte signupForm = new frmCreationCompte();
            signupForm.ShowDialog();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {

        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            
            frmMain.Show();
            
        }
    }
}
