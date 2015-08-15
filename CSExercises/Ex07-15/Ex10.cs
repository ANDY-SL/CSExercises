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
            Console.Write("plz input 4 values x1 y1 x2 y2:\n");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("the two points you entered are ({0},{1}),({2},{3})\n", x1, y1, x2, y2);
            //int d=(x2-x1)^2+(y2-y1)^2;
          //  double s = Math.Sqrt(d);
            //Console.WriteLine("the distance is {0}",s);
            int x = x2 - x1;
            int  x_square = x*x;
            int y = y2 - y1;
            int y_square = y*y;
            double s = Math.Sqrt(x_square + y_square);
            Console.WriteLine("the distance is {0:0.00}",s);
            
        }
    }
}
