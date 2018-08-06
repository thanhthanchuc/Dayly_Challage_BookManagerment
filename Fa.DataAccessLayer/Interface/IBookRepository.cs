using Fa.Model.Model;
using System;
using System.Collections.Generic;

namespace Fa.DataAccessLayer.Interface
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(int bookId);
        void Insert(Book book);
        void Update(Book book);
        void Delete(int bookId);
        void Save();
    }
}