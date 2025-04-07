using Cistell_de_la_compra.Models;

namespace Cistell_de_la_compra.Repository.interfaces
{
    public interface IUsuarisRepository
    {
        bool comprovarCorreu(string email);
        void controlIntents(bool correuCorrecte, string correu);
        void esborrarIntents(UsuariLogin user);
        Dictionary<string, int> obtenirNumeroIntents();
        List<UsuariLogin> ObtenirTotsUsuaris();
        (UsuariLogin, string) trobar(string email, string password);
    }
}