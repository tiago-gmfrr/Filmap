/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Objet utilisateur
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Models
{
    public class Utilisateur
    {
        private string _pseudo = "";
        private string _email = "";
        private List<Film> _filmAvoir = new List<Film>();
        private List<Film> _filmPrefere = new List<Film>();

        public string Pseudo { get => _pseudo; set => _pseudo = value; }
        public string Email { get => _email; set => _email = value; }
        public List<Film> FilmAvoir { get => _filmAvoir; set => _filmAvoir = value; }
        public List<Film> FilmPrefere { get => _filmPrefere; set => _filmPrefere = value; }
        public Utilisateur()
        {

        }
        public Utilisateur(string pseudo, string email)
        {
            _pseudo = pseudo;
            _email = email;
        }
        public void ajouterFilmDansFilmPrefere(Film film)
        {
            FilmPrefere.Add(film);
        }
        public void ajouterDansFilmAvoir(Film film)
        {
            
            FilmAvoir.Add(film);
        }
    }
}
