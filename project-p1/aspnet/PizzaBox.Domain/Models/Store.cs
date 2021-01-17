using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

//original

namespace PizzaBox.Domain.Models
{
  public class Store : AModel
  {
    public string Name { get; set; }
    public long StoreEntityId { get; set; }
  }
}
