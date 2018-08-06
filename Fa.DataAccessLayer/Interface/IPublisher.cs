using System;
using System.Collections.Generic;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.Interface
{
    public interface IPublisher : IDisposable
    {
        IEnumerable<Publisher> GetPublishers();
        Publisher GetPublisher(int publisherId);
        void Insert(Publisher publisher);
        void Update(Publisher publisher);
        void Delete(int publisherId);
        void Save();
    }
}