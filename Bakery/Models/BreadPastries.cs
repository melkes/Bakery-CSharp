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
            int fullPrice = numberOfLoaves / 3 * 2;
            int remainingLoaves = numberOfLoaves % 3;
            price = fullPrice * 5;
        }

        return price;
    }
    
    public static void ClearAll()
  {
    //do nothing 
  }
  }

  public class Pastry
  {

  }
  
}