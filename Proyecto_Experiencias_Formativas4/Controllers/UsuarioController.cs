using Microsoft.AspNetCore.Mvc;

namespace SistemaRes.APPWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
