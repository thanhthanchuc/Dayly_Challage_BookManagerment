using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.Model.Model;

namespace Fa.DataAccessLayer.ManagermentContext
{
    class BookManagermentContext : DbContext
    {
        public BookManagermentContext():base("name=BookConnectionString")
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookInPublisher> BookInPublishers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
