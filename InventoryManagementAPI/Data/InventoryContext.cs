using Microsoft.EntityFrameworkCore;
using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<InventoryRecord> InventoryRecords { get; set; }

    }
}