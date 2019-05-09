using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
  public class ToppingChocolate : ToppingBase
  {
    public override string Name => "Topping Chocolate";
    public override string Description => "Topping Chocolate description";
    public override decimal UnitPrice => 0.2m;

    public ChocolateTypeEnum ChocolateType { get; set; }

    public ToppingChocolate()
    {
      Amount = 0;
      ChocolateType = ChocolateTypeEnum.None;
    }

  }

  public enum ChocolateTypeEnum
  {
    None,
    ChocolateFlake,
  }
}
