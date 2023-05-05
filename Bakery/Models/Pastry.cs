using System.Collections.Generic;

namespace Bakery.Models
{
  public class Pastry
  {
    //Pastry has price and number of units, with every third unit free.
    public int Price { get; set; }
    public int Item { get; set; }
    public static List<Pastry> PastryCart = new List<Pastry> {};

    public Pastry(int priceOf, int itemNumber)
    {
      Price = priceOf;
      Item = itemNumber;
      PastryCart.Add(this);
    }

    public static int Buy3Get1(int priceOf, int loafNumber)
    {
      if (loafNumber % 4 == 0)
      {
        return 0;
      } 
      else
      {
        return priceOf;
      }
    }

    public static List<Pastry> ShowCart()
    {
      return PastryCart;
    }

    public static int AllPastryPrice()
    {
      int AllPastryTotal = 0;
      for (int index = 0; index < PastryCart.Count; index++)
      {
        int priceOf = PastryCart[index].Price;
        int itemNumber = PastryCart[index].Item;
        AllPastryTotal += Pastry.Buy3Get1(priceOf, itemNumber);
      }
      return AllPastryTotal;
    }

    public static void ClearAll()
    {
      PastryCart.Clear();
    }
  }
}