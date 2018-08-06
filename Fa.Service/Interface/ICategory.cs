using Fa.Model.Model;
using System.Collections.Generic;

namespace Fa.Service.Interface
{
    public interface ICategory
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(int categoryId);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        void Save();
    }
}