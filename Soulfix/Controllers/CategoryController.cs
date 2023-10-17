using Microsoft.AspNetCore.Mvc;
using Soulfix.Models;
using Soulfix.Repository.Category;

namespace Soulfix.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;   
        }

        public IActionResult Index()
        {
            List<CategoryModel> category = _categoryRepository.GetList();
            return View(category);
        }
    }
}
