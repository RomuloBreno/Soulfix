using Microsoft.AspNetCore.Mvc;
using Soulfix.Controllers.Message;
using Soulfix.Models;
using Soulfix.Repository.Category;

namespace Soulfix.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryRepository _categoryRepository;
        private IMessage _msg;
        public CategoryController(ICategoryRepository categoryRepository, IMessage msg)
        {
            _categoryRepository = categoryRepository;   
            _msg = msg;
        }

        public IActionResult Index()
        {
            List<CategoryModel> category = _categoryRepository.GetList();
            return View(category);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryModel categoryModel)
        {
            //eventModel.Category.Id = eventModel._category;
            int statusMessage;
            if (ModelState.IsValid)
            {
                _categoryRepository.Create(categoryModel);
                statusMessage = 0; //succes
                TempData["msg"] = _msg.CreateMessage("Evento", statusMessage);
                TempData["Status"] = statusMessage;
                return RedirectToAction("index");

            }
            statusMessage = 1;
            TempData["msg"] = _msg.CreateMessage("Evento", statusMessage);
            TempData["Status"] = statusMessage;
            return View("Create", categoryModel);
        }


        [HttpPost]
        public IActionResult Update(CategoryModel Category)
        {
            int statusMessage;
            if (ModelState.IsValid)
            {
                _categoryRepository.Update(Category);
                statusMessage = 3; //succes
                TempData["msg"] = _msg.CreateMessage("Categoria", statusMessage);
                TempData["Status"] = statusMessage;
                return RedirectToAction("index");

            }
            statusMessage = 4;
            TempData["msg"] = _msg.CreateMessage("Categoria", statusMessage);
            TempData["Status"] = statusMessage;

            return RedirectToAction("index");
        }



    }
}
