using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcuCafe.Topping;

namespace AcuCafe
{
  class Program
  {
    static void Main(string[] args)
    {
      var topping = new List<ToppingBase>();

      topping.Add(new ToppingMilk());
      topping.Add(new ToppingJuice());

      var result = AcuCafe.Order.OrderGenerator.OrderDrink("IceTea", 1, topping);
    }
  }
}
