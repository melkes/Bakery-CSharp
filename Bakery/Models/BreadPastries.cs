using System.Collections.Generic;
using System;

namespace Bakery
{
  public class Bread
  {
    public int price = 0;

    public int CalculatePriceBread(int numberOfLoaves)
    {
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
  }

  public class Pastry
  {
   public int price = 0;
   public int priceEachPastry = 2;

    public int CalculatePricePastry(int numberOfPastries)
    {
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
  }
}