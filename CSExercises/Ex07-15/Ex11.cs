using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input the distance:");
            double d = Convert.ToDouble(Console.ReadLine());
            double f = 2.40 + d * 0.4;
            Console.WriteLine("the fare is {0}", f);


        }
    }
}
