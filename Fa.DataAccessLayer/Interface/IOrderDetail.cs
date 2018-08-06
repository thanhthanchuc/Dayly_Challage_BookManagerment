using Fa.Model.Model;
using System;
using System.Collections.Generic;

namespace Fa.DataAccessLayer.Interface
{
    public interface IOrderDetail : IDisposable
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetail(int orderId);
        void Insert(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int orderDetailId);
        void Save();
    }
}