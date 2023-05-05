using System;
using System.Collections.Generic;

namespace Bakery.Models
{
  public class Bread
  {
    //Bread has price and number of units, with every third unit free.
    public int price { get; set; }
    public int loaf { get; set; }
    private static List<Bread> _breadCart = new List<Bread> {};

    public Bread(int priceOf, int loafNumber)
    {
      price = priceOf;
      loaf = loafNumber;
      _breadCart.Add(this);
    }

  }
}