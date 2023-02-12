using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
      public void Dispose()
    {
      Bread.ClearAll();
    }
    
    [TestMethod]
    // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue
    public void CalculatePrice_ValidInput_ReturnsPrice()
    {
        int numberOfLoaves = 6;
        int expectedResult = 20;
        Bread bread = new Bread();
        int result = bread.CalculatePrice(numberOfLoaves);
        Assert.AreEqual(expectedResult, result);

    }
    [TestMethod]
    public void CalculatePriceTwoLoaves_ValidInput_ReturnsPrice()
    {
        int numberOfLoaves = 2;
        int expectedResult = 10;
        Bread bread = new Bread();
        int result = bread.CalculatePrice(numberOfLoaves);
        Assert.AreEqual(expectedResult, result);
    }
    [TestMethod]

    public void CalculatePricePastry_ValidInput_ReturnsPrice()
    {
      int numberOfPastries = 6;
      int expectedResult = 10;
      Pastry pastry = new Pastry();
      int result = pastry.CalculatePrice(numberOfPastries);
      Assert.AreEqual(expectedResult, result);
    }
    [TestMethod]
    public void CalculatePricePastryAndBread_ValidInput_ReturnsPrice()
    {
      int numberOfPastries = 6;
      int numberOfLoaves = 3;
      Pastry pastry = new Pastry();
      Bread bread = new Bread();
      int expectedResult = 20;
      int result = pastry.CalculatePrice(numberOfPastries) + bread.CalculatePrice(numberOfLoaves);
      Assert.AreEqual(expectedResult, result);
    }
  }
}
