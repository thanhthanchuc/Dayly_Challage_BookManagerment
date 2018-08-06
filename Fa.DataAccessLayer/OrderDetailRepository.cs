using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fa.DataAccessLayer
{
    public class OrderDetailRepository : IOrderDetail
    {
        private BookManagermentContext _context;

        public OrderDetailRepository()
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


        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetail(int orderId)
        {
            return _context.OrderDetails.SingleOrDefault(c => c.Id == orderId);
        }

        public void Insert(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
        }

        public void Update(OrderDetail orderDetail)
        {
            _context.Entry(orderDetail).State = EntityState.Modified;
        }

        public void Delete(int orderDetailId)
        {
            _context.OrderDetails.Remove(_context.OrderDetails.SingleOrDefault(c => c.Id == orderDetailId) ?? throw new InvalidOperationException());
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}