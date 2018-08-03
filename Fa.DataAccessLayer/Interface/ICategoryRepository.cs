using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.Interface
{
    public interface ICategoryRepository : IDisposable
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryId(int categoryId);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        void Save();
    }
}
