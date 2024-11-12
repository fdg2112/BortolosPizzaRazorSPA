using Microsoft.EntityFrameworkCore;

namespace BartolosPizza.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options)
            : base(options)
        {
        }
        public DbSet<BartolosPizza.Models.Pizza>? Pizzas { get; set; }
    }
}
