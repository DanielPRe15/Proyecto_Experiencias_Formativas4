using Microsoft.AspNetCore.Mvc;

namespace SistemaRes.APPWeb.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
