using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
  public class ToppingMilk : ToppingBase
  {
    public override string Name => "Topping Milk";
    public override string Description => "Topping Milk Description";
    public override decimal UnitPrice => 0;

    public MilkTypeEnum MilkType { get; set; }

    public ToppingMilk()
    {
      Amount = 0;
      MilkType = MilkTypeEnum.None;
    }

  }

  public enum MilkTypeEnum
  {
    None,
    SemiSkimmedMilk,
    SkimmedMilk,
    WholeMilk,
    SoyaMilk
  }
}
