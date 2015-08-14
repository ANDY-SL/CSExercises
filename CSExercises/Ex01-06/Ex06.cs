using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input an interger num x:");
            int  x = Convert.ToInt32(Console.ReadLine());
            double y =System.Math.Sqrt(x);
            Console.WriteLine("the square root of x= {0}", y);
        }
    }
}
