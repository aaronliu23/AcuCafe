using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.ExceptionMessage
{
 public class ExceptionMessage
  {
    public const string SystemError = "Sorry there are some system error {0}! Please try again later";
    public const string DrinkTypeNotExist = "Sorry we don't sell {0} at the moment!";
    public const string ToppingNotAddToDrink = "Sorry you can't add {0} to drink {1}!";
  }
}
