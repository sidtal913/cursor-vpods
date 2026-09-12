using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Greeting> Greetings => Set<Greeting>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Greeting>(entity =>
        {
            entity.HasKey(g => g.Id);
            entity.Property(g => g.Message).HasMaxLength(256).IsRequired();
            entity.HasData(new Greeting
            {
                Id = 1,
                Message = "Hello from PostgreSQL"
            });
        });
    }
}
