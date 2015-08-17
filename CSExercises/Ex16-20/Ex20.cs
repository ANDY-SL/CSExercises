using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            int TV = 0, DVD = 0, MP3 = 0;
            double price = 0;
            Console.Write("PRODUCT \tPRICE\n");
            Console.Write("TV     \t        $900\n");
            Console.Write("DVD    \t        $500\n");
            Console.Write("MP3    \t        $700\n");
            Console.Write("please enter the quantity of the products you need : \n quantity of TV:");
            TV = Convert.ToInt32(Console.ReadLine());
            Console.Write("quantity of DVD :");
            DVD = Convert.ToInt32(Console.ReadLine());
            Console.Write("quantity of MP3 :");
            MP3 = Convert.ToInt32(Console.ReadLine());
            price = TV * 900 + DVD * 500 + MP3 * 700;
            if (price <= 5000)
                
                Console.Write("the total price of your order is {0:c}\n", price);

            else if (price > 5000 && price <= 10000)
            {
                price = (TV * 900 + DVD * 500) * 0.9 + MP3 * 700;
                Console.Write("the total price of your order is {0:c}\n", price );
            }
            else
            {
                price = (TV * 900 + DVD * 500) * 0.85 + MP3 * 700;
                Console.Write("the total price of your order is {0:c}\n", price );
            }

            
        }
    }
}