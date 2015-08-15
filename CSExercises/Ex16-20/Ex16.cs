using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string G = "gender";
            Console.Write("please enter your name and gender(M or F)\n name :");
            string name = Console.ReadLine();
            Console.Write("\n gender:");
            string gender_ = Console.ReadLine();
            if(gender_=="M")
                 G="Mr.";
            else if(gender_=="F")
                 G="Mr.";
            else Console.WriteLine("errors enter");
            Console.WriteLine("Good Morning "+G+name);


        }
    }
}