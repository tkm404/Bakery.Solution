using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
    RunBakery();
    }
    static void RunBakery()
    {
      Bread.BreadCart.Clear();
      Pastry.PastryCart.Clear();
      Console.WriteLine("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
      Console.WriteLine("Welcome to Pierre's Bakery");
      string today = DateTime.Now.ToString("ddd");
      Console.WriteLine($"Today is {today}");
      Console.WriteLine("Great weather we're having!");
      Console.WriteLine("Bread Loaves cost $5.");
      Console.WriteLine("Pastires cost $2.");
      Console.WriteLine($"Our {today} specials are:");
      Console.WriteLine("Bread: Buy 2 Loaves, get 1 Free!");
      Console.WriteLine("and...");
      Console.WriteLine("Pastry: Buy 3 Pastries, get 1 Free!");
      Console.WriteLine("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
      Console.WriteLine("So, what'll it be, stranger?");
      LoafEnter();
      int total = Bread.AllBreadPrice();
      Console.WriteLine($"A total of {total}");

    }

    static void LoafEnter()
    {
      try
      {
        Console.WriteLine("How many bread loaves would you like? (enter a number)");
        int breadNumber = Convert.ToInt32(Console.ReadLine());
        MakeLoaves(breadNumber);
        Console.WriteLine($"{breadNumber} loaves, huh? that will run you...");
      }
  catch
      {
        Console.WriteLine("I'm not sure what number that is. Run that by me again?");
        LoafEnter();
      }
    }
    static void MakeLoaves(int breadNumber)
    {
      for (int i = 0; i <= breadNumber; i++) 
      {
      Bread newBread = new Bread(5, i); 
      }
    }
  }
}