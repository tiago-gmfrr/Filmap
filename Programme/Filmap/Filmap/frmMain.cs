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

        List<string> films = new List<string>();
        Classes.RecupFilms RecupFilms = new Classes.RecupFilms();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            films = RecupFilms.RecupererFilmsTendance();

            foreach (string film in films)
            {
                lsbFilmTendance.Items.Add(film);
            }
        }

        private void lsbFilmTendance_DoubleClick(object sender, EventArgs e)
        {
            AfficherDetailsFilm();
        }

        

        private void tbxRecherche_TextChanged(object sender, EventArgs e)
        {
            string filmAChercher = string.Empty;
            lsbFilmTendance.Items.Clear();
            if (tbxRecherche.Text != "")
            {
                filmAChercher = tbxRecherche.Text;

                List<string> filmsCherches = new List<string>();

                filmsCherches = RecupFilms.RecupRechercheFilmParNom(filmAChercher);
                
                foreach (string film in filmsCherches)
                {
                    if (!films.Contains(film))
                    {
                        films.Add(film);
                    }

                    lsbFilmTendance.Items.Add(film);
                }
            }
            else
            {
                foreach (string film in films)
                {
                    lsbFilmTendance.Items.Add(film);
                }
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


            foreach (string item in films)
            {
                if (item == lsbFilmTendance.SelectedItem.ToString())
                {
                    try
                    {
                        int idFilm = RecupFilms.RecupIdFilm(item);
                        donnees = RecupFilms.InfosFilmPrecis(idFilm);

                        foreach (KeyValuePair<string, object> donnee in donnees)
                        {
                            realisateur = RecupFilms.RecupDirecteur(RecupFilms.RecupIdFilm(item));

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
                }
            }
            //Vérifie que le code s'est bien éxécuté et affiche la fenêtre de détails
            if (status)
            {
                frmDetailFilm frmDetailFilm = new frmDetailFilm(titre, dateSortie, realisateur,
                                        synopsis, chiffreAffaire, budget, langueOri, noteIMDB, genres);
                frmDetailFilm.ShowDialog();
            }
        }
    }
}
