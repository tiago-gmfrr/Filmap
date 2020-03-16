using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Classes
{
    class FilmModel
    {


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

            Classes.dbConnection.AjouterUser(pseudo, email, mdp);
        }

        public static string Connection(string pseudo, string mdp)
        {
            string erreur = string.Empty;
            if (pseudo != "" && mdp != "")
            {
                erreur = "Tous les champs ne sont pas remplis.";
            }
            else
            {
                if (!Classes.dbConnection.Connection(pseudo, mdp))
                {
                    erreur = "Le pseudo ou le mot de passe est erroné";
                }
            }

            return erreur;

        }

        public static void ModeInvite(frmAccueil fa)
        {
            frmMain frmMain = new frmMain(fa);

            frmMain.Show();
        }

        public static void AfficherDetailsFilm(int idFilm)
        {
            Film f = Classes.RecupFilms.InfosFilmPrecis(idFilm);

            //Vérifie que le code s'est bien éxécuté et affiche la fenêtre de détails
            if (f != null)
            {
                frmDetailFilm frmDetailFilm = new frmDetailFilm(f.Titre, f.DateSortie, f.Realisateur,
                                    f.Synopsis, f.ChiffreAffaire, f.Budget, f.LangueOriginale, f.NoteIMDB, f.Genres);
                frmDetailFilm.Show();
            }
        }

        public static List<Film> RechercheFilmParNom(string filmAChercher)
        {

             return Classes.RecupFilms.RecupRechercheFilmParNom(filmAChercher);

        }

        public static List<Film> RecupererFilmsTendance()
        {
            return Classes.RecupFilms.RecupererFilmsTendance();
        }
        public static List<Genre> RecupGenresFilms()
        {
            return Classes.RecupFilms.RecupGenreFilms();
        }

    }
}
