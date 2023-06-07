using Microsoft.AspNetCore.Mvc;

namespace SistemaRes.APPWeb.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult NuevaVenta()
        {
            return View();
        }
        public IActionResult HistorialVenta() { 
            return View();
        }
    }
}
