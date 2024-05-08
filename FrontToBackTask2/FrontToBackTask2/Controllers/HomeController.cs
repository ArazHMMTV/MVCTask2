using FrontToBackTask2.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
