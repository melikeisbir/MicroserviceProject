﻿using Microsoft.AspNetCore.Mvc;

namespace MicroserviceProject.WebUI.ViewComponents.DefaultViewComponents
{
    public class _SpecialOfferComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
