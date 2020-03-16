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
            //En 24/02/2020, film choisit : Parasite
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
            const int AVATAR_FILM_ID = 19995;
            const string AVATAR_FILM_TITRE = "Avatar";
            Film avatar = new Film(AVATAR_FILM_ID, AVATAR_FILM_TITRE);

            List<Film> filmsCherches = RecupFilms.RecupRechercheFilmParNom(AVATAR_FILM_TITRE);

            Assert.AreEqual(filmsCherches[0].IdFilm, avatar.IdFilm);
        }
    }
}