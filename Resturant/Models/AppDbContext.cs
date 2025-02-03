using Microsoft.EntityFrameworkCore;

namespace Resturant.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Delivery>Deliveries { get; set; }
        public DbSet<Item>Items { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderItem>OrderItems { get; set; }
        public DbSet<Table>Tables { get; set; }
        public DbSet<User>Users { get; set; }
    }
}
