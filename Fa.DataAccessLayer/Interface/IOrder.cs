using System;
using System.Collections.Generic;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.Interface
{
    public interface IOrder : IDisposable
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int orderId);
        void Insert(Order order);
        void Update(Order order);
        void Delete(int orderId);
        void Save();
    }
}