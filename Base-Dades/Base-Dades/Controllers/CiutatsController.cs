using Base_Dades.Models;
using Base_Dades.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cistell_de_la_compra.Controllers
{
    public class CiutatsController : Controller
    {
        private ICityRepository _cityRepository;

        public CiutatsController(ICityRepository pr)
        {
            this._cityRepository = pr;
        }

        public IActionResult Index()
        {
            var llistaCiutats = _cityRepository.ObtenirCiutats();
            return View(llistaCiutats);
        }

        public IActionResult DeleteCiutat(int idCiutatBuscar)
        {
            _cityRepository.DeleteCiutat(idCiutatBuscar);
            var llistaCiutats = _cityRepository.ObtenirCiutats();
            TempData["Missatge"] = "✅ La ciutat amb id "+ idCiutatBuscar + " s'ha eliminat correctament";
            return View("Index",llistaCiutats);
        }

        public IActionResult UpdateCiutat( int idCiutatBuscar)
        {
                var ciutat = _cityRepository.BuscarCiutat(idCiutatBuscar);
                return View("Editar", ciutat);
        }


        public IActionResult UpdateCiutatFINAL(Ciutat ciutat)
        {
            _cityRepository.Update(ciutat);

            var ciutat1 = _cityRepository.BuscarCiutat(ciutat.id);

            TempData["Missatge"] = "✅ La ciutat s'ha actualitzat correctament";

            return View("Editar", ciutat1);
        }
    }
}
