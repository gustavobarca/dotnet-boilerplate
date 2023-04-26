using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database;

public class DatabaseContext : DbContext
{
    public DbSet<Basket> Baskets { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        optionsBuilder.UseNpgsql("Host=localhost;Database=dotnet_boilerplate;Username=gubarca;Password=123");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .OwnsOne(x => x.Email)
            .Property(x => x.Value)
            .HasColumnName("Email")
            .IsRequired(true);

        builder.Entity<Item>().Property(x => x.Id).ValueGeneratedNever();
        builder.Entity<Basket>().Property(x => x.Id).ValueGeneratedNever();
    }
}