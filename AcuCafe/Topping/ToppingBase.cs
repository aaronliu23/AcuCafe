using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcuCafe.Topping
{
  public abstract class ToppingBase:IToppingBase
  {
    public abstract string Name { get;}
    public abstract string Description { get;  }
    public abstract decimal UnitPrice { get; }
    public int Amount { get; set; }

    public decimal SubTotal()
    {
      return this.UnitPrice * this.Amount;
    }
  }
}
