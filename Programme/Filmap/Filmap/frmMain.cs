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
        string genre = "All";
        List<dynamic> dynList;
        List<Film> films = new List<Film>();
        List<Genres> genres = new List<Genres>();
        frmAccueil FrmAccueil;

        public frmMain(frmAccueil frmAccueil)
        {
            InitializeComponent();
            FrmAccueil = frmAccueil;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            ListGenres = Classes.RecupFilms.RecupGenreFilms();
            films = Classes.RecupFilms.RecupererFilmsTendance(genre, ListGenres);

            foreach (var item in genres)
            {
                cmbFiltreGenre.Items.Add(item.NomGenre);
            }
            lsbFilmTendance.DataSource = films;
            lsbFilmTendance.DisplayMember = "Titre";
            lsbFilmTendance.ValueMember = "IdFilm";
        }

        private void lsbFilmTendance_DoubleClick(object sender, EventArgs e)
        {
            AfficherDetailsFilm();
        }



        private void tbxRecherche_TextChanged(object sender, EventArgs e)
        {
            string filmAChercher = string.Empty;

            if (tbxRecherche.Text != "")
            {
                filmAChercher = tbxRecherche.Text;

                films = Classes.RecupFilms.RecupRechercheFilmParNom(filmAChercher);

                lsbFilmTendance.DataSource = films;
                lsbFilmTendance.DisplayMember = "Titre";
                lsbFilmTendance.ValueMember = "IdFilm";
            }
            else
            {
                

                lsbFilmTendance.DataSource = films;
                lsbFilmTendance.DisplayMember = "Titre";
                lsbFilmTendance.ValueMember = "IdFilm";
            }
        }

        private void CreationListDynamic(string filmAChercher)
        {

        }

        public void AfficherDetailsFilm()
        {
            int idFilm = (int)lsbFilmTendance.SelectedValue;
            Film f = Classes.RecupFilms.InfosFilmPrecis(idFilm);

            //Vérifie que le code s'est bien éxécuté et affiche la fenêtre de détails
            if (f != null)
            {
                frmDetailFilm frmDetailFilm = new frmDetailFilm(f.Titre, f.DateSortie, f.Realisateur,
                                    f.Synopsis, f.ChiffreAffaire, f.Budget, f.LangueOriginale, f.NoteIMDB, f.Genres);
                frmDetailFilm.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAccueil.Visible = true;
        }

        private void cmbFiltreGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre = cmbFiltreGenre.SelectedItem.ToString();
        }
    }
}
