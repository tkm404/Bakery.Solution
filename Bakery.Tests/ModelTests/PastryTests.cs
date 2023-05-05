using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2, 1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPriceSingle_ReturnsPrice_Int()
    {
      int priceOf = 2;
      Pastry newPastry = new Pastry(priceOf, 1);
      int result = newPastry.Price;
      Assert.AreEqual(result, priceOf);
    }

    [TestMethod]
    public void SetPriceSingle_SetsValueOfPrice_Void()
    {
      Pastry newPastry = new Pastry(2, 1);
      int newPrice = 6;
      newPastry.Price = newPrice;
      Assert.AreEqual(newPrice, newPastry.Price);
    }

    [TestMethod]
    public void GetItemSingle_ReturnsItem_Int()
    {
      int itemNumber = 1;
      Pastry newPastry = new Pastry(2, itemNumber);
      int result = newPastry.Item;
      Assert.AreEqual(result, itemNumber);
    }

    [TestMethod]
    public void SetItemSingle_SetsItemNumber_Void()
    {
    Pastry newPastry = new Pastry(2, 1);
    int newItem = 2;
    newPastry.Item = newItem;
    Assert.AreEqual(newItem, newPastry.Item);
    }
    
    [TestMethod]
    public void Buy3Get1_DeterminesIfALoafIsFree_Int()
    {
      int itemNumber = 4;
      Pastry newPastry = new Pastry(2, itemNumber);
      int salePrice = Pastry.Buy3Get1(2, 4);
      Assert.AreEqual(0, salePrice);
    }

    [TestMethod]
    public void ShowCart_ShowsAllPastryInstances_List()
    {
      Pastry danish = new Pastry(2, 1);
      Pastry macaron = new Pastry(2, 2);
      Pastry fritter = new Pastry(2,3);
      List<Pastry> expected = new List<Pastry> { danish, macaron, fritter };
      List<Pastry> actualResult = Pastry.ShowCart();
      CollectionAssert.AreEqual(expected, actualResult);
    }

    [TestMethod]
    public void AllPrice_ReturnsPriceOfAllLoavesInCart_Int()
    {
      Pastry pastry1 = new Pastry(2, 1);
      Pastry pastry2 = new Pastry(2, 2);
      Pastry pastry3 = new Pastry(2, 3);
      Pastry pastry4 = new Pastry(2, 4);
      int expected = 6;
      int actualResult = Pastry.AllPastryPrice();
      Assert.AreEqual(expected, actualResult); 
    }
  }
}