using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.Write("please input two intergral nums A and B: \n A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int B = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (A > B)
                    A = A - B;
                else  B = B - A;
                if (A == B) break;
            } while (A == B);
            int HCF = A;
            int LCM = (A * B) / HCF;
            Console.Write("LCM={0}\n", LCM);
      
        }
    }
}
