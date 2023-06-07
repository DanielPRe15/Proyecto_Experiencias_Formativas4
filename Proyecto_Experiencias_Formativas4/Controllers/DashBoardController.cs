using Microsoft.AspNetCore.Mvc;

namespace SistemaRes.APPWeb.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
