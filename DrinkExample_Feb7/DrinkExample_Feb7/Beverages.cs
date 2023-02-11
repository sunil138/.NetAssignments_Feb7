using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkExample_Feb7
{
    class Beverages
    {
        public  int printCoffeeDetails(int numberOfCoffees, int cost)
        {
            return numberOfCoffees * cost;
        }
    }

        class CoffeeProperties: Beverages
        {
            public int printCoffeeDetails(int price, int quantity, int extracharges)
         {
            return extracharges + quantity * price;
         }
    
        }
}
