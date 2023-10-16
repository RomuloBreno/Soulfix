using Microsoft.AspNetCore.Mvc;

namespace Soulfix.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
