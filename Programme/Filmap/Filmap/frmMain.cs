/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Affichage des films
 * 
 */

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

        public string FiltreGenre { get => filtreGenre; set => filtreGenre = value; }
        public string Pseudo { get => pseudo; set => pseudo = value; }

        public frmMain(frmAccueil frmAccueil, string pseudo)
        {
            Pseudo = pseudo;
            InitializeComponent();
            FrmAccueil = frmAccueil;
        }

        /// <summary>
        /// Récupère les films tendance et les genres de films 
        /// et ensuite les affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            films = Models.FilmControleur.RecupererFilmsTendance(filtreGenre);
            genres = Models.FilmControleur.RecupGenresFilms();

            if (Pseudo == "")
            {
                msConnecte.Visible = false;
            }

            foreach (var item in genres)
            {
                cmbFiltreGenre.Items.Add(item.NameGenre);  
            }
            cmbFiltre.SelectedIndex = 0;
            cmbFiltreGenre.SelectedIndex = 0;
            RefreshListBoxDataSource();
        }

        /// <summary>
        /// Actualise la listbox des films
        /// </summary>
        private void RefreshListBoxDataSource()
        {
            lsbFilmTendance.DataSource = films;
            lsbFilmTendance.DisplayMember = "Titre";
            lsbFilmTendance.ValueMember = "IdFilm";
        }
        /// <summary>
        /// Ouvre une form contenant plus d'informations sur le film choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbFilmTendance_DoubleClick(object sender, EventArgs e)
        {
            int idFilm = (int)lsbFilmTendance.SelectedValue;
            Models.FilmControleur.AfficherDetailsFilm(idFilm);
        }


        /// <summary>
        /// Actualise la recherche à chaque fois que l'utilisateur ecris sur la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltre.SelectedItem.ToString() == "Recherche d'acteurs")
            {
                cmbFiltreGenre.Enabled = false;
                btnAjouterFilmAvoir.Visible = false;
                btnAjouterFilmPrefere.Visible = false;
                btnAjouterActeurPrefere.Visible = true;
            }
            else
            {
                cmbFiltreGenre.Enabled = true;
                btnAjouterFilmAvoir.Visible = true;
                btnAjouterFilmPrefere.Visible = true;
                btnAjouterActeurPrefere.Visible = false;
            }
        }

        /// <summary>
        /// Choix d'un filtre de genre pour les films
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFiltreGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreGenre = cmbFiltreGenre.SelectedItem.ToString();

            if (tbxRecherche.Text == string.Empty)
            {
                films = Models.FilmControleur.RecupererFilmsTendance(FiltreGenre);
            }
            else
            {
                films = Models.FilmControleur.RechercheFilmParNom(tbxRecherche.Text, FiltreGenre);
            }
            
            RefreshListBoxDataSource();
        }
    }
}
