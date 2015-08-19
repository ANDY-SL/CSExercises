using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input three sides:a,b,c\n");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            bool quit = false;
            while (quit == false)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    double s = (a + b + c) / 2;
                    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    quit = true;
                    Console.WriteLine("the area is {0}", area);
                }
                else
                {
                    Console.Write("its not a triangle:\nplease enter again:\n");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                }
               
            }
        }
    }
}