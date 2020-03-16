using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Filmap.Models
{
    public class RecupFilms
    {

        const string API_KEY = "219c3d7d9df2bb83f83cf2582b13a20d";

        /// <summary>
        /// Récupére le nom de tous les films
        /// </summary>
        /// <returns>List de films</returns>
        public static List<Film> RecupererFilmsTendance()
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/day?api_key=" + API_KEY);

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                List<Film> filmsTendance = new List<Film>();

                foreach (var item in d["results"])
                {
                    filmsTendance.Add(new Film(item["id"], item["title"]));
                }
                return filmsTendance;
            }
        }


        /// <summary>
        /// Récupére toutes les infos du film
        /// </summary>
        /// <param name="idFilm">idFilm</param>
        /// <returns>Dictionnaire string, object</returns>
        public static Film InfosFilmPrecis(int idFilm)
        {
            Dictionary<string, object> donnees = new Dictionary<string, object>();
            Film film;


            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/movie/" + idFilm + "?api_key=" + API_KEY + "&language=en-US");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                donnees = jss.Deserialize<dynamic>(data);

                string titre = "";
                string dateSortie = "";
                string realisateur = "";
                string synopsis = "";
                string budget = "";
                string noteIMDB = "";
                string chiffreAffaire = "";
                string langueOriginal = "";
                List<string> genres = new List<string>();

                foreach (KeyValuePair<string, object> donnee in donnees)
                {
                    realisateur = RecupDirecteur(idFilm);

                    switch (donnee.Key)
                    {
                        case "release_date":
                            dateSortie = donnee.Value.ToString();
                            break;
                        case "title":
                            titre = donnee.Value.ToString();
                            break;
                        case "overview":
                            synopsis = donnee.Value.ToString();
                            break;
                        case "vote_average":
                            noteIMDB = donnee.Value.ToString();
                            break;
                        case "budget":
                            if (long.Parse(donnee.Value.ToString()) > 0)
                                budget = donnee.Value.ToString();
                            else
                                budget = "N/C";
                            break;
                        case "revenue":
                            if (long.Parse(donnee.Value.ToString()) > 0)
                                chiffreAffaire = donnee.Value.ToString();
                            else
                                chiffreAffaire = "N/C";
                            break;
                        case "original_language":
                            langueOriginal = donnee.Value.ToString();
                            langueOriginal = langueOriginal.ToUpper();
                            break;
                        case "genres":
                            foreach (Dictionary<string, object> infos in donnee.Value as object[])
                            {
                                genres.Add(infos["name"].ToString());
                            }
                            break;
                    }
                }

                film = new Film(idFilm, titre, synopsis, noteIMDB, budget, chiffreAffaire, langueOriginal, genres, realisateur, dateSortie);
            }

            return film;

        }

        /// <summary>
        /// Récupére le directeur du film
        /// </summary>
        /// <param name="idFilm">Id du film</param>
        /// <returns>Nom directeur</returns>
        public static string RecupDirecteur(int idFilm)
        {
            string directeur = "";
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/movie/" + idFilm + "/credits?api_key=" + API_KEY + "&language=en-US");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                foreach (var item in d["crew"])
                {
                    foreach (KeyValuePair<string, object> job in item)
                    {
                        if (job.Key == "job")
                        {
                            if (job.Value.ToString() == "Director")
                            {
                                directeur = item["name"];
                            }
                        }
                    }
                }
            }

            return directeur;
        }

        public static List<Genre> RecupGenreFilms()
        {
            List<Genre> listGenre = new List<Genre>();
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {

                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/genre/movie/list?api_key=" + API_KEY + "&language=en-US");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                foreach (var item in d["genres"])
                {

                    listGenre.Add(new Genre(item["id"], item["name"]));
                }


            }


            return listGenre;
        }
        public static List<Film> RecupRechercheFilmParNom(string nomFilm)
        {
            List<Film> filmsCherches = new List<Film>();
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {

                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=" + API_KEY + "&language=en-US&query=" + nomFilm + "&page=1&include_adult=false");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);



                foreach (var item in d["results"])
                {

                    filmsCherches.Add(new Film(item["id"], item["title"]));
                }
            }

            return filmsCherches;

        }

    }
}
