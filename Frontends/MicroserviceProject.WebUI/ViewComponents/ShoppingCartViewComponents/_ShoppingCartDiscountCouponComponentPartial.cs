using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.ViewComponents.ShoppingCartViewComponents
{
    public class _ShoppingCartDiscountCouponComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
