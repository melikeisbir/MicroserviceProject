using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
