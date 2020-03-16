using Microsoft.VisualStudio.TestTools.UnitTesting;
using Filmap.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Classes.Tests
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
            Dictionary<int, string> films = Classes.RecupFilms.RecupererFilmsTendance();
            List<string> listFilms = new List<string>();
            foreach (KeyValuePair<int,string> item in films)
            {
                listFilms.Add(item.Value);
            }
            CollectionAssert.Contains(listFilms, FILM_A_TESTER);            
        }

        [TestMethod()]
        public void RecupIdFilmTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InfosFilmPrecisTest()
        {
            //RecupFilms recupFilms = new RecupFilms();
        }

        [TestMethod()]
        public void RecupDirecteurTest()
        {
            //RecupFilms recupFilms = new RecupFilms();
            //avatar ID = 19995
            string director = Classes.RecupFilms.RecupDirecteur(19995);
            //Avatar director = James Cameron
            Assert.AreEqual("James Cameron", director);
            
        }

        [TestMethod()]
        public void RecupRechercheFilmParNomTest()
        {
            Assert.Fail();
        }
    }
}