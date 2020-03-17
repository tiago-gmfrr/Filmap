/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Affichage de toutes les données d'un film
 * 
 */
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
    public partial class frmDetailFilm : Form
    {
        public frmDetailFilm()
        {
            InitializeComponent();
        }

        public frmDetailFilm(string titre, string dateSortie, string realisateur, string synopsis, string chiffreAffaire, 
            string budget, string langueOri, string noteImdb, List<Models.Genre> genres)
        {
            InitializeComponent();
            //Met toutes les données dans les contrôleurs
            tbxTitre.Text = titre;
            tbxDateSortie.Text = dateSortie;
            tbxRealisateur.Text = realisateur;
            tbxSynopsis.Text = synopsis;
            tbxChiffre.Text = chiffreAffaire;
            tbxBudget.Text = budget;
            tbxLangueOriginale.Text = langueOri;
            tbxNoteIMDB.Text = noteImdb;
            foreach (Models.Genre genre in genres)
            {
                tbxGenre.Text += genre.NameGenre + Environment.NewLine;
            }
        }
    }
}
