using Microsoft.EntityFrameworkCore;

namespace pizzaClient.Models
{
    public class PizzaContext : DbContext
    {
        public PizzaContext() : base()
        {

        }
        public PizzaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Crust> Crust { get; set; }
        public DbSet<Toppings> Toppings { get; set; }
    }
}
