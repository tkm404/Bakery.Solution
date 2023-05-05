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

    public static int Buy2Get1(int priceOf, int loafNumber)
    {
      if (loafNumber % 3 == 0)
      {
        return 0;
      } 
      else
      {
        return priceOf;
      }
    }

    public static List<Bread> ShowCart()
    {
      return BreadCart;
    }

    public static int AllBreadPrice()
    {
      int AllBreadTotal = 0;
      for (int index = 0; index < BreadCart.Count; index++)
      {
        int priceOf = BreadCart[index].Price;
        int loafNumber = BreadCart[index].Loaf;
        AllBreadTotal += Bread.Buy2Get1(priceOf, loafNumber);
      }
      return AllBreadTotal;
    }

    public static void ClearAll()
    {
      BreadCart.Clear();
    }
  }
}