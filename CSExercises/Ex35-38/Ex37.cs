using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.Write("enter a title:\n");
            string sentence = Console.ReadLine().ToLower();
            int i;
            char[] chars;
            chars=new char[sentence.Length];
            for(i=0;i<sentence.Length;i++)
            {
                chars[i] = sentence[i];
            }
            chars[0] = char.ToUpper(chars[0]);
            for(i=1;i<sentence.Length;i++)
            {
                if (chars[i] == ' ')
                    chars[i + 1] = char.ToUpper(chars[i + 1]);
            }
            Console.Write("=====>\n");
            for (i = 0; i < sentence.Length;i++)
                Console.Write(chars[i]);
                Console.Write("\n");

         
            
        }
    }
}
