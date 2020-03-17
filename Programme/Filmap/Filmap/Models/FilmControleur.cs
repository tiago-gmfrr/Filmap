/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Controleur du programme
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Models
{
    class FilmControleur
    {
        /// <summary>
        /// Creation d'un compte
        /// </summary>
        public static void CreationCompte()
        {
            string pseudo = "";
            string email = "";
            string mdp = "";

            frmCreationCompte signupForm = new frmCreationCompte();
            signupForm.ShowDialog();

            pseudo = signupForm.Pseudo;
            email = signupForm.Email;
            mdp = signupForm.MotDePasse;

            dbConnection.AjouterUser(pseudo, email, mdp);
        }

        /// <summary>
        /// Connection
        /// </summary>
        /// <param name="pseudo"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static string Connection(string pseudo, string mdp)
        {
            string erreur = string.Empty;
            if (pseudo == "" || mdp == "")
            {
                erreur = "Tous les champs ne sont pas remplis.";
            }
            else
            {
                if (!dbConnection.Connection(pseudo, mdp))
                {
                    erreur = "Le pseudo ou le mot de passe est erroné";
                }
            }

            return erreur;

        }

        public static void ModeInvite(frmAccueil fa)
        {
            frmMain frmMain = new frmMain(fa, "");

            frmMain.Show();
        }
        public static void ModeConnecte(frmAccueil fa, string pseudo)
        {
            
            frmMain frmMain = new frmMain(fa, pseudo);

            frmMain.Show();
        }

        public static void AfficherDetailsFilm(int idFilm)
        {
            Film f = RecupFilms.InfosFilmPrecis(idFilm);

            //Vérifie que le code s'est bien éxécuté et affiche la fenêtre de détails
            if (f != null)
            {
                frmDetailFilm frmDetailFilm = new frmDetailFilm(f.Titre, f.DateSortie, f.Directeur,
                                    f.Synopsis, f.ChiffreAffaire, f.Budget, f.LangueOriginale, f.NoteIMDB, f.Genres);
                frmDetailFilm.Show();
            }
        }

        public static List<Film> RechercheFilmParNom(string filmAChercher, string filtreGenre)
        {
            List<Film> filmsAAfficher = new List<Film>();
            if (filmAChercher != string.Empty)
            {
                filmsAAfficher = RecupFilms.RecupRechercheFilmParNom(filmAChercher, filtreGenre);
            }
            else
            {
                filmsAAfficher = RecupFilms.RecupererFilmsTendance(filtreGenre);
            }
            return filmsAAfficher;
        }

        public static List<Film> RecupererFilmsTendance(string filtreGenre)
        {
            return RecupFilms.RecupererFilmsTendance(filtreGenre);
        }
        public static List<Genre> RecupGenresFilms()
        {
            return RecupFilms.RecupGenreFilms();
        }

    }
}
