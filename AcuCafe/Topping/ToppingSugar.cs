using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
  public class ToppingSugar : ToppingBase
  {
    public override string Name => "Topping Sugar";
    public override string Description => "Topping Sugar Description";
    public override decimal UnitPrice => 0;

    public SugarTypeEnum SugarType { get; set; }

    public ToppingSugar()
    {
      Amount = 0;
      SugarType = SugarTypeEnum.None;
    }

  }

  public enum SugarTypeEnum
  {
    None,
    WhiteSugar,
    BrownSugar,
    OtherSugar
  }
}
