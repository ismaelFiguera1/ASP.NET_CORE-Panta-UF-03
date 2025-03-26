using Base_Dades.Models;

namespace Base_Dades.Repository
{
    public interface ICityRepository
    {
        List<Ciutat> ObtenirCiutats();
        List<Ciutat> Trobat();
    }
}