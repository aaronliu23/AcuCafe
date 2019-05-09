using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcuCafe.Drink;

namespace AcuCafe.Order
{
  public class Order
  {
    public string OrderId { get; set; }
    public string OrderComment { get; set; }
    public DateTime OrderCreateTime { get; set; }
    public int CustomerId { get; set; }
    public int TableNumber { get; set; }
    public bool isTakeAway { get; set; }

    public List<DrinkBase> Drinks { get; set; }

    public Order()
    {
      OrderCreateTime = DateTime.UtcNow;
      isTakeAway = false;
      Drinks = new List<DrinkBase>();
    }

    public decimal SubTotal()
    {
      return Drinks.Sum(p => p.SubTotal());
    }



  }
}
