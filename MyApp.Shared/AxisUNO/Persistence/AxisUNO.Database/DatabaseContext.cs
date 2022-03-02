using MyApp.Domain.ProductGroups;
using MyApp.Domain.Products;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace  MyApp.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
        : base()
    {
    }

    public DatabaseContext(DbContextOptions options)
        : base(options)
    {
    }

    internal DbSet<Product> Products => Set<Product>();

    internal DbSet<ProductGroup> ProductGroups => Set<ProductGroup>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured == false)
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder()
            {
                DataSource = "Database.db",
            };

            optionsBuilder.UseSqlite(connectionStringBuilder.ToString());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
    }
}