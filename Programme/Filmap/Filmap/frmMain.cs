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
<<<<<<< HEAD
        string genre = "All";
        List<dynamic> dynList;
=======
>>>>>>> d34e9ccecc681fe9ffa030adee6b0b25a3228ac7
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
            
<<<<<<< HEAD
            ListGenres = Classes.RecupFilms.RecupGenreFilms();
            films = Classes.RecupFilms.RecupererFilmsTendance(genre, ListGenres);

            foreach (var item in genres)
            {
                cmbFiltreGenre.Items.Add(item.NomGenre);
            }
=======
            films = Classes.FilmModel.RecupererFilmsTendance();
            RefreshListBoxDataSource();
        }

        private void RefreshListBoxDataSource()
        {
>>>>>>> d34e9ccecc681fe9ffa030adee6b0b25a3228ac7
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

        private void cmbFiltreGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            genre = cmbFiltreGenre.SelectedItem.ToString();
        }
    }
}
