using System;
using System.Collections.Generic;
using System.Text;

using MySql.Data.MySqlClient;

namespace GestionMySQL.Services
{
    public class ConnexionMySQL
    {
        private static MySqlConnection connexion;

        public bool Connecter(string serveur,
                              string port,
                              string utilisateur,
                              string motDePasse)
        {
            try
            {
                string chaineConnexion =
                    $"Server={serveur};" +
                    $"Port={port};" +
                    $"Uid={utilisateur};" +
                    $"Pwd={motDePasse};";

                connexion = new MySqlConnection(chaineConnexion);

                connexion.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static MySqlConnection GetConnexion()
        {
            return connexion;
        }
    }
}

