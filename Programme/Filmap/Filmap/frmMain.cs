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
            films = RecupFilms.RecupererFilms();

            foreach (string film in films)
            {
                lsbFilmTendance.Items.Add(film);
            }


        }

        private void lsbFilmTendance_DoubleClick(object sender, EventArgs e)
        {
            string titre = "";
            string dateSortie = "";
            string realisateur = "";
            string synopsis = "";
            string budget = "";
            string noteIMDB = "";
            string chiffreAffaire = "";
            string langueOri = "";
            List<string> genres = new List<string>();

            foreach (string item in films)
            {
                if (item == lsbFilmTendance.SelectedItem.ToString())
                {

                    Dictionary<string, object> donnees = RecupFilms.InfosFilmPrecis(RecupFilms.RecupIdFilm(item));

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
                                if ((int)donnee.Value > 0)
                                    budget = donnee.Value.ToString();
                                else
                                    budget = "N/C";
                                break;
                            case "revenue":
                                if ((int)donnee.Value > 0)
                                    chiffreAffaire = donnee.Value.ToString();
                                else
                                    chiffreAffaire = "N/C";
                                break;
                            case "original_language":
                                langueOri = donnee.Value.ToString();
                                langueOri = langueOri.ToUpper();
                                break;
                            case "genres":
                                foreach (Dictionary<string, object> machin in donnee.Value as object[])
                                {
                                    genres.Add(machin["name"].ToString());
                                }
                                break;
                        }


                    }



                    frmDetailFilm frmDetailFilm = new frmDetailFilm(titre, dateSortie, realisateur, 
                        synopsis, chiffreAffaire, budget, langueOri, noteIMDB, genres);
                    frmDetailFilm.ShowDialog();
                }
            }
        }
    }
}
