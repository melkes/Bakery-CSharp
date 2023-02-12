using System.Collections.Generic;
using System;

namespace Bakery
{
  public class Bread
  {
    public int price = 0;

    public int CalculatePrice(int numberOfLoaves)
    {
      // if statements for 1, 2 and 3+ loaves
       if (numberOfLoaves == 1)
        {
            price = 5;
        }
        else if (numberOfLoaves == 2)
        {
            price = 10;
        }
        else if (numberOfLoaves >= 3)
        {
            int dealPrice = numberOfLoaves / 3 * 2;
            price = dealPrice * 5;
        }

        return price;
    }

    public static void ClearAll()
  {
    //do nothing 
  }
  }
// Pastry class
  public class Pastry
  {
   public int price = 0;
   public int priceEachPastry = 2;

    public int CalculatePrice(int numberOfPastries)
    {
      // if statements for 1, 2, 3 and 4+ pastries
       if (numberOfPastries == 1)
        {
            price = 2;
        }
        else if (numberOfPastries == 2)
        {
            price = 4;
        }
        else if (numberOfPastries == 3)
        {
           price = 6;
        }
        else if (numberOfPastries >= 4)
        {
           int dealPastries = numberOfPastries / 4;
           int remainderPastries = numberOfPastries % 4 ;
          price = (priceEachPastry * remainderPastries) + (dealPastries * 3 * priceEachPastry);
        }

        return price;
    }

    public static void ClearAll()
  {
    //do nothing 
  }
  }
  
}