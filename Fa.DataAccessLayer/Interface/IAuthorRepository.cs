using System;
using System.Collections.Generic;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.Interface
{
    public interface IAuthorRepository : IDisposable
    {
        IEnumerable<Author> GetAuthors();
        Author GetAuthor(int authorId);
        void Insert(Author author);
        void Update(Author authorId);
        void Delete(int authorId);
        void Save();
    }
}