using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailImageSliderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
