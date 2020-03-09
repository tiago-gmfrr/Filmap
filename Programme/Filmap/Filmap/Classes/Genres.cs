using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Classes
{
    public class Genres
    {
        private int _idGenre;
        private string _nomGenre;

        public int IdGenre { get => _idGenre; set => _idGenre = value; }
        public string NomGenre { get => _nomGenre; set => _nomGenre = value; }

        public Genres(int idGenre, string titre)
        {
            _idGenre = idGenre;
            _nomGenre = titre;
        }
    }
}
