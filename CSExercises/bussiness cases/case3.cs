using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness_case
{
    class ex03
    {
        static void Main(string[] args)
        {
            int i, temp;
            string s1 = Console.ReadLine();
            //Console.Write("the orinal string is " + s1+"\n");
            char[] char_s1 = new char[s1.Length];
            char[] char_s2 = new char[s1.Length];
            // Console.Write("Fisrt Transformation:\n");
            //Console.Write("the num of z is "+ Convert.ToInt32('z')+"\n");
            //Console.Write("the num of Z is " + Convert.ToInt32('x') + "\n");
            //Console.Write("the num of 9 is " + Convert.ToInt32('9') + "\n");
            Console.Write("Fisrt Transformation:\n");
            for (i = 0; i < s1.Length; i++)
            {
                char_s1[i] = s1[i];
                if (Convert.ToInt32(char_s1[i]) == 122)
                {
                    char_s2[i] = 'a';
                    Console.Write(char_s2[i]);
                }

                else if
                 (Convert.ToInt32(char_s1[i]) == Convert.ToInt32('Z'))
                {
                    char_s2[i] = 'A';
                    Console.Write(char_s2[i]);
                }

                else if (Convert.ToInt32(char_s1[i]) == 57)
                {
                    char_s2[i] = Convert.ToChar(Convert.ToInt32('9') - 9);
                    Console.Write(char_s2[i]);
                }

                else
                {
                    temp = Convert.ToInt32(char_s1[i]);
                    char_s2[i] = Convert.ToChar(temp + 1);
                    Console.Write(char_s2[i]);
                }
                // Console.Write(" the ASCII num of " + char_s1[i] + "is" + Convert.ToInt32(char_s1[i])+"\n");


            }
            Console.Write("\nSecond Transformation:\n");
            for (i = s1.Length - 1; i >= 0; i--)
                Console.Write(char_s2[i]);
            Console.Write("\n");
        }
    }
}
