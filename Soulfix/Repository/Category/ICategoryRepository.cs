using Soulfix.Models;

namespace Soulfix.Repository.Category
{
    public interface ICategoryRepository
    {

        CategoryModel Create(CategoryModel category);
        List<CategoryModel> GetList();
    }
}
