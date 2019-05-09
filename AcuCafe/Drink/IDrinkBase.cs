using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Drink
{
  public interface IDrinkBase
  {
    decimal SubTotal();
    string CheckInvalidTopping(List<Topping.ToppingBase> toppings);
  }
}
