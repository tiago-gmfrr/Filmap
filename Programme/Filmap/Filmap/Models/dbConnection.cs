using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmap.Classes
{
    class dbConnection
    {
        //Chaine de connexion
        const string chaineConnexion = "Data Source = ../../bdFilmap.sqlite;Version=3";
        //Initialisation de la connexion
        static SQLiteConnection maConnexion = new SQLiteConnection(chaineConnexion);

        public static void AjouterUser(string pseudo, string email, string mdp)
        {


            SHA1 sha1Hash = SHA1.Create();
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[13]);
            string saltString = Convert.ToBase64String(salt);

            var mdpSalted = Encoding.ASCII.GetBytes(mdp + saltString);
            byte[] hashedMdp = sha1Hash.ComputeHash(mdpSalted);
            string hash = BitConverter.ToString(hashedMdp).Replace("-", String.Empty);


            string sql = string.Format("INSERT INTO Utilisateur (pseudo, mail, mdp, selMdp)" +
                   "VALUES ('{0}', '{1}', '{2}', '{3}');", pseudo, email, hash, saltString);
            //Affectation de la commande sqlite
            SQLiteCommand sqliteCom = new SQLiteCommand(sql, maConnexion);
            //Ouverture de la connexion
            maConnexion.Open();
            //On execute la commande
            sqliteCom.ExecuteNonQuery();
            //On ferme la connexion
            maConnexion.Close();

        }
        public static bool Connection(string pseudo, string mdp)
        {
            SHA1 sha1Hash = SHA1.Create();
            string truePseudo = "";
            string hashedMdp = "";
            string salt = "";
            bool reussi = false;

            

            string sql = string.Format("SELECT pseudo, mdp, selMdp FROM Utilisateur WHERE pseudo ='" + pseudo + "'");
            // Affectation de la commande sqlite
            SQLiteCommand sqliteCom = new SQLiteCommand(sql, maConnexion);
            //Ouverture de la connexion
            maConnexion.Open();
            //On affecte le sqliteReader
            SQLiteDataReader reader = sqliteCom.ExecuteReader();
            while (reader.Read())
            {
                truePseudo = reader["pseudo"].ToString();
                hashedMdp = reader["mdp"].ToString();
                salt = reader["selMdp"].ToString();

            }
            //Ferme le reader
            reader.Close();
            //Ferme la connexion
            maConnexion.Close();

            var mdpSalted = Encoding.ASCII.GetBytes(mdp + salt);
            byte[] userHashedMdp = sha1Hash.ComputeHash(mdpSalted);
            string hash = BitConverter.ToString(userHashedMdp).Replace("-", String.Empty);


           // Console.WriteLine(hash);

            if (pseudo == truePseudo && hash == hashedMdp)
            {                
                reussi = true;
            }

            return reussi;
        }
    }
}
