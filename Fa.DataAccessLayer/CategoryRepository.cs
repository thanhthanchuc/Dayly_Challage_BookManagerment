using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fa.DataAccessLayer
{
    public class CategoryRepository : ICategoryRepository
    {
        private BookManagermentContext _context;

        public CategoryRepository()
        {
            _context = new BookManagermentContext();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryId(int categoryId)
        {
            return _context.Categories.SingleOrDefault(c => c.CategoryId == categoryId);
        }

        public void Insert(Category category)
        {
            _context.Categories.Add(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
        }

        public void Delete(int categoryId)
        {
            var category = _context.Categories.SingleOrDefault(c => c.CategoryId == categoryId);
            if (category != null)
                _context.Categories.Remove(category);
        }

        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
