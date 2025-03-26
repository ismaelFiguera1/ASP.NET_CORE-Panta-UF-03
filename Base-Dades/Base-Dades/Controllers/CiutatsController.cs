using Base_Dades.Models;
using Base_Dades.Repository;
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

        public IActionResult Accions(string action)
        {
            var llistaCiutats = new List<Ciutat>();

            llistaCiutats = _cityRepository.Trobat();


            return View();
        }
    }
}
