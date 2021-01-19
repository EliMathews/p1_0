using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxRepository
  {
    private PizzaBoxContext _ctx;

    public PizzaBoxRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    public List<string> GetCustomers()
    {
      return _ctx.Customers.Select(c => c.Name).ToList();
    }

    public List<string> GetPizzas()
    {
      return _ctx.Pizzas.Select(p => p.Name).ToList();
    }

    public List<string> GetStores()
    {
      return _ctx.Stores.Select(s => s.Name).ToList();
    }


    /* public void SaveOrder()
    {
      _ctx.Orders.Add();
      _ctx.SaveChanges();

    } */

    // public IEnumerable<T> Get<T>() where T : AModel
    // {
    //   return _ctx.Set<T>().Select(t => t.GetType().GetProperty()).ToList();
    // }
  }
}
