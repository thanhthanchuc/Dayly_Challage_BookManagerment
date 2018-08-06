using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fa.DataAccessLayer
{
    public class OrderRepository : IOrder
    {
        private BookManagermentContext _context;

        public OrderRepository()
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
        public void Delete(int orderId)
        {
            _context.Orders.Remove(_context.Orders.SingleOrDefault(c => c.Id == orderId) ?? throw new InvalidOperationException());
        }

        
        public Order GetOrder(int orderId)
        {
            return _context.Orders.SingleOrDefault(c => c.Id == orderId);
        }

        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }

        public void Insert(Order order)
        {
            _context.Orders.Add(order);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
        }
    }
}