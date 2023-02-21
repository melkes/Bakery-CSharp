using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bakery;

namespace Bakery.Tests
{
[TestClass]

  public class BreadTests
  { 
    [TestMethod]

    public void CalculatePrice_ValidInput_ReturnsPrice()
    {
        int numberOfLoaves = 6;
        int expectedResult = 20;
        Bread bread = new Bread();
        int result = bread.CalculatePriceBread(numberOfLoaves);
        Assert.AreEqual(expectedResult, result);
    }
    [TestMethod]
    public void CalculatePriceTwoLoaves_ValidInput_ReturnsPrice()
    {
        int numberOfLoaves = 2;
        int expectedResult = 10;
        Bread bread = new Bread();
        int result = bread.CalculatePriceBread(numberOfLoaves);
        Assert.AreEqual(expectedResult, result);
    }
  }
  [TestClass]

  public class PastryTests
  {
    [TestMethod]
    public void CalculatePricePastry_ValidInput_ReturnsPrice()
    {
      int numberOfPastries = 6;
      int expectedResult = 10;
      Pastry pastry = new Pastry();
      int result = pastry.CalculatePricePastry(numberOfPastries);
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
      int result = pastry.CalculatePricePastry(numberOfPastries) + bread.CalculatePriceBread(numberOfLoaves);
      Assert.AreEqual(expectedResult, result);
    }
  }
}
