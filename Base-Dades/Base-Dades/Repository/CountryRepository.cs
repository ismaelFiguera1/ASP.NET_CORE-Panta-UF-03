using Base_Dades.Data;
using Base_Dades.Models;
using Base_Dades.Repository.Interfaces;
using MySql.Data.MySqlClient;

namespace Base_Dades.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public List<Pais> obtenirPaisos()
        {
            var llista = new List<Pais>();

            string comanda = "select * from country  LIMIT 100";

            var conn = DB.ObtenirConnexio();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = comanda;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var pais = new Pais();
                pais.Code = reader.GetString("Code");
                pais.Name = reader.GetString("Name");
                pais.Continent = reader.GetString("Continent");
                pais.Region = reader.GetString("Region");
                pais.SurfaceArea = reader.GetDouble("SurfaceArea");
                if (reader.IsDBNull(reader.GetOrdinal("IndepYear")))
                {
                    pais.IndepYear = null;
                }
                else
                {
                    pais.IndepYear = reader.GetInt32("IndepYear");
                }
                    
                pais.Population = reader.GetInt32("Population");
                pais.Lifeexpectancy = reader.GetDouble("LifeExpectancy");
                pais.Gnp = reader.GetDouble("GNP");
                pais.GnpOld = reader.GetDouble("GNPOld");
                pais.Localname = reader.GetString("LocalName");
                pais.GovernmentForm = reader.GetString("GovernmentForm");
                pais.HeadofState = reader.GetString("HeadOfState");
                pais.Capital = reader.GetInt32("Capital");
                pais.Code2 = reader.GetString("Code2");

                llista.Add(pais);
            }
            conn.Close();




            return llista;
        }
    }
}
