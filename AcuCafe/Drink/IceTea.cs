using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Drink
{
  public class IceTea : DrinkBase
  {
    public override string Name => "Hot Tea";
    public override string Description => "Hot Tea Description";
    public override decimal UnitPrice => 3m;
    public override string ToppingException => "Topping Milk";

    public IceTea()
    {
      Toppings = new List<Topping.ToppingBase>();
      Amount = 0;
    }


  }
}
