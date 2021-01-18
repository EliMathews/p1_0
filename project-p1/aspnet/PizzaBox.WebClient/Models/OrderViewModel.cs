using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.WebClient.Models
{
  public class OrderViewModel
  {
    public List<string> Customers { get; set; }

    [Required]
    public string Customer { get; set; }

    public List<string> Pizzas { get; set; }

    [Required]
    public string Pizza { get; set; }

    public List<string> Stores { get; set; }

    [Required]
    public string Store { get; set; }
  }
}
