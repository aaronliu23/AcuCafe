using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcuCafe.Drink;
using AcuCafe.Topping;


namespace AcuCafe.Order
{
  public static class OrderGenerator
  {


    public static DrinkBase OrderDrink(string drink, int amount, List<ToppingBase> toppings)
    {

      DrinkBase result;

      //create drink object
      if (_drinkBasBuilders.Any(p => p.Key.ToLower() == drink.ToLower()))
      {
        var resultBuilder = _drinkBasBuilders[drink.ToLower()];
        result = resultBuilder();
        result.Amount = amount;
      }
      else
      {
        throw new Exception(string.Format(ExceptionMessage.ExceptionMessage.DrinkTypeNotExist, drink));
      }

      //valid the topping
      if (toppings != null)
      {
        if (toppings.Count > 0)
        {
          var invalidTopping = result.CheckInvalidTopping(toppings);

          if (!string.IsNullOrEmpty(invalidTopping))
          {
            throw new Exception(string.Format(ExceptionMessage.ExceptionMessage.ToppingNotAddToDrink, invalidTopping, drink));
          }
          else
          {
            //add topping
            result.Toppings.AddRange(toppings);
          }
        }
      }

      try
      {
        result.Total = result.SubTotal();
      }
      catch (Exception ex)
      {
        throw new Exception(string.Format(ExceptionMessage.ExceptionMessage.SystemError, ex.Message));
      }

      return result;

    }

    


    private static Dictionary<string, Func<DrinkBase>> _drinkBasBuilders = new Dictionary<string, Func<DrinkBase>>
        {
            { "expresso", () => new Expresso() },
            { "hottea", () => new HotTea()  },
            { "icetea", () => new IceTea()  },
        };
  }
}
