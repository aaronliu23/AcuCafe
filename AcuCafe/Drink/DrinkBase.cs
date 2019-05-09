using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Drink
{
  public abstract class DrinkBase: IDrinkBase
  {
    public abstract string Name { get; }
    public abstract string Description { get; }
    public abstract decimal UnitPrice { get; }
    public abstract string ToppingException { get; }

    public int Amount { get; set; }

    public decimal Total { get; set; }

    public List<Topping.ToppingBase> Toppings { get; set; }

    public decimal SubTotal()
    {
      var drinkSubTotal = this.UnitPrice * this.Amount;
      var toppingSubTotal = Toppings.Sum(p => p.SubTotal());
      return drinkSubTotal + toppingSubTotal;
    }

    public string CheckInvalidTopping(List<Topping.ToppingBase> toppings)
    {
      return toppings.Where(p => ToppingException.ToLower().IndexOf(p.Name.ToLower()) != -1).FirstOrDefault().Name;
    }

  }
}
