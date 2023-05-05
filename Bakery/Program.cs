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
      Console.WriteLine("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
      Console.WriteLine("Welcome to Pierre's Bakery");
      string today = DateTime.Now.ToString("ddd");
      Console.WriteLine($"Today is {today}");
      Console.WriteLine("Great weather we're having!");
      Console.WriteLine($"Our {today} specials are:");
      Console.WriteLine("Bread: Buy 2 Loaves, get 1 Free!");
      Console.WriteLine("and...");
      Console.WriteLine("Pastry: Buy 3 Pastries, get 1 Free!");
      Console.WriteLine("~~~~~~~~~....~~~~~~~~~....~~~~~~~~~....~~~~~~~~");
    }
  }
}