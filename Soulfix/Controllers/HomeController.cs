using Microsoft.AspNetCore.Mvc;
using Soulfix.Controllers.Message;
using Soulfix.Models;
using Soulfix.Repository.Login;
using System.Diagnostics;

namespace Soulfix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoginRepository _loginRepository;
        private IMessage _msg;
        public HomeController(ILoginRepository loginRepository, IMessage message)
        {
            _loginRepository = loginRepository;
            _msg = message;
        }

        public IActionResult Index(LoginModel credential)
        {
            return View();
             //return ReturnViewMethod(credential);
        }
        private IActionResult ReturnViewMethod(LoginModel credentials)
        {
            int type = _loginRepository.CheckType(credentials);
            string controllerType = credentials.ValidType(type);
            TempData["layouTypeLogin"] = controllerType;
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }
    




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}