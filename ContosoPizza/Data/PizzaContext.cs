using Microsoft.EntityFrameworkCore.Sqlite;
using ContosoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Data;

public class PizzaContext : DbContext
{
    public PizzaContext (DbContextOptions<PizzaContext> options) : base (options)
    {

    }

    public DbSet<Pizza> Pizzas => Set<Pizza>();
    public DbSet<Sauce> Sauces => Set<Sauce>();
    public DbSet<Topping> Toppings => Set<Topping> ();

}