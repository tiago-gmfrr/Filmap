/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Requetes de l'API TheMovieDB
 * 
 */

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
        /// Récupére le nom de tous les films et filtre les résultats par un filtre de genre si nécéssaire
        /// </summary>
        /// <param name="filtreGenre">Genre à filtrer</param>
        /// <returns>Liste de films tendances</returns>
        public static List<Film> RecupererFilmsTendance(string filtreGenre)
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/day?api_key=" + API_KEY);

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                List<Film> filmsTendance = new List<Film>();
                List<Genre> genreFilm = new List<Genre>();

                List<Genre> tousLesGenres = RecupGenreFilms();
                int idGenre = 0;
                bool affiche = false;


                foreach (var genre in tousLesGenres)
                {
                    
                    if (genre.NameGenre == filtreGenre)
                    {

                        idGenre = genre.IdGenre;

                    }
                }

                foreach (var item in d["results"])
                {
                    //Récupére les genre du film
                    foreach (var genre in item["genre_ids"])
                    {
                        genreFilm.Add(new Genre(genre));

                        if (genre == idGenre)
                        {
                            affiche = true;
                        }
                    }
                   
                    if (affiche == true)
                    {
                        filmsTendance.Add(new Film(item["id"], item["title"], genreFilm));
                    }
                    else
                    {
                        if (filtreGenre == "Pas de filtre" || filtreGenre == "")
                        {
                            filmsTendance.Add(new Film(item["id"], item["title"], genreFilm));
                        }
                    }


                    genreFilm.Clear();
                    affiche = false;
                }
                return filmsTendance;
            }
        }


        /// <summary>
        /// Récupére toutes les infos du film
        /// </summary>
        /// <param name="idFilm">idFilm</param>
        /// <returns>Toutes les informations d'un film</returns>
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
                List<Genre> genres = new List<Genre>();

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
                                genres.Add(new Genre(infos["name"].ToString()));
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
        /// <returns>Nom du directeur</returns>
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

        /// <summary>
        /// Récupère tous les genres de film possibles
        /// </summary>
        /// <returns>Liste de genres</returns>
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
        /// <summary>
        /// Recherche des films avec des titres similaires à celui rentré par l'utilisateur + filtrés par le genre désiré
        /// </summary>
        /// <param name="nomFilm">Nom du film rentré par l'utilisateur</param>        
        /// <param name="filtreGenre">Genre à filtrer</param>
        /// <returns>Liste de films qui correspondent a la recherche de l'utilisateur</returns>
        public static List<Film> RecupRechercheFilmParNom(string nomFilm, string filtreGenre)
        {
            List<Film> filmsCherches = new List<Film>();
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {

                webClient.Encoding = Encoding.UTF8;
                var data = webClient.DownloadString("https://api.themoviedb.org/3/search/movie?api_key=" + API_KEY + "&language=en-US&query=" + nomFilm + "&page=1&include_adult=false");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                List<Genre> genreFilm = new List<Genre>();

                List<Genre> tousLesGenres = RecupGenreFilms();
                int idGenre = 0;
                bool affiche = false;


                foreach (var genre in tousLesGenres)
                {
                    
                    if (genre.NameGenre == filtreGenre)
                    {

                        idGenre = genre.IdGenre;
                        
                    }


                }

                foreach (var item in d["results"])
                {
                    //Récupére les genre du film
                    foreach (var genre in item["genre_ids"])
                    {
                        genreFilm.Add(new Genre(genre));

                        if (genre == idGenre)
                        {
                            affiche = true;


                        }

                    }

                    if (affiche == true)
                    {
                        filmsCherches.Add(new Film(item["id"], item["title"], genreFilm));
                    }
                    else
                    {
                        if (filtreGenre == "Pas de filtre" || filtreGenre == "")
                        {
                            filmsCherches.Add(new Film(item["id"], item["title"], genreFilm));
                        }
                    }


                    genreFilm.Clear();
                    affiche = false;
                }
            }

            return filmsCherches;

        }

    }
}
