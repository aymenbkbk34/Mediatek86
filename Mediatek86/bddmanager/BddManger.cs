using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; 

namespace Mediatek86.bddmanager
{
    public class BddManager
    {
        private static MySqlConnection connexion;

        private static string connexionString = "server=localhost;user=mediatekuser;password=motdepasseUser;database=mediatek86;";

        public static MySqlConnection GetConnexion()
        {
            if (connexion == null)
            {
                connexion = new MySqlConnection(connexionString);
            }
            return connexion;
        }
    }
}
