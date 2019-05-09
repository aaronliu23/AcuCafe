using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
  public class ToppingJuice : ToppingBase
  {
    public override string Name => "Topping Juice";
    public override string Description => "Topping Juice description";
    public override decimal UnitPrice => 0.1m;

    public JuiceTypeEnum SugarType { get; set; }

    public ToppingJuice()
    {
      Amount = 0;
      SugarType = JuiceTypeEnum.None;
    }

  }

  public enum JuiceTypeEnum
  {
    None,
    AppleJuice,
    OrangeJuice,
    StrawberryJuice,
    MangoJuice
  }
}
