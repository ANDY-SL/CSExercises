using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("please enter an amount (dollar.cents):\n");
            double dollar = Convert.ToDouble(Console.ReadLine());
            int dollar_100 =Convert.ToInt32(Math.Round(dollar*100));
            Console.Write("the amount you entered is {0}cents\n", dollar_100);
            int hundred = dollar_100 / 100;
            for(i=0;i<hundred;i++)
                Console.Write("100c\n");
            int remain=dollar_100-100*hundred;
            int fifty = remain / 50;
            for (i = 0; i < fifty; i++)
                Console.Write("50c\n");
                remain = remain - fifty * 50;
            int twenty = remain / 20;
            for (i = 0; i < twenty; i++)
                Console.Write("20c\n");
            remain = remain - twenty * 20;
            int ten = remain / 10;
            for (i = 0; i < ten; i++)
                Console.Write("10c\n");
            remain = remain - ten * 10;
            int five = remain / 5;
            for (i = 0; i < five; i++)
                Console.Write("5c\n");
        }
    }
}
