using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Classes
{
    class FilmModel
    {        

        public static List<dynamic> CreationListDynamic(string filmAChercher)
        {
            Dictionary<int, string> filmsCherches = new Dictionary<int, string>();

            filmsCherches = Classes.RecupFilms.RecupRechercheFilmParNom(filmAChercher);

            List<dynamic> dynList = new List<dynamic>();

            foreach (KeyValuePair<int, string> film in filmsCherches)
            {
                dynList.Add(new { Id = film.Key, Name = film.Value });
            }

            return dynList;
        }

        
    }
}
