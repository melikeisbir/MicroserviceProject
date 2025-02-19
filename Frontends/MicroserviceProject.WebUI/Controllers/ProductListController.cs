using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
