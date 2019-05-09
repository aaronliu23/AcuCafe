using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Drink
{
  public class Expresso : DrinkBase
  {
    public override string Name => "Hot Tea";
    public override string Description => "Hot Tea Description";
    public override decimal UnitPrice => 1m;
    public override string ToppingException => "";

    public Expresso()
    {
      Toppings = new List<Topping.ToppingBase>();
      Amount = 0;
    }


  }
}
