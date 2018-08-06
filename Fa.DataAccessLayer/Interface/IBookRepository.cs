using System;
using System.Collections.Generic;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.Interface
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int authorId);
        void Insert(Book book);
        void Update(Book book);
        void Delete(int bookId);
        void Save();
    }
}