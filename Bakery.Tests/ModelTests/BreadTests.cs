using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5, 1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPriceSingle_ReturnsPrice_Int()
    {
      int priceOf = 5;
      Bread newBread = new Bread(priceOf, 1);
      int result = newBread.Price;
      Assert.AreEqual(result, priceOf);
    }

    [TestMethod]
    public void SetPriceSingle_SetsValueOfPrice_Void()
    {
      Bread newBread = new Bread(5, 1);
      int newPrice = 6;
      newBread.Price = newPrice;
      Assert.AreEqual(newPrice, newBread.Price);
    }

    [TestMethod]
    public void GetLoafSingle_ReturnsLoaf_Int()
    {
      int loafNumber = 1;
      Bread newBread = new Bread(5, loafNumber);
      int result = newBread.Loaf;
      Assert.AreEqual(result, loafNumber);
    }

    [TestMethod]
    public void SetLoafSingle_SetsLoafNumber_Void()
    {
    Bread newBread = new Bread(5, 1);
    int newLoaf = 2;
    newBread.Loaf = newLoaf;
    Assert.AreEqual(newLoaf, newBread.Loaf);
    }
    
    [TestMethod]
    public void Buy2Get1_DeterminesIfALoafIsFree_Int()
    {
      Bread newBread = new Bread(5, 3);
      int salePrice = newBread.Buy2Get1();
      Assert.AreEqual(0, salePrice);
    }

    [TestMethod]
    public void ShowCart_ReturnsPriceOfAllLoavesInCart_Int()
    {
      Bread round = new Bread(5, 1);
      Bread baguette = new Bread(5, 2);
      Bread como = new Bread(5, 3);
      int expected = 10;
      int actualResult = Bread.ShowAll();
      Assert.AreEqual(expected, actualResult); 
    }
  }
}