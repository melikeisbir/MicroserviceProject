using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
