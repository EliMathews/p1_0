using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : AModel
  {
    public string Name { get; set; }
    public long PizzaEntityID { get; set; }
  }
}
