using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input a double num:");
            double x = Convert.ToDouble(Console.ReadLine());
            x = System.Math.Sqrt(x);
            Console.WriteLine("the square root of x= {0:0.000}", x);
        }
    }
}
