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
        List<dynamic> dynList;
        Dictionary<int, string> films = new Dictionary<int, string>();
        Classes.RecupFilms RecupFilms = new Classes.RecupFilms();
        frmAccueil FrmAccueil;

        public frmMain(frmAccueil frmAccueil)
        {
            InitializeComponent();
            FrmAccueil = frmAccueil;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            films = RecupFilms.RecupererFilmsTendance();
            dynList = new List<dynamic>();
            foreach (KeyValuePair<int, string> film in films)
            {
                dynList.Add(new { Id = film.Key, Name = film.Value });
            }

            lsbFilmTendance.DataSource = dynList;
            lsbFilmTendance.DisplayMember = "Name";
            lsbFilmTendance.ValueMember = "Id";
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

                Dictionary<int, string> filmsCherches = new Dictionary<int, string>();

                filmsCherches = RecupFilms.RecupRechercheFilmParNom(filmAChercher);

                dynList = new List<dynamic>();

                foreach (KeyValuePair<int, string> film in filmsCherches)
                {
                    dynList.Add(new { Id = film.Key, Name = film.Value });
                }

                lsbFilmTendance.DataSource = dynList;
                lsbFilmTendance.DisplayMember = "Name";
                lsbFilmTendance.ValueMember = "Id";

                
            }
            else
            {
 
                dynList = new List<dynamic>();
                foreach (KeyValuePair<int, string> film in films)
                {
                    dynList.Add(new { Id = film.Key, Name = film.Value });
                }

                lsbFilmTendance.DataSource = dynList;
                lsbFilmTendance.DisplayMember = "Name";
                lsbFilmTendance.ValueMember = "Id";
            }
        }

        public void AfficherDetailsFilm()
        {
            bool status = false;

            string titre = "";
            string dateSortie = "";
            string realisateur = "";
            string synopsis = "";
            string budget = "";
            string noteIMDB = "";
            string chiffreAffaire = "";
            string langueOri = "";
            List<string> genres = new List<string>();
            Dictionary<string, object> donnees = new Dictionary<string, object>();
            
            
            try
            {
                
                int idFilm = (int)lsbFilmTendance.SelectedValue;

                donnees = RecupFilms.InfosFilmPrecis(idFilm);

                foreach (KeyValuePair<string, object> donnee in donnees)
                {
                    realisateur = RecupFilms.RecupDirecteur(idFilm);

                    switch (donnee.Key)
                    {
                        case "release_date":
                            dateSortie = donnee.Value.ToString();
                            break;
                        case "title":
                            titre = donnee.Value.ToString();
                            break;
                        case "overview":
                            synopsis = donnee.Value.ToString();
                            break;
                        case "vote_average":
                            noteIMDB = donnee.Value.ToString();
                            break;
                        case "budget":
                            if (long.Parse(donnee.Value.ToString()) > 0)
                                budget = donnee.Value.ToString();
                            else
                                budget = "N/C";
                            break;
                        case "revenue":
                            if (long.Parse(donnee.Value.ToString()) > 0)
                                chiffreAffaire = donnee.Value.ToString();
                            else
                                chiffreAffaire = "N/C";
                            break;
                        case "original_language":
                            langueOri = donnee.Value.ToString();
                            langueOri = langueOri.ToUpper();
                            break;
                        case "genres":
                            foreach (Dictionary<string, object> infos in donnee.Value as object[])
                            {
                                genres.Add(infos["name"].ToString());
                            }
                            break;
                    }
                }
                status = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Le serveur n'a pas répondu !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Vérifie que le code s'est bien éxécuté et affiche la fenêtre de détails
            if (status)
            {
                frmDetailFilm frmDetailFilm = new frmDetailFilm(titre, dateSortie, realisateur,
                                        synopsis, chiffreAffaire, budget, langueOri, noteIMDB, genres);
                frmDetailFilm.Show();
                
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmAccueil.Visible = true;
        }
    }
}
