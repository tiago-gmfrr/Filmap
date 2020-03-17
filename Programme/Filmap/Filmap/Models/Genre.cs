/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Objet Genre
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Models
{
    public class Genre
    {
        private int _idGenre;
        private string _nameGenre;

        public int IdGenre { get => _idGenre; set => _idGenre = value; }
        public string NameGenre { get => _nameGenre; set => _nameGenre = value; }

        public Genre(int idGenre)
        {
            _idGenre = idGenre;
            
        }
        public Genre(string nameGenre)
        {
            _nameGenre = nameGenre;

        }
        public Genre(int idGenre, string nameGenre)
        {
            _idGenre = idGenre;
            _nameGenre = nameGenre;
        }
    }
}
