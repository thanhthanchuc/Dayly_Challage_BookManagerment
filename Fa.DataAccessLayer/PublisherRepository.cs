using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;

namespace Fa.DataAccessLayer
{
    public class PublisherRepository : IPublisher
    {
        private BookManagermentContext _context;

        public PublisherRepository()
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

        public IEnumerable<Publisher> GetPublishers()
        {
            return _context.Publishers.ToList();
        }

        public Publisher GetPublisher(int publisherId)
        {
            return _context.Publishers.SingleOrDefault(c => c.PublisherId == publisherId);
        }

        public void Insert(Publisher publisher)
        {
            _context.Publishers.Add(publisher);
        }

        public void Update(Publisher publisher)
        {
            _context.Entry(publisher).State = EntityState.Modified;
        }

        public void Delete(int publisherId)
        {
            _context.Publishers.Remove(_context.Publishers.SingleOrDefault(c => c.PublisherId == publisherId) ?? throw new InvalidOperationException());
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}