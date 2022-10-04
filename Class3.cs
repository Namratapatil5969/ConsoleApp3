using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class3
    {
        static int calculate_sellingprice(int cost_price,int no_of_items,int profit)
        {        

            cost_price = cost_price * no_of_items;
            profit = (cost_price * profit) / 100;
            profit = cost_price + profit;
            int selling_price = profit / no_of_items;
            return selling_price;
            
        }

        
        public static void Main()
        {
            int cost_price = int.Parse(Console.ReadLine());
            int no_of_items = int.Parse(Console.ReadLine());
            int profit = int.Parse(Console.ReadLine());

            
                Console.WriteLine(calculate_sellingprice(cost_price,
                              no_of_items,profit) + ": selling price: ");

           
        }
    }
}
