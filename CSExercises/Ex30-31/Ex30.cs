using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            Console.Write("Below is the list of all the PRIME nums from 5 to 10000:\n");
            int i,j;
            for (i=5; i<=10000; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (j == i )
                    Console.Write(i + "\t");
            }
        }
    }
}
