using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.Write("below is the list of all the perfect nums from 1 to 1000:\n");
            int i, j;
            for (i=1;i<=1000;i++)
            {
                int sum = 0;
                for (j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.Write(i + "\n");
            }
            Console.Write("\n");
        }
    }
}
                                                                                                                               