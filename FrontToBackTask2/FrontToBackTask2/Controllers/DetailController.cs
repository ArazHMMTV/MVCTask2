using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
