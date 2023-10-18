using Soulfix.Data;
using Soulfix.Models;
using System.Linq;

namespace Soulfix.Repository.Category
{
    public class CategoryRepository : ICategoryRepository
    {


        private readonly BaseContext _baseContext;

        public CategoryRepository(BaseContext baseContext)
        {
            _baseContext = baseContext;
        }

        public CategoryModel Create(CategoryModel category)
        {
            _baseContext.Category.Add(category);
            _baseContext.SaveChanges();
            return category;
        }

        public List<CategoryModel> GetList()
        {
            return _baseContext.Category.ToList();
        }
    }
}

