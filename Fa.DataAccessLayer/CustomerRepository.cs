using Fa.DataAccessLayer.Interface;
using Fa.DataAccessLayer.ManagermentContext;
using Fa.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Fa.DataAccessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private BookManagermentContext _context;

        public CustomerRepository()
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

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomer(int customerId)
        {
            return _context.Customers.SingleOrDefault(c => c.Id == customerId);
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
        }

        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
        }

        public void Delete(int customerId)
        {
            _context.Customers.Remove(_context.Customers.SingleOrDefault(c => c.Id == customerId) ?? throw new InvalidOperationException());
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}