using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fa.DataAccessLayer
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookManagermentContext _context;

        public AuthorRepository()
        {
            _context = new BookManagermentContext();
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

        public IEnumerable<Author> GetAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int authorId)
        {
            return _context.Authors.SingleOrDefault(c => c.AuthorId == authorId);
        }

        public void Insert(Author author)
        {
            _context.Authors.Add(author);
        }

        public void Update(Author authorId)
        {
            _context.Entry(authorId).State = EntityState.Modified;
        }

        public void Delete(int authorId)
        {
            _context.Authors.Remove(_context.Authors.SingleOrDefault(c => c.AuthorId == authorId) ?? throw new InvalidOperationException());
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}