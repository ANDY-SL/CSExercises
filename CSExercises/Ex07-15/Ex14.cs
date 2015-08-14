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
            Console.Write("plz input three sides:a,b,c");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;
            double area=s*(s-a)*(s-b)*(s-c);
            Console.WriteLine("the area is {0}",area);
        }
    }
}