﻿using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
