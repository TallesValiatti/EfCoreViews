using EfCoreViews.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreViews;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=localhost;Database=MyDb;User Id=Sa;Password=Teste12345!;TrustServerCertificate=true");
    }
    
     public DbSet<Book> Books { get; set; } = null!;
     public DbSet<Author> Authors { get; set; } = null!;
     public DbSet<AuthorBookCount> AuthorBookCount { get; set; } = null!;
    

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}