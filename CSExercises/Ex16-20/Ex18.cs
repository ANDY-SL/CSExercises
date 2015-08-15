using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            string Grade="errors";
            Console.Write("please enter your scores: \n scores:");
            int Marks = Convert.ToInt32(Console.ReadLine());
            if (Marks>= 80 && Marks<=100)
                 Grade="A";
            else if (Marks>=60 && Marks<=79)
                 Grade="B";
            else if (Marks>=40 && Marks<=59)
                 Grade="C";
            else if (Marks>=0 && Marks<=39)
                 Grade="F";
            else Console.Write("errors enter ");
            Console.Write("You scored {0} marks which is {1} grade.\n ",Marks,Grade );

            
        }
    }
}