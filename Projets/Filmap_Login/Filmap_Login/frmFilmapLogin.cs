using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmap_Login
{
    public partial class frmFilmapLogin : Form
    {
        public frmFilmapLogin()
        {
            InitializeComponent();
        }

        private void tsmSeConnecter_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            frmLogin.ShowDialog();

            DialogResult dialogResult = frmLogin.DialogResult;
        }
    }
}
