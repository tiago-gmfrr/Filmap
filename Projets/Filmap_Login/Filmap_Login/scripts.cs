using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Filmap_Login
{


    class Scripts
    {
        const string CHAINE_CONNEXION = "Data Source=bdFilmap.db;Version=3;";
        SQLiteConnection maConnexion = new SQLiteConnection(CHAINE_CONNEXION);

        public Scripts()
        {

        }

        public SQLiteConnection MaConnexion { get => maConnexion; set => maConnexion = value; }


        /// <summary>
        /// Ajoute un utilisateur à la BD
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pseudo"></param>
        /// <param name="mdp"></param>
        /// <param name="sel"></param>
        /// <returns></returns>
        public bool AjouterUtilisateur(string email, string pseudo, string mdp, string sel)
        {
            MaConnexion.Open();
            string sql = string.Format("INSERT INTO Utilisateurs(pseudo, mail, mdp, selmdp) VALUES('{0}','{1}','{2}','{3}')", pseudo, email, mdp, sel);
            SQLiteCommand command = new SQLiteCommand(sql, MaConnexion);
            int nbInsert = command.ExecuteNonQuery();
            if (nbInsert > 0)
            {
                maConnexion.Close();
                return true;
            }
            else
            {
                maConnexion.Close();
                return false;
            }
        }

        /// <summary>
        /// Obtient tous les utilisateurs dans une chaine de caractères au format "id,pseudo,mail,mdp,selMdp"
        /// Conseil: les séparer avec un spit et les récupérer dans un tableau de string
        /// </summary>
        /// <returns>Une chaine de données</returns>
        public string RecupererUtilisateurs()
        {
            MaConnexion.Open();
            string sql = "SELECT * FROM Utilisateurs;";
            SQLiteCommand command = new SQLiteCommand(sql, MaConnexion);
            SQLiteDataReader dtReader = command.ExecuteReader();


            string utilisateurs = string.Empty;
            while (dtReader.Read())
            {
                utilisateurs += string.Format("{0},{1},{2},{3},{4}", dtReader["id"], dtReader["pseudo"], dtReader["mail"], dtReader["mdp"], dtReader["selMdp"]);
                utilisateurs += Environment.NewLine;
            }
            maConnexion.Close();
            return utilisateurs;

        }

    }
}
