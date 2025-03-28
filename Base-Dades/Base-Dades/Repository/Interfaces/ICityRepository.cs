using Base_Dades.Models;

namespace Base_Dades.Repository.Interfaces
{
    public interface ICityRepository
    {
        Ciutat BuscarCiutat(int idCiutat);
        void DeleteCiutat(int idCiutat);
        List<Ciutat> ObtenirCiutats();
        void Update(Ciutat city);
    }
}