using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Drink
{
  public class HotTea : DrinkBase
  {
    public override string Name => "Hot Tea";
    public override string Description => "Hot Tea Description";
    public override decimal UnitPrice => 2m;
    public override string ToppingException => "";

    public HotTea()
    {
      Toppings = new List<Topping.ToppingBase>();
      Amount = 0;
    }


  }
}
