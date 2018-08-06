using Fa.Model.Model;
using System;
using System.Collections.Generic;

namespace Fa.DataAccessLayer.Interface
{
    public interface ICustomerRepository : IDisposable
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int customerId);
        void Insert(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
        void Save();
    }
}