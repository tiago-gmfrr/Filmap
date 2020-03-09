using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Classes
{
    class Film
    {
        private int _idFilm;
        private string _titre;
        private string _synopsis;
        private int _note;
        private long _budget;
        private long _revenus;
        private string _langueOriginale;
        private List<string> _genres;

        public int IdFilm { get => _idFilm; set => _idFilm = value; }
        public string Titre { get => _titre; set => _titre = value; }
        public string Synopsis { get => _synopsis; set => _synopsis = value; }
        public int Note { get => _note; set => _note = value; }
        public long Budget { get => _budget; set => _budget = value; }
        public long Revenus { get => _revenus; set => _revenus = value; }
        public string LangueOriginale { get => _langueOriginale; set => _langueOriginale = value; }
        public List<string> Genres { get => _genres; set => _genres = value; }


        public Film(int idFilm, string titre)
        {
            IdFilm = idFilm;
            Titre = titre;
        }

        public Film(int idFilm, string titre, string synopsis, int note, long budget, long revenus, string langueOriginale, List<string> genres)
        {
            IdFilm = idFilm;
            Titre = titre;
            Synopsis = synopsis;
            Note = note;
            Budget = budget;
            Revenus = revenus;
            LangueOriginale = langueOriginale;
            Genres = genres;

        }
    }
}
