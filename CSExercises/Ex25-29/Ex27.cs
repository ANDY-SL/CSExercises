using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        { 
            Console.Write("X        Y\n-----------------------------------\n");
            int i ;
            for (i = -5; i <= 5; i++)
            {
                int Y=2*i*i-4*i+3;
                Console.Write("{0:0.0}\t {1:0.0}\n",i,Y);
            }
            Console.Write("graph below indicates the value of y for all interger x in the range of 1 to 20:\n");
            int j,n;
            for(j=-5;j<=5;j++)
            {
                int y = 2 * j * j - 4 * j + 3;
                for (n = 1; n <= y; n++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
