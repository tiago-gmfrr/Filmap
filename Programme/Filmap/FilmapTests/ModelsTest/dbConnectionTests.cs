/*
 * 
 * Auteurs     : Cruz Elian, Russo Christian, Carvalho Daniel, Gama Tiago
 * Date        : 17.03.2020
 * Version     : V1.0
 * Description : Tests de la classe dbConnection.cs
 * 
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SQLite;
using Filmap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmap.Models.Tests
{
    [TestClass()]
    public class dbConnectionTests
    {
        /// <summary>
        /// Vérifier l'insertion d'un utilisateur à la base de données
        /// </summary>
        [TestMethod()]
        public void AjouterUserTest()
        {
            string user = "Elian";
            string email = "elian.crz@eduge.ch";
            string pwd = "Super";
            dbConnection.AjouterUser(user, email, pwd);

            bool reussi = Models.dbConnection.Connection(user, pwd);

            Assert.AreEqual(true, reussi);


        }
        /// <summary>
        /// Vérifier la connection de l'utilisateur 
        /// </summary>
        [TestMethod()]
        public void ConnectionTest()
        {
            const string DEFAULT_USER = "Tiago";
            const string DEFAULT_PWD = "Super";
            bool reussi = Models.dbConnection.Connection(DEFAULT_USER, DEFAULT_PWD);

            Assert.AreEqual(true, reussi);

        }
    }
}