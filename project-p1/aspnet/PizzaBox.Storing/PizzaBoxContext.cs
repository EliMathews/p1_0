using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Order> Orders { get; set; }
    public DbSet<Store> Stores { get; set; }

    public PizzaBoxContext(DbContextOptions<PizzaBoxContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Customer>().HasKey(c => c.EntityId);
      builder.Entity<Order>().HasKey(o => o.EntityId); //this statement tells efcore that the order table has pk entityid
      builder.Entity<Pizza>().HasKey(p => p.EntityId);
      builder.Entity<Store>().HasKey(s => s.EntityId);

      builder.Entity<Customer>().HasData(
        new Customer() { EntityId = 1, Name = "Bruce Wayne" },
        new Customer() { EntityId = 2, Name = "Prince" }
      );

      builder.Entity<Pizza>().HasData(
        new Pizza() { EntityId = 1, Name = "Cheese Pizza" },
        new Pizza() { EntityId = 2, Name = "Pepperoni Pizza" }
      );

      builder.Entity<Store>().HasData(
        new Store() { EntityId = 1, Name = "Now That's A Pie" },
        new Store() { EntityId = 2, Name = "The Pizza Reunion" }
      );


      // builder.Entity<Order>().HasOne(o => o.Store).WithMany(s => s.Orders);
      // builder.Entity<Store>().HasMany(s => s.Orders).WithOne(o => o.Store);
      // builder.Entity<Pizza>().HasMany<Topping>(p => p.Ingredients).WithMany(t => t.Pizzas);
    }
  }
}
