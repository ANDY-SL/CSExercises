using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int i,j,max,temp,min=0;
            string temp1;
            string[] name={"John","Venkat","Mary","Victor","Betty"};
            int[] mark={63,29,75,82,55};
            Console.Write("Name\tMark\n");
            for (i = 0; i < 5; i++)
                 Console.Write(name[i] + "\t" + mark[i] + "\n");
            max = 0;
            Console.Write("after being sorted,the report of marks will be in the descending order : \n");
            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (mark[j] > mark[max])
                        max = j;
                }
                temp = mark[max];
                mark[max] = mark[i];
                mark[i] = temp;
                Console.Write("{0}\t", mark[i]);              
            }
            Console.Write("\n");
            max=0;
            //Console.Write("the num  of F is {0}", Convert.ToInt32('F'));
            int[] namevalue;
            namevalue = new int[5];
            namevalue[0] = Convert.ToInt32('J');
            namevalue[1] = Convert.ToInt32('V');
            namevalue[2] = Convert.ToInt32('M');
            namevalue[3] = namevalue[1];
            namevalue[4] = Convert.ToInt32('B');
            max=0;
            Console.Write("second report:(sorted on student names alphabetically)\n");
            for (i = 0; i < 5; i++)
            {
                //Console.Write(namevalue[i]+"\t");
                for (j = i + 1; j < 5; j++)
                {
                    if (namevalue[j] < namevalue[min])
                        min = j;
                }
                temp1 = name[min];
                name[min] = name[i];
                name[i] = temp1;
                Console.Write(name[i] + "\n");

            }
          
        }
    }
}
