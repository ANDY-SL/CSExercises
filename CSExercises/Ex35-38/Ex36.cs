using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            //Console.Write("enter a string:\n");
            //string sentence = Console.ReadLine().ToLower();
            //sentence = sentence.Replace(" ", "");
            //Console.Write("after modification,the sentence is "+sentence+"\n");
            //int i;
            //Console.Write("the length of the sentence is {0}\n", sentence.Length);
            //for (i = 0; i < sentence.Length ; i++)
            //    if (sentence[i] != sentence[sentence.Length - 1 - i])
            //        break;
            //if (i == sentence.Length)
            //    Console.Write("\tPalindrome\n\n\n");
            //else Console.Write("\tNot palindrome\n \n\n");
            Console.Write("please enter a string :\n");
            string s = Console.ReadLine();
            string s2;
            char[] CharOfs  = s.ToCharArray();;
            Array.Reverse(CharOfs);
            s2 = new string(CharOfs);
            if (s2 == s)
                Console.Write("\tPalindrome\n\n\n");
            else Console.Write("\tNot palindrome\n \n\n");
             

        }
    }
}
