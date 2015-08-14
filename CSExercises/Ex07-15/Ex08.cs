using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("plz input the temperature c:");
            double c = Convert.ToDouble(Console.ReadLine());
            double F = 1.8 * c + 32;
            Console.WriteLine("the total income is {0}F", F);
        }
    }
}
