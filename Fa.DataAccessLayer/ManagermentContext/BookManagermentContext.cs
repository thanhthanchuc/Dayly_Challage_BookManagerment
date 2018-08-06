using Fa.Model.Model;
using System.Data.Entity;

namespace Fa.DataAccessLayer.ManagermentContext
{
    public class BookManagermentContext : DbContext
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
