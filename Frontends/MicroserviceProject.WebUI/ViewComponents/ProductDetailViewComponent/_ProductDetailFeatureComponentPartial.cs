﻿using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.ViewComponents.ProductDetailViewComponent
{
    public class _ProductDetailFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
