using Microsoft.AspNetCore.Mvc;

namespace Soulfix.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
