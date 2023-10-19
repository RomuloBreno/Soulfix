using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Soulfix.Models;
using Soulfix.Repository.Client;
using Soulfix.Repository.User;

namespace Soulfix.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult FormCreateUser()
        {
            return View();
        }
        public IActionResult FormUpdateUser()
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
            if (ModelState.IsValid)
            {
             _userRepository.Create(userModel);

                return RedirectToAction("index");

            }
            return View("FormCreateUser", userModel);
        }



        [HttpGet]
        public IActionResult GetForUpdate(int id)
        {
            UserModel User = _userRepository.GetForUpdate(id);
            return View("FormUpdateUser", User);
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
