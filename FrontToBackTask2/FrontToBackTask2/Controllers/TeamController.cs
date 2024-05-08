using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
