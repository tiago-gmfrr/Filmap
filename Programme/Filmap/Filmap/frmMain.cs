using Filmap.Models;
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
        private string filtreGenre = "";
        private string pseudo = "";

        List<Film> films = new List<Film>();
        List<Genre> genres = new List<Genre>();
        frmAccueil FrmAccueil;
        Utilisateur user = new Utilisateur();

        public string FiltreGenre { get => filtreGenre; set => filtreGenre = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }

        public frmMain(frmAccueil frmAccueil, string pseudo)
        {
            Pseudo = pseudo;
            InitializeComponent();
            FrmAccueil = frmAccueil;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            films = Models.FilmControleur.RecupererFilmsTendance(filtreGenre);
            genres = Models.FilmControleur.RecupGenresFilms();

            user.Pseudo = Pseudo;
            user.Email = Models.dbConnection.getUserEmail(Pseudo);

            if (Pseudo != "")
            {
                msConnecte.Visible = true;
                btnAjouterFilmAvoir.Visible = true;
                btnAjouterFilmPrefere.Visible = true;
            }
            foreach (var item in genres)
            {
                cmbFiltreGenre.Items.Add(item.NameGenre);  
            }

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
            Models.FilmControleur.AfficherDetailsFilm(idFilm);
        }



        private void tbxRecherche_TextChanged(object sender, EventArgs e)
        {
            string filmAChercher = tbxRecherche.Text;

            films = Models.FilmControleur.RechercheFilmParNom(filmAChercher, filtreGenre);

            RefreshListBoxDataSource();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAccueil.Visible = true;
        }

       

        private void cmbFiltreGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreGenre = cmbFiltreGenre.SelectedItem.ToString();
            films = Models.FilmControleur.RecupererFilmsTendance(FiltreGenre);

            RefreshListBoxDataSource();
        }

        private void tsmVoirMesListes_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Models.FilmControleur.infoUtilisateur(this, user);
        }

        private void btnAjouterFilmPrefere_Click(object sender, EventArgs e)
        {
            Film t = (Film)lsbFilmTendance.SelectedItem;
            string titre = t.Titre;
           
            Film newFilm = new Film(titre);
            user.ajouterFilmDansFilmPrefere(newFilm);
        }

        

        private void tsmSeDeconnecter_Click(object sender, EventArgs e)
        {
            Pseudo = "";
            this.Close();
        }

        private void tsmVoirMesListe_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Models.FilmControleur.voirListes(this, user);
        }

        
    }
}
