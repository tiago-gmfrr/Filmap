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
            string budget, string langueOri, string noteImdb, List<string> genres)
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
            foreach (string genre in genres)
            {
                tbxGenre.Text += genre + Environment.NewLine;
            }
        }
    }
}
