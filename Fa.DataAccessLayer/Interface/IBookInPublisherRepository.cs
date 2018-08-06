using Fa.Model.Model;
using System;
using System.Collections.Generic;

namespace Fa.DataAccessLayer.Interface
{
    public interface IBookInPublisherRepository : IDisposable
    {
        IEnumerable<BookInPublisher> GetBookInPublishers();
        BookInPublisher GetBookInPublisher(int bookInPublisherId);
        void Insert(BookInPublisher bookInPublisher);
        void Update(BookInPublisher bookInPublisher);
        void Delete(int bookInPublisherId);
        void Save();
    }
}
