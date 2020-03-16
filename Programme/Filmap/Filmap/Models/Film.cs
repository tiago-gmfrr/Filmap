using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Models
{
    public class Film
    {
        private int _idFilm;
        private string _titre;
        private string _synopsis;
        private string _noteIMDB;
        private string _budget;
        private string _chiffreAffaire;
        private string _langueOriginale;
        private List<string> _genres;
        private string _realisateur;
        private string _dateSortie;

        public int IdFilm { get => _idFilm; private set => _idFilm = value; }
        public string Titre { get => _titre; private set => _titre = value; }
        public string Synopsis { get => _synopsis; private set => _synopsis = value; }
        public string NoteIMDB { get => _noteIMDB; private set => _noteIMDB = value; }
        public string Budget { get => _budget; private set => _budget = value; }
        public string ChiffreAffaire { get => _chiffreAffaire; private set => _chiffreAffaire = value; }
        public string LangueOriginale { get => _langueOriginale; private set => _langueOriginale = value; }
        public List<string> Genres { get => _genres; private set => _genres = value; }
        public string Realisateur { get => _realisateur; set => _realisateur = value; }
        public string DateSortie { get => _dateSortie; set => _dateSortie = value; }

        public Film(int idFilm, string titre)
        {
            IdFilm = idFilm;
            Titre = titre;
        }

        public Film(int idFilm, string titre, string synopsis, string noteIMDB, string budget, string chiffreAffaire, string langueOriginale, List<string> genres, string realisateur, string dateSortie)
        {
            IdFilm = idFilm;
            Titre = titre;
            Synopsis = synopsis;
            NoteIMDB = noteIMDB;
            Budget = budget;
            ChiffreAffaire = chiffreAffaire;
            LangueOriginale = langueOriginale;
            Genres = genres;
            Realisateur = realisateur;
            DateSortie = dateSortie;
        }
    }
}
