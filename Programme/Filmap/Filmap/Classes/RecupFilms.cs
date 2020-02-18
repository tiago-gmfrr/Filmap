using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Filmap.Classes
{
    class RecupFilms
    {
        /// <summary>
        /// Récupére le nom de tous les films
        /// </summary>
        /// <returns>List de films</returns>
        public List<string> RecupererFilms()
        {
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                //Remplacer le numéro de list/xxx pour avoir d'autres films

                var data = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/day?api_key=219c3d7d9df2bb83f83cf2582b13a20d");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                List<string> titres = new List<string>();

                foreach (var  item in d["results"])
                {
                    titres.Add(item["title"]);
                }
                return titres;
            }
        }

        /// <summary>
        /// Récupére l'id du film
        /// </summary>
        /// <param name="nomFilm">Nom du film</param>
        /// <returns>id</returns>
        public int RecupIdFilm(string nomFilm)
        {
            int id = 0;
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {

                var data = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/day?api_key=219c3d7d9df2bb83f83cf2582b13a20d");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);
                //Parcoure tous 
                foreach (var item in d["results"])
                {
                    if (nomFilm == item["title"])
                    {
                        id = item["id"];
                    }
                }
            }

            return id;
        }

        /// <summary>
        /// Récupére toutes les infos du film
        /// </summary>
        /// <param name="idFilm">idFilm</param>
        /// <returns>Dictionnaire string, object</returns>
        public Dictionary<string, object> InfosFilmPrecis(int idFilm)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                //Remplacer le numéro de list/xxx pour avoir d'autres films
                
                var data = webClient.DownloadString("https://api.themoviedb.org/3/movie/" + idFilm + "?api_key=219c3d7d9df2bb83f83cf2582b13a20d&language=en-US");

                // frmDetailFilm frm = JsonConvert.DeserializeObject<frmDetailFilm>(data);
                JavaScriptSerializer jss = new JavaScriptSerializer();

                d = jss.Deserialize<dynamic>(data);

                
            }
            return d;
            
        }
        /// <summary>
        /// Récupére le directeur du film
        /// </summary>
        /// <param name="idFilm">Id du film</param>
        /// <returns>Nom directeur</returns>
        public string RecupDirecteur(int idFilm)
        {
            string directeur = "";
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                var data = webClient.DownloadString("https://api.themoviedb.org/3/movie/" + idFilm + "/credits?api_key=219c3d7d9df2bb83f83cf2582b13a20d&language=en-US");

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
        

    }
}
