using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult _UILayout()
        {
            return View();
        }
    }
}
