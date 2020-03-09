using Filmap.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmap
{
    public partial class frmMain : Form
    {
        List<Film> films = new List<Film>();
        frmAccueil FrmAccueil;

        public frmMain(frmAccueil frmAccueil)
        {
            InitializeComponent();
            FrmAccueil = frmAccueil;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            films = Classes.FilmModel.RecupererFilmsTendance();
            RefreshListBoxDataSource();
        }

        private void RefreshListBoxDataSource()
        {
            lsbFilmTendance.DataSource = films;
            lsbFilmTendance.DisplayMember = "Titre";
            lsbFilmTendance.ValueMember = "IdFilm";
        }

        private void lsbFilmTendance_DoubleClick(object sender, EventArgs e)
        {
            int idFilm = (int)lsbFilmTendance.SelectedValue;
            Classes.FilmModel.AfficherDetailsFilm(idFilm);
        }



        private void tbxRecherche_TextChanged(object sender, EventArgs e)
        {
            string filmAChercher = tbxRecherche.Text;

            films = Classes.FilmModel.RechercheFilmParNom(filmAChercher);

            RefreshListBoxDataSource();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAccueil.Visible = true;
        }
    }
}
