using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] rnd;
            int[] num;
            num = new int[10];
            int i;
            Console.Write("Number\tCount\n");
            for (i = 0; i < 10; i++)
                num[i] = 0;
            Random index=new Random();
            rnd = new int[50];
            for(i=0;i<50;i++)
            {
                rnd[i] = index.Next(0, 10);
                //Console.Write(rnd[i] + "\n");
                for(int j=0;j<10;j++)
                    if (rnd[i] == j)
                        num[j]++;
            }
            for (i = 0; i < 10; i++)
                Console.Write("{1}\t{0}\n", num[i],i);
            Console.Write("\n----------------------------\n PART 2\nNumber\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write(i + "\t");
                for (int j = 0; j < num[i]; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            

        }
    }
}
