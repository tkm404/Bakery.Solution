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
      Console.WriteLine("How about some pastries? (y/n)");
      string proceed = Console.ReadLine();
      int total = Bread.AllBreadPrice();
      if (proceed.ToLower() == "y")
      {
        PastryEnter();
        int totalP = Pastry.AllPastryPrice();
        Console.WriteLine($"A total of ${totalP}.");
        Console.WriteLine("Your grand total for today is...");
        int grandTotal = (total + totalP);
        Console.WriteLine($"... ${grandTotal}! What a haul!");
        Console.WriteLine("Thank you for stopping by! Have a great rest of your day.");
        Console.WriteLine("Next Customer, please! (enter 'y' to restart or 'n' to exit)");
        string restart = Console.ReadLine();
        if (restart.ToLower() == "y")
        {
          RunBakery();
        }
        else
        {
          Console.WriteLine("Closing up for today! See you tomorrow!");
          Console.Write("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
        }
      }
      else if (proceed.ToLower() != "n")
      {
        Console.WriteLine("Uh... pardon? I'll just assume you don't want pastries, then.");
        Console.WriteLine($"So in that case, your grand total for today is ${total}!");
        Console.WriteLine("Thank you for your patronage. Have a great day!");
        Console.WriteLine("Next Customer, please! (enter 'y' to restart or 'n' to exit)");
        string restart = Console.ReadLine();
        if (restart.ToLower() == "y")
        {
          RunBakery();
        }
        else
        {
          Console.Write("Closing time! See you later!");
          Console.Write("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
        }
      }
      else
      {
        Console.WriteLine($"Alrighty, Your grand total for today is ${total}!");
        Console.WriteLine("Have a nice day, now!");
        Console.WriteLine("Next Customer, please! (enter 'y' to restart or 'n' to exit)");
        string restart = Console.ReadLine();
        if (restart.ToLower() == "y")
        {
          RunBakery();
        }
        else
        {
          Console.Write("Closing down early today. See you next time!");
          Console.Write("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
        }
      }
    }

    static void LoafEnter()
    {
      try
      {
        Console.WriteLine("How many bread loaves would you like? (enter a number)");
        int breadNumber = Convert.ToInt32(Console.ReadLine());
        MakeLoaves(breadNumber);
        Console.WriteLine($"{breadNumber} loaves, huh? that will run you...");
         int total = Bread.AllBreadPrice();
        Console.WriteLine($"A total of ${total}.");
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