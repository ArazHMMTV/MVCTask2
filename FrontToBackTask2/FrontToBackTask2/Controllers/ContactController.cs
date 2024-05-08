using Microsoft.AspNetCore.Mvc;

namespace FrontToBackTask2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
