using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
           Console.Write("ARMSTRONG num test \n plz enter a num(3 digit) :");
           int x = Convert.ToInt32(Console.ReadLine());
           int hundred = x / 100;
           int ten = (x - 100 * hundred) / 10;
           int digit = x - 100 * hundred - ten * 10;
           if (x == Math.Pow(hundred, 3) + Math.Pow(ten, 3) + Math.Pow(digit, 3))
               Console.Write("it is an armstrong num .\n");
           else Console.Write("its not an armstrong num.\n");
            }
    }
}