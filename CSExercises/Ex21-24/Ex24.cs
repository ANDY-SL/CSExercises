using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int N = 100;
            N= Convert.ToInt32(Console.ReadLine());
            Random X = new Random();
            int G = X.Next(1, N);
            Console.Write(G+"\n");
            double S = Convert.ToDouble(G);
            double J = Convert.ToDouble(N);
            while (S * S != J)
            {
                S = (S + J / S) / 2;
                S = Math.Round(S, 2);
                J = Math.Round(J, 2);
            }
           Console.Write("the square root is {0:0.00}\n", S); 
            
        }
    }
}
