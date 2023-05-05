using System;
using System.Collections.Generic;
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
      Console.WriteLine($"A total of {total}.");
      BreadSaleMessage();
      Console.WriteLine("How about some pastries? (y/n)");
      string proceed = Console.ReadLine();
      if (proceed.ToLower() == "y")
      {
        PastryEnter();
        int totalP = Pastry.AllPastryPrice();
        Console.WriteLine($"A total of {totalP}.");
      }
      else
      {
        Console.WriteLine($"Alrighty, Your grand total for today is {total}!");
        Console.WriteLine("Have a nice day, now!");
      }
      Console.WriteLine("Your grand total for today is...");
      int grandTotal = total + Pastry.AllPastryPrice();
      Console.WriteLine($"... {grandTotal}! What a haul!");
      
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

    static string BreadSaleMessage()
    {
      if (Bread.AllBreadPrice() % 10 == 0)
      {
        return "That's $5 off every third loaf! Thank you!";
      }
      else
      {
        return "Thank you.";
      }
    }

    static void MakePastries(int pastryNumber)
    {
      for (int i = 0; i <= pastryNumber; i++)
      {
        Pastry newPastry = new Pastry(2, i);
      }
    }

    static void PastryEnter()
    {
      try
      {
        Console.WriteLine("How many pastries would you like? (enter a number)");
        int pastryNumber = Convert.ToInt32(Console.ReadLine());
        MakePastries(pastryNumber);
        Console.WriteLine($"{pastryNumber} pastries, right? that'll be...");
      }
  catch
      {
        Console.WriteLine("I'm not sure what number that is. Run that by me again?");
        PastryEnter();
      }
    }
  }
}