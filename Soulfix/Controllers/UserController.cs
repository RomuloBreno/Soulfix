using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Soulfix.Models;
using Soulfix.Repository.Client;
using Soulfix.Repository.User;
using Soulfix.Controllers.Message;

namespace Soulfix.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;
        private IMessage _msg;
        public UserController(IUserRepository userRepository, IMessage message)
        {
            _userRepository = userRepository;
            _msg = message;
    }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Index()
        {
            List<UserModel> User = _userRepository.GetList();
            return View(User);
        }
        

        [HttpPost]
        public IActionResult Create(UserModel userModel)
        {
                int statusMessage; //succes
            if (ModelState.IsValid)
            {
             _userRepository.Create(userModel);
                 statusMessage = 0; //succes
                TempData["msg"] = _msg.CreateMessage("Usuário", statusMessage);
                TempData["Status"] = statusMessage;
                return RedirectToAction("index");

            }
            statusMessage = 1;
            TempData["msg"] = _msg.CreateMessage("Usuário", statusMessage);
            TempData["Status"] = statusMessage;
            return View("Create", userModel);
        }



        [HttpGet]
        public IActionResult GetForUpdate(int id)
        {
            UserModel User = _userRepository.GetForUpdate(id);
            return View("Update", User);
        }


        [HttpPost]
        public IActionResult Update(UserModel user)
        {
            _userRepository.Update(user);
            return RedirectToAction("index");
        }








        public IActionResult ConfirmDelete(int id)
        {
            UserModel user = _userRepository.GetForUpdate(id);
            return View(user);
          
        }



        [HttpPost]
        public IActionResult DeleteUser(UserModel user)
        {
            UserModel userDelete = _userRepository.GetForUpdate(user.Id);
            _userRepository.Delete(userDelete);
            return RedirectToAction("Index");
        }
    }
}
