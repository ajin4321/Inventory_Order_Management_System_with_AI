using Microsoft.EntityFrameworkCore;
using IOMS.Models;

namespace IOMS.Data {
    public class IomsDbContext : DbContext
    {
        public IomsDbContext(DbContextOptions<IomsDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<StockTransaction> Stocks { get; set; }
    }
}

