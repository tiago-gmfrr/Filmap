/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Tests de la classe RecupFilms.cs
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Filmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Models.Tests
{
    [TestClass()]
    public class RecupFilmsTests
    {
        /// <summary>
        /// Vérifier qu'un filme tendance est dans la liste récupérer par la méthode suivante,
        /// Nous avons choisit le filme Parasite, le 24/02/2020
        /// Dans le futur ce filme doit etre mis a jour.
        /// </summary>
        [TestMethod()]
        public void RecupererFilmsTendanceTest()
        {
            //à changer en fonction des films au box office
            // En 24/02/2020, film choisit : Parasite
            const string FILM_A_TESTER = "Parasite";

            const string NO_FILTER = "";
            //RecupFilms recupFilms = new RecupFilms();
            List<Film> films = Models.RecupFilms.RecupererFilmsTendance(NO_FILTER);
            List<string> listFilms = new List<string>();
            foreach (Film f in films)
            {
                listFilms.Add(f.Titre);
            }
            CollectionAssert.Contains(listFilms, FILM_A_TESTER);
        }

        /// <summary>
        /// Vérifier toutes les données récupérees d'un film
        /// 
        /// </summary>
        [TestMethod()]
        public void InfosFilmPrecisTest()
        {
            const int AVATAR_FILM_ID = 19995;
            Film f = Models.RecupFilms.InfosFilmPrecis(AVATAR_FILM_ID);

            const string TITRE_AVATAR = "Avatar";
            const string DIRECTEUR_AVATAR = "James Cameron";
            const string NOTE_AVATAR = "7.4";
            const string CHIFFRE_AFFAIRES_AVATAR = "2787965087";
            const string BUDGET_AVATAR = "237000000";
            const string DATE_SORTIE_AVATAR = "2009-12-10";
            const string LANGUE_ORIGINALE_AVATAR = "EN";

            Assert.AreEqual(TITRE_AVATAR, f.Titre);
            Assert.AreEqual(DIRECTEUR_AVATAR, f.Directeur);
            Assert.AreEqual(NOTE_AVATAR, f.NoteIMDB);
            Assert.AreEqual(CHIFFRE_AFFAIRES_AVATAR, f.ChiffreAffaire);
            Assert.AreEqual(BUDGET_AVATAR, f.Budget);
            Assert.AreEqual(DATE_SORTIE_AVATAR, f.DateSortie);
            Assert.AreEqual(LANGUE_ORIGINALE_AVATAR, f.LangueOriginale);
        }

        /// <summary>
        /// Vérifier si la méthode récupère le bon directeur
        /// </summary>
        [TestMethod()]
        public void RecupDirecteurTest()
        {

            const int AVATAR_FILM_ID = 19995;
            const string AVATAR_FILM_DIRECTEUR = "James Cameron";

            string directeur = Models.RecupFilms.RecupDirecteur(AVATAR_FILM_ID);
            Assert.AreEqual(AVATAR_FILM_DIRECTEUR, directeur);

        }

        /// <summary>
        /// Vérifier si le filtre de nom fonctionne        
        /// </summary>
        [TestMethod()]
        public void RecupRechercheFilmParNomTest()
        {
            const int AVATAR_FILM_ID = 19995;
            const string AVATAR_FILM_TITRE = "Avatar";
            const string NO_FILTER = "";
            List<Genre> genres = new List<Genre>
            {
                new Genre(28, "Action"),
                new Genre(12, "Adventure"),
                new Genre(14, "Fantasy"),
                new Genre(878, "Science Fiction"),
            };


            Film avatar = new Film(AVATAR_FILM_ID, AVATAR_FILM_TITRE, genres);

            List<Film> filmsCherches = RecupFilms.RecupRechercheFilmParNom(AVATAR_FILM_TITRE, NO_FILTER);

            Assert.AreEqual(filmsCherches[0].IdFilm, avatar.IdFilm);
        }
    }
}