using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("please enter your name :\n name :");
            string name = Console.ReadLine();
            Console.Write("please enter your gender:\n gender(M OR F): ");
            string gender = Console.ReadLine();
            Console.Write("please enter your age:\n age:");
            int age=Convert.ToInt32(Console.ReadLine());
            if (gender == "M" && age > 39)
                Console.Write("GOOD MORNING Uncle " + name + "\n");
            else if (gender == "M" && age < 40)
                Console.Write("GOOD MORNING MS " + name +"\n" );
            else if (gender == "F" && age > 39)
                Console.Write("GOOD MORNING Aunty " + name +"\n" );
            else Console.Write("GOOD MORNING Ms " + name +"\n");


            
        }
    }
}