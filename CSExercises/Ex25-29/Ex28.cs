using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.Write("enter a num to test whether it is a prime num:\n");
            int x = Convert.ToInt32(Console.ReadLine());
            int i;
            for(i=2;i<x;i++)
            {
                if (x % i == 0)
                    break;
            }
            if (i < x - 1)
                Console.Write("NOT PRIME\n");
            else Console.Write("PRIME\n");
        }
    }
}
