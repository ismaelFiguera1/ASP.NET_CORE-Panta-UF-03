using Cistell_de_la_compra.Data;
using Cistell_de_la_compra.Models;
using Cistell_de_la_compra.Repository.interfaces;

namespace Cistell_de_la_compra.Repository
{
    public class CityRepository : ICityRepository
    {


        public List<Ciutat> ObtenirCiutats()
        {
            return Ciutats.LlistaCiutats;
        }
    }
}
