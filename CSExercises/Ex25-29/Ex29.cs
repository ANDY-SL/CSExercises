using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("enter a num to test whether it is a perfect num:\n");
            int x = Convert.ToInt32(Console.ReadLine());
            int i,sum=0;
            for(i=1;i<x;i++)
            {
                if (x % i == 0)
                    sum = sum + i;
            }
            if (sum == x)
                Console.Write("its a PERFECT num!\n");
            else Console.Write("its not a PERFECT num!\n");
        }
    }
}
