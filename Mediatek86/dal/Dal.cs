using System.Collections.Generic;
using Mediatek86.bddmanager;
using Mediatek86.Modele;
using MySql.Data.MySqlClient;

namespace Mediatek86.dal
{
    public class Dal
    {
        public static List<Personnel> GetAllPersonnel()
        {
            List<Personnel> personnels = new List<Personnel>();
            string query = "SELECT idpersonnel, nom, prenom, idservice FROM personnel;";
            MySqlCommand cmd = new MySqlCommand(query, BddManager.GetConnexion());

            try
            {
                BddManager.GetConnexion().Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    personnels.Add(new Personnel(
                        reader.GetInt32("idpersonnel"),
                        reader.GetString("nom"),
                        reader.GetString("prenom"),
                        reader.GetInt32("idservice")
                    ));
                }
                reader.Close();
            }
            finally
            {
                BddManager.GetConnexion().Close();
            }

            return personnels;
        }
    }
}
