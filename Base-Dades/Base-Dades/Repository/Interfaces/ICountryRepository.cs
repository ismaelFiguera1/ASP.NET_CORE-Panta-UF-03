using Base_Dades.Models;

namespace Base_Dades.Repository.Interfaces
{
    public interface ICountryRepository
    {
        List<Pais> obtenirPaisos();
    }
}