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
        private string _nameGenre;

        public int IdGenre { get => _idGenre; set => _idGenre = value; }
        public string NameGenre { get => _nameGenre; set => _nameGenre = value; }

        public Genres(int idGenre, string nameGenre)
        {
            _idGenre = idGenre;
            _nameGenre = nameGenre;
        }
    }
}
