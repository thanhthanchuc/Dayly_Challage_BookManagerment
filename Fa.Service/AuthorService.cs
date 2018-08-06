using Fa.DataAccessLayer.Interface;
using Fa.Model.Model;
using Fa.Service.Interface;
using System;
using System.Collections.Generic;

namespace Fa.Service
{
    public class CategoryService : ICategory
    {
        private ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public Category GetCategory(int categoryId)
        {
            return _categoryRepository.GetCategoryId(categoryId);
        }

        public void Insert(Category category)
        {
            _categoryRepository.Insert(category);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void Delete(int categoryId)
        {
            _categoryRepository.Delete(categoryId);
        }

        public void Save()
        {
            _categoryRepository.Save();
        }
    }
    public class AuthorService : IAuthor
    {
        private IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _authorRepository.GetAuthors();
        }

        public Author GetAuthor(int authorId)
        {
            throw new NotImplementedException();
        }

        public void Insert(Author author)
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }

        public void Delete(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
