using Microsoft.AspNetCore.Mvc;

namespace SistemaRes.APPWeb.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
