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

    }
}
