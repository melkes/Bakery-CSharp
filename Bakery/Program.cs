using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery
{
  public class Program
  {
     public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Here are our prices:");
      Console.WriteLine("Bread: $5/loaf (buy 2 get 1 free)");
      Console.WriteLine("Pastries: $2/each (buy 3 get 1 free)");
      Console.WriteLine("How many loaves of bread would you like?");
      int inputBread = int.Parse(Console.ReadLine());
      Console.WriteLine("And how many pastries would you like?");
      int inputPastry = int.Parse(Console.ReadLine());

      if ((inputBread + inputPastry) >= 1)
      {
        Bread bread = new Bread();
        Pastry pastry = new Pastry();

        int totalPrice = bread.CalculatePriceBread(inputBread) + pastry.CalculatePricePastry(inputPastry);
        Console.Write("The total price of your order is: $" + totalPrice);
      }
      else
      {
        Console.WriteLine("Something went wrong, or you entered 0 for both bread and pastry orders. Try again!");
        Main();
      }
    }
  }
}