using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

//original

namespace PizzaBox.Domain.Models
{
  public class Store : AModel
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
  }
}
