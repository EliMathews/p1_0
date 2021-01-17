using System;
using PizzaBox.Domain.Abstracts;

//original

namespace PizzaBox.Domain.Models
{
  public class Order : AModel
  {
    public long OrderEntityId { get; set; }
    public Customer Customer { get; set; }
    public long CustomerEntityId { get; set; }
    public Pizza Pizza { get; set; }
    public Store Store { get; set; }
    public long StoreEntityId { get; set; }
    public DateTime DateModified { get; set; }
  }
}
