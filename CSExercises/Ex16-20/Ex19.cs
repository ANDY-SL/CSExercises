using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("please enter your distance(two decimal) :\n distance =");
            double distance = Convert.ToDouble(Console.ReadLine());
            distance = Math.Ceiling(distance * 10) / 10;
            double  charge;
            if (distance <= 0.5)
                charge = 2.4;
            else if (distance > 0.5 && distance <= 9)
                charge = 2.4 + (distance - 0.5) * 0.4;
            else charge = 2.4 + 8.5 * 0.4 + (distance - 9) * 0.5;
            Console.Write("the final charge is {0:0.00}$ \n", charge);



        }
    }
}