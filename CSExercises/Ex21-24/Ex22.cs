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
            int s1;
            Console.Write("please input two intergral nums A and B: \n A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B=");
            int B = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (A > B)
                     s1 = A - B;
                else   s1 = B - A;
                if (s1==A||s1==B) break;
            } while (s1!=A && s1!=B);
            int HCF = s1;
            int LCM = (A * B) / HCF;
            Console.Write("HCF={1}\nLCM={0}\n", LCM,HCF);
      
        }
    }
}
