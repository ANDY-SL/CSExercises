using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            int i = 1;
            Random X = new Random();
            int rnd = X.Next(0, 10);
            // Console.Write(rnd+"\n");
            Console.Write("guess a num between 0 and 9 :\n x=");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x!=rnd)
            {
                i++;
                Console.Write("try again !\n");
                x = Convert.ToInt32(Console.ReadLine());
            }
            if(i<=2)
            Console.Write("You are a Wizard ,and {0} times u have used .\n", i);
            else if (i<=5)
                Console.Write("You are a good guess ,and {0} times u have used .\n", i);
            else Console.Write("You are lousy ,and {0} times u have used .\n", i);

        }
    }
}
