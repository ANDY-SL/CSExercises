using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input 4 values x1 x2 y1 y2:\n");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x1={0}", x1);
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2={0}", x2);
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1={0}", y1);
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2={0}", y2);
            //int d=(x2-x1)^2+(y2-y1)^2;
          //  double s = Math.Sqrt(d);
            //Console.WriteLine("the distance is {0}",s);
            int x = x2 - x1;
            double  x_square = Math.Pow(x,2);
            int y = y2 - y1;
            double y_square = Math.Pow(y, 2);
            double s = Math.Sqrt(x + y);
            System.Console.WriteLine(x_square);
            
        }
    }
}
