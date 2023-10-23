using Microsoft.AspNetCore.Mvc;
using Soulfix.Repository.Login;
using Soulfix.Controllers.Message;
using Soulfix.Models;

namespace Soulfix.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginRepository _loginRepository;
        private IMessage _msg;
        public LoginController(ILoginRepository loginRepository, IMessage message)
        {
            _loginRepository = loginRepository;
            _msg = message;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Start(LoginModel loginInitial)
        {
            if (ModelState.IsValid)
            {
                LoginModel credentials = _loginRepository.CheckLogin(loginInitial.Login);
                if (credentials != null)
                {
                    if (Checkcredentials(loginInitial.Pswrd))
                    {
                        //Valida tipo do login
                        return ReturnViewMethod(credentials);
                    }
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        private IActionResult ReturnViewMethod(LoginModel credentials)
        {
            int type = _loginRepository.CheckType(credentials);
            string controllerType = credentials.ValidType(type);
       TempData["layouTypeLogin"] = controllerType;
        return RedirectToAction("Index", "Calendar");
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public bool Checkcredentials(string pswrd)
        {
            return _loginRepository.CheckPswrd(pswrd);

        }

        //[HttpPost]
        //public IActionResult Create(LoginModel loginModel)
        //{

        //}



        //[HttpGet]
        //public IActionResult GetForUpdate(int id)
        //{

        //}


        //[HttpPost]
        //public IActionResult Update(LoginModel login)
        //{

        //}








        //public IActionResult ConfirmDelete(int id)
        //{
           
          
        //}



        //[HttpPost]
        //public IActionResult DeleteLogin(LoginModel login)
        //{
         
        //}
    }
}
