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

  }
}
