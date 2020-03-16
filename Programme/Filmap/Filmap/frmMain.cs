﻿using Filmap.Classes;
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

        List<Film> films = new List<Film>();
        List<Genre> genres = new List<Genre>();
        frmAccueil FrmAccueil;

        public string FiltreGenre { get => filtreGenre; set => filtreGenre = value; }

        public frmMain(frmAccueil frmAccueil)
        {
            InitializeComponent();
            FrmAccueil = frmAccueil;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            films = Classes.FilmModel.RecupererFilmsTendance();
            genres = Classes.FilmModel.RecupGenresFilms();
            
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

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltre.SelectedItem.ToString() == "Recherche d'acteurs")
            {
                cmbFiltreGenre.Enabled = false;
            }
            else
            {
                cmbFiltreGenre.Enabled = true;
            }
        }

        private void cmbFiltreGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreGenre = cmbFiltreGenre.SelectedItem.ToString();
            
        }
    }
}
