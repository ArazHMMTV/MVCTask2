using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
