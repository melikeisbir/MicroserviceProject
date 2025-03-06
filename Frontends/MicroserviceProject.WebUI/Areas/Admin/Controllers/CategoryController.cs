using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
