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
    public void CalculatePrice_ValidInput_ReturnsPrice()
    {
        // Arrange
        int numberOfLoaves = 3;
        Bread bread = new Bread();
        decimal expectedResult = 10;

        // Act
        decimal result = bread.CalculatePrice(numberOfLoaves);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }
    // [TestMethod]

  }
}