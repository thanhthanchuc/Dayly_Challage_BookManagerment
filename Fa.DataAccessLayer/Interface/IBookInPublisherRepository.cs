using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.Interface
{
    public interface IBookInPublisherRepository : IDisposable
    {
        IEnumerable<BookInPublisher> GetBookInPublishers();
        BookInPublisher GetCategoryId(int bookInPublisherId);
        void Insert(BookInPublisher bookInPublisher);
        void Update(BookInPublisher bookInPublisher);
        void Delete(int bookInPublisherId);
        void Save();
    }
}
