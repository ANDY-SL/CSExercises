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
            int i;
            for (i = 100; i < 1000; i++)
            {
                int a = i / 100;
                double a3 = Math.Pow(a, 3);
                int b = (i - a * 100) / 10;
                double b3 = Math.Pow(b, 3);
                int c = i - a * 100 - b * 10;
                double c3 = Math.Pow(c, 3);
                if (i == a3 + b3 + c3)
                    Console.WriteLine(i);
                else continue;
            }
        }
    }
}