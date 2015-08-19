using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness_case
{
    class p
    {
        static void Main(string[] args)
        {
            Console.Write("input the amount of dollars:");
            double dollar = Convert.ToDouble(Console.ReadLine());
            int Dollar = Convert.ToInt32(dollar * 100);
            //Console.Write(Dollar);
            int Thousand = Dollar / 100000;
            int remain = Dollar - Thousand * 100000;
            int Hundred = remain / 10000;
            remain = remain - Hundred * 10000;
            int Ten = remain / 1000;
            remain = remain - Ten * 1000;
            int Unit = remain / 100;
            remain = remain - Unit * 100;
            int CentTen = remain / 10;
            remain = remain - CentTen * 10;
            int CentUnit = remain;
            string[] s1 = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] s2 = new string[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            if (Thousand == 0 && Hundred == 0)
                Console.Write("Dollar " + s2[Ten] + " " + s1[Unit] + " cents " + s2[CentTen] + " " + s1[CentUnit] + "\n");
            else if (Thousand == 0 && Hundred != 0)
                Console.Write("Dollar " + s1[Hundred] + " hundred " + s2[Ten] + " " + s1[Unit] + " cents " + s2[CentTen] + " " + s1[CentUnit] + "\n");
            else if (Hundred == 0 && Thousand != 0)
                Console.Write("Dollar " + s1[Thousand] + " Thousand " + s2[Ten] + " " + s1[Unit] + " cents " + s2[CentTen] + " " + s1[CentUnit] + "\n");
            else
                Console.Write("Dollar " + s1[Thousand] + " Thousand " + s1[Hundred] + " hundred " + s2[Ten] + " " + s1[Unit] + " cents " + s2[CentTen] + " " + s1[CentUnit] + "\n");
        }
    }
}
