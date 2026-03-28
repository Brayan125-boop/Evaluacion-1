using Microsoft.AspNetCore.Mvc;
using Evaluacion1.Services;

namespace Evaluacion1.Controllers
{
    public class CampanasController : Controller
    {
        private readonly CampanaService _service;
        public CampanasController(CampanaService service) { _service = service; }

        public IActionResult Index()
        {
            var campanas = _service.ObtenerTodas();
            return View(campanas);
        }
    }
}