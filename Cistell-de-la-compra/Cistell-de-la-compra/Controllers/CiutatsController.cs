using Cistell_de_la_compra.Repository.interfaces;
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

        public IActionResult Accions()
        {
            var llistaCiutats = _cityRepository.ObtenirCiutats();
            return View(llistaCiutats);
        }
    }
}
