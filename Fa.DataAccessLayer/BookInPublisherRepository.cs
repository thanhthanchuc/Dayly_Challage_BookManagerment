using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fa.DataAccessLayer
{
    public class BookInPublisherRepository : IBookInPublisherRepository
    {
        private BookManagermentContext _context;

        public BookInPublisherRepository()
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

        public void Delete(int bookInPublisherId)
        {
            _context.BookInPublishers.Remove(_context.BookInPublishers.SingleOrDefault(c => c.Id == bookInPublisherId) ?? throw new InvalidOperationException());
        }

        public IEnumerable<BookInPublisher> GetBookInPublishers()
        {
            return _context.BookInPublishers.ToList();
        }

        public BookInPublisher GetBookInPublisher(int bookInPublisherId)
        {
            return _context.BookInPublishers.SingleOrDefault(c => c.Id == bookInPublisherId);
        }

        public void Insert(BookInPublisher bookInPublisher)
        {
            _context.BookInPublishers.Add(bookInPublisher);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(BookInPublisher bookInPublisher)
        {
            _context.Entry(bookInPublisher).State = EntityState.Modified;
        }
    }
}