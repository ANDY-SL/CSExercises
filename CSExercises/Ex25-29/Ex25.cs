using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.Write("enter an intergral num :\n");
            int x = Convert.ToInt32(Console.ReadLine());
            int i,s=1;
            for(i=1;i<=x;i++)
            {
                 s = s * i;
            }
            Console.Write("the factorial of the num u entered is {0}\n", s);
            int j, t = x;
            for(j=x-1;j>=1;j--)
            {
                t = t *j;
                
            }Console.Write("the factorial2 of the num u entered is {0}\n", t);
        } 
    }

}
