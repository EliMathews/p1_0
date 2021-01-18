using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.WebClient.Models;

namespace PizzaBox.WebClient.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    private readonly PizzaBoxContext _ctx;
    public OrderController(PizzaBoxContext context)
    {
      _ctx = context;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Post(OrderViewModel model)
    {
      if (ModelState.IsValid)
      {
        var order = new Order()
        {
          DateModified = DateTime.Now,
          Customer = _ctx.Customers.FirstOrDefault(c => c.Name == model.Customer),
          Pizza = _ctx.Pizzas.FirstOrDefault(p => p.Name == model.Pizza),
          Store = _ctx.Stores.FirstOrDefault(s => s.Name == model.Store)
        };

        _ctx.Orders.Add(order);
        _ctx.SaveChanges();

        return View("OrderPlaced");
      }

      return View("home", model);
    }
  }
}
