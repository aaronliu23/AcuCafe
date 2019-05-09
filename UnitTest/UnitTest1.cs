using System;
using System.Collections.Generic;
using NUnit.Framework;

using AcuCafe.Topping;
using AcuCafe.ExceptionMessage;

namespace UnitTest
{
  [TestFixture]
  public class UnitTest1
  {
    [TestCase("Expresso", 2, null, 12)]
    [TestCase("Expresso", 2, null, 2)]
    [TestCase("HotTea", 2, null, 12)]
    [TestCase("HotTea", 2, null, 4)]
    [TestCase("IceTea", 2, null, 12)]
    [TestCase("IceTea", 2, null, 6)]
    public void TestDrinkWithoutToppingTotal(string drink, int amount, List<ToppingBase> toppings, decimal total)
    {
      var result = AcuCafe.Order.OrderGenerator.OrderDrink(drink, amount, toppings);
      Assert.AreEqual(total, result.SubTotal());
    }


    [TestCase("Expresso", 2, null, 12)]
    [TestCase("Expresso", 2, null, 2)]
    [TestCase("HotTea", 2, null, 12)]
    [TestCase("HotTea", 2, null, 4)]
    [TestCase("IceTea", 2, null, 12)]
    [TestCase("IceTea", 2, null, 6)]
    public void TestDrinkWithToppingTotal(string drink, int amount, List<ToppingBase> toppings, decimal total)
    {
      toppings = new List<ToppingBase>();
      var sugar = new ToppingSugar();
      sugar.SugarType = SugarTypeEnum.WhiteSugar;
      sugar.Amount = 2;
      toppings.Add(sugar);

      var chocolate = new ToppingChocolate();
      chocolate.ChocolateType = ChocolateTypeEnum.ChocolateFlake;
      sugar.Amount = 3;
      toppings.Add(chocolate);

      var result = AcuCafe.Order.OrderGenerator.OrderDrink(drink, amount, toppings);
      Assert.AreEqual(total, result.SubTotal());
    }


    [TestCase("IceTea", 1, null, 0)]
    public void TestInvalidToppingOnDrink(string drink, int amount, List<ToppingBase> toppings, decimal total)
    {
      toppings.Add(new ToppingSugar());
      toppings.Add(new ToppingMilk());
      TestDelegate orderDrink = () => AcuCafe.Order.OrderGenerator.OrderDrink(drink, 1, null);
      var exception = Assert.Catch<Exception>(orderDrink);
      var expectedMessage = string.Format(ExceptionMessage.ToppingNotAddToDrink, drink);
      Assert.AreEqual(expectedMessage, exception.Message);
    }


    [TestCase("beer", 1, null, 0)]
    public void TestInCorrectDrink(string drink, int amount, List<ToppingBase> toppings, decimal expectedCost)
    {
      TestDelegate orderDrink = () => AcuCafe.Order.OrderGenerator.OrderDrink(drink,1, null);
      var exception = Assert.Catch<Exception>(orderDrink);
      var expectedMessage = string.Format(ExceptionMessage.DrinkTypeNotExist, drink);
      Assert.AreEqual(expectedMessage, exception.Message);
    }

  }
}
