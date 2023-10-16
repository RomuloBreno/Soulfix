using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            List<UserModel> User = _userRepository.GetList();
            return View(User);
        }
    }
}
