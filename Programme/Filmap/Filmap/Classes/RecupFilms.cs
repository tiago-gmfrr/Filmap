using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Filmap.Classes
{
    class RecupFilms
    {

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

        public string RecupSynopsis(string nomFilm)
        {
            string synopsis = "";
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                //Remplacer le numéro de list/xxx pour avoir d'autres films

                var data = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/day?api_key=219c3d7d9df2bb83f83cf2582b13a20d");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

                foreach (var item in d["results"])
                {
                    if (nomFilm == item["title"])
                    {
                        synopsis = item["overview"];
                    }
                }
            }

            return synopsis;
        }

        public int RecupIdFilm(string nomFilm)
        {
            int id = 0;
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                //Remplacer le numéro de list/xxx pour avoir d'autres films

                var data = webClient.DownloadString("https://api.themoviedb.org/3/trending/movie/day?api_key=219c3d7d9df2bb83f83cf2582b13a20d");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                var d = jss.Deserialize<dynamic>(data);

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


        public Dictionary<string, object> InfosFilmPrecis(int idFilm)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            using (System.Net.WebClient webClient = new System.Net.WebClient())
            {
                //Remplacer le numéro de list/xxx pour avoir d'autres films

                var data = webClient.DownloadString("https://api.themoviedb.org/3/movie/" + idFilm + "?api_key=219c3d7d9df2bb83f83cf2582b13a20d&language=en-US");

                JavaScriptSerializer jss = new JavaScriptSerializer();

                d = jss.Deserialize<dynamic>(data);

                
            }
            return d;
            
        }

    }
}
