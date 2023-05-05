using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    //Bread has price and number of units, with every third unit free.
    public int Price { get; set; }
    public int Loaf { get; set; }
    public static List<Bread> BreadCart = new List<Bread> {};

    public Bread(int priceOf, int loafNumber)
    {
      Price = priceOf;
      Loaf = loafNumber;
      BreadCart.Add(this);
    }

    public int Buy2Get1(object Bread)
    {
      if (Loaf % 3 == 0)
      {
        return 0;
      } 
      else
      {
        return Price;
      }
    }

    public static List<Bread> ShowCart()
    {
      return BreadCart;
    }

    public static void ClearAll()
    {
      BreadCart.Clear();
    }
  }
}