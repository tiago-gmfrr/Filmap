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
        [TestMethod()]
        public void RecupererFilmsTendanceTest()
        {
            //à changer en fonction des films au box office
            // En 24/02/2020, film choisit : Parasite
            const string FILM_A_TESTER = "Parasite";

            //RecupFilms recupFilms = new RecupFilms();
            List<Film> films = Models.RecupFilms.RecupererFilmsTendance();
            List<string> listFilms = new List<string>();
            foreach (Film f in films)
            {
                listFilms.Add(f.Titre);
            }
            CollectionAssert.Contains(listFilms, FILM_A_TESTER);
        }

        [TestMethod()]
        public void InfosFilmPrecisTest()
        {
            const int AVATAR_FILM_ID = 19995;
            Film f = Models.RecupFilms.InfosFilmPrecis(AVATAR_FILM_ID);

            const string TITRE_AVATAR = "Avatar";
            const string DIRECTEUR_AVATAR = "James Cameron";
            const string NOTE_AVATAR = "Avatar";
            const string CHIFFRE_DAFFAIRES_AVATAR = "Avatar";
            const string BUDGET_AVATAR = "Avatar";
            const string DATE_SORTIE_AVATAR = "Avatar";
            const string LANGUE_ORIGINALE_AVATAR = "Avatar";
            List<Genre> GENRES_AVATAR = new List<Genre>();
            //GENRES_AVATAR.Add(new Genre)

            // Assert.AreEqual(,f.Titre)

        }

        [TestMethod()]
        public void RecupDirecteurTest()
        {

            const int AVATAR_FILM_ID = 19995;
            const string AVATAR_FILM_DIRECTEUR = "James Cameron";

            string directeur = Models.RecupFilms.RecupDirecteur(AVATAR_FILM_ID);
            Assert.AreEqual(AVATAR_FILM_DIRECTEUR, directeur);

        }

        [TestMethod()]
        public void RecupRechercheFilmParNomTest()
        {
            Assert.Fail();
        }
    }
}