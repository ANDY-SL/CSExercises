using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            Console.Write("guess the key num:\n key=");
            int key = Convert.ToInt32(Console.ReadLine());
            while (key !=88)
            {   Console.Write("try again\n");
                key=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write(" LUCKY YOU ,CONGRATULATIONS!!!!!!\n");   
            
        }
    }
}
