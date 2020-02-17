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

            foreach (string item in films)
            {
                if (item == lsbFilmTendance.SelectedItem.ToString())
                {
                    Console.WriteLine(RecupFilms.RecupIdFilm(item));

                    Dictionary<string, object> donnees = RecupFilms.InfosFilmPrecis(RecupFilms.RecupIdFilm(item));

                    foreach (KeyValuePair<string, object> donnee in donnees)
                    {
                        Console.WriteLine("Key : " + donnee.Key + " Value : " + donnee.Value);
                        if (donnee.Key == "budget")
                        {
                            budget = donnee.Value.ToString();
                        }
                        if (donnee.Key == "release_date")
                        {
                            dateSortie = donnee.Value.ToString();
                        }
                        if (donnee.Key == "production_companies")
                        {
                            //A voir
                            realisateur = "N/C";
                        }
                        if (donnee.Key == "original_title")
                        {
                            titre = donnee.Value.ToString();
                        }
                        if (donnee.Key == "overview")
                        {
                            synopsis = donnee.Value.ToString();
                        }
                        if (donnee.Key == "vote_average")
                        {
                            noteIMDB = donnee.Value.ToString();
                        }
                        if (donnee.Key == "revenue")
                        {
                            chiffreAffaire = donnee.Value.ToString();
                        }
                        if (donnee.Key == "original_language")
                        {
                            langueOri = donnee.Value.ToString();
                        }
                    }

                    frmDetailFilm frmDetailFilm = new frmDetailFilm(titre, dateSortie, realisateur, synopsis, chiffreAffaire, budget, langueOri, noteIMDB);
                    frmDetailFilm.ShowDialog();
                }
            }
        }
    }
}
