using Base_Dades.Models;
using MySql.Data.MySqlClient;
using Base_Dades.Data;

namespace Base_Dades.Repository
{
    public class CityRepository : ICityRepository
    {


        public List<Ciutat> ObtenirCiutats()
        {
            var llista = new List<Ciutat>();
            string comanda = "select * from city";

            var conn = DB.ObtenirConnexio();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = comanda;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var ciutat = new Ciutat();
                ciutat.id = reader.GetInt32("ID");
                ciutat.name = reader.GetString("Name");
                ciutat.countrycode = reader.GetString("CountryCode");
                ciutat.district = reader.GetString("District");
                ciutat.population = reader.GetInt32("Population");
                llista.Add(ciutat);
            }
            conn.Close();

            return llista;
        }

        public List<Ciutat> Trobat()
        {

            var dades = "city";
            var llista = new List<Ciutat>();
            /*
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=user;database=world";
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select count(*) from @taula";
            cmd.Parameters.AddWithValue("@taula", dades);
            long num = (long)cmd.ExecuteScalar();
            conn.Close();
            */

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=user;database=world";
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from city";
            MySqlDataReader reader = cmd.ExecuteReader();
            //long num = (long)cmd.ExecuteScalar();
            while (reader.Read())
            {
                var ciutat = new Ciutat();

                ciutat.name = reader.GetString("Name");
                ciutat.countrycode = reader.GetString("CountryCode");
                llista.Add(ciutat);
            }
            conn.Close();
            return llista;
        }
    }
}
