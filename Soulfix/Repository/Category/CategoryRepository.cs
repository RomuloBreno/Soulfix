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
        public CategoryModel GetForUpdate(int id)
        {
            return _baseContext.Category.FirstOrDefault(x => x.Id == id);

        }
        public CategoryModel Update(CategoryModel categoryParam)
        {

            CategoryModel _category = GetForUpdate(categoryParam.Id);

            _category.Name = categoryParam.Name;
            _category.Color = categoryParam.Color;
            _category.IdOwner = categoryParam.IdOwner;


            _baseContext.Category.Update(_category);
            _baseContext.SaveChanges();
            return _category;
        }

        public List<CategoryModel> GetList()
        {
            return _baseContext.Category.ToList();
        }
    }
}

