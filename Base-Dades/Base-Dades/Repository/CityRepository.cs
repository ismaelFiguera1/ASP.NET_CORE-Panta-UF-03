using Base_Dades.Models;
using MySql.Data.MySqlClient;
using Base_Dades.Data;
using Base_Dades.Repository.Interfaces;
using Mysqlx.Crud;

namespace Base_Dades.Repository
{
    public class CityRepository : ICityRepository
    {


        public List<Ciutat> ObtenirCiutats()
        {
            var llista = new List<Ciutat>();
            string comanda = "select * from city  LIMIT 100";

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

        public Ciutat BuscarCiutat(int idCiutat)
        {
            Ciutat ciutat = new Ciutat();

            string comanda = "SELECT * FROM `city` WHERE id = @idCity";

            var conn = DB.ObtenirConnexio();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@idCity", idCiutat);
            cmd.CommandText = comanda;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ciutat.id = reader.GetInt32("ID");
                ciutat.name = reader.GetString("Name");
                ciutat.countrycode = reader.GetString("CountryCode");
                ciutat.district = reader.GetString("District");
                ciutat.population = reader.GetInt32("Population");
            }
            conn.Close();


            return ciutat;
        }

        public void Update(Ciutat city)
        {
            string comanda = "UPDATE city SET Name=@nom,CountryCode='ESP',District=@districte,Population=@poblacio WHERE ID = @idcity";
            var conn = DB.ObtenirConnexio();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@nom", city.name);
            cmd.Parameters.AddWithValue("@districte", city.district);
            cmd.Parameters.AddWithValue("@poblacio", city.population);
            cmd.Parameters.AddWithValue("@idcity", city.id);
            cmd.CommandText = comanda;
            cmd.ExecuteNonQuery();


            conn.Close();
        }

        public void DeleteCiutat(int idCiutat)
        {

            

            string comanda = "DELETE FROM city WHERE ID = @idCity";
            var conn = DB.ObtenirConnexio();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@idCity", idCiutat);
            cmd.CommandText = comanda;
            cmd.ExecuteNonQuery();


            conn.Close();


        }
    }
}
