using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input the salary:");
            double s = Convert.ToDouble(Console.ReadLine());
            double t = 1.13 * s;
            Console.WriteLine("the total income is {0:c}", t);
        }
    }
}
