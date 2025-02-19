using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.ViewComponents.ProductListViewComponents
{
    public class _ProductListColorFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
