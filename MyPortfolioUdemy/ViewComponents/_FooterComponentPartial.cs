﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
