using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness_case
{
    class case2
    {
        static void Main(string[] args)
        {
            Console.Write("the ASCII num of A is " + Convert.ToInt32('A') + "\n");
            Console.Write("the ASCII num of 9 is " + Convert.ToInt32('9') + "\n");
            int temp, remain;
            int[] postcode = new int[6];
            char alpha;
            string blknum = null;
            Console.Write("pleasw input the old code :\n");
            int oldcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the block num:\n");
            string blk = Console.ReadLine();
            Console.Write("the old code" + oldcode + "\nblk num is " + blk + "\n");
            // if (s.Contains("Singapore"))
            //   Console.Write("tthe index of singapore is "+s.IndexOf("Singapore")+"\n");
            remain = oldcode - oldcode / 100 * 100;
            postcode[0] = remain / 10;
            postcode[1] = remain % 10;
            foreach (char item in blk)
            {
                if (item >= 48 && item <= 57)
                    blknum += item;
            }
            temp = int.Parse(blknum);
            postcode[3] = temp / 100;
            postcode[4] = (temp - postcode[3] * 100) / 10;
            postcode[5] = temp - postcode[3] * 100 - postcode[4] * 10;
            try
            {
                alpha = Convert.ToChar(blk[3]);
            }
            catch
            {
                alpha = 'A';
            }

            postcode[2] = Convert.ToInt32(alpha) - 64;
            for (int i = 0; i < 6; i++)
                Console.Write(postcode[i] + "\t");
        }
    }
}
