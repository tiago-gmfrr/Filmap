/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Affichage des films préférés d'un utilisateur
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
    public partial class frmListeFilms : Form
    {
        frmMain _fm;
        Models.Utilisateur utilisateur = new Models.Utilisateur();
        public frmListeFilms(frmMain fm, Models.Utilisateur user)
        {
            _fm = fm;
            utilisateur.FilmPrefere = user.FilmPrefere;
            InitializeComponent();
        }

        private void listeFilmsPrefere_FormClosing(object sender, FormClosingEventArgs e)
        {
            _fm.Visible = true;
        }

        private void listeFilmsPrefere_Load(object sender, EventArgs e)
        {
            tbxFilmsPrefere.Text = "";
            
            foreach (var film in utilisateur.FilmPrefere)
            {
                tbxFilmsPrefere.Text += film.Titre + Environment.NewLine;
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
