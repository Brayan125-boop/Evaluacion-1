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
            // MODIFICACIÓN para filtro (esto generará conflicto luego)
            ViewBag.Categorias = new List<string> { "Electro","Hogar","Moda","Tecnología" };
            ViewBag.Estados = new List<string> { "Vigente","Próxima","Finalizada" };
            var campanas = _service.Filtrar(categoria, estado);
            return View(campanas);
        }

        public IActionResult Detalle(int id)
        {
            var campana = _service.ObtenerPorId(id);
            if (campana == null) return NotFound();
            return View(campana);
        }
    }
}