﻿using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
