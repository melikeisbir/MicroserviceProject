using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
