using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            Console.Write("the orginal sort of nums is :\n");
            int[] table;
            int i,j,max,temp=0;
            table = new int[20];
            table[0] = 86; table[1] = 35; table[2] = 41; table[3]  = 49; table[4] = 89;  table[5] = 51;  table[6] = 11;
            table[7] = 71; table[8] = 50; table[9] = 75; table[10] = 25; table[11] = 58; table[12] = 40; table[13] = 14;
            table[14] =44; table[15] = 3; table[16]= 63; table[17] = 81; table[18] = 93; table[19] = 79;
            for (i = 0; i < 20; i++)
                Console.Write("{0}\t", table[i]);
            Console.Write("\n\nafter being sorted ,the desending order will become:\n\n");
            for (i = 0; i < 20; i++)
            {
                max = i;
                temp = table[i];
                for (j = i + 1; j < 20; j++)
                {
                    if (table[j] > table[max])
                    {
                        max = j;
                        temp = table[max];
                    }
                }
                table[max] = table[i];
                table[i] = temp;
                for (int k = 0; k < 20;k++ )
                    Console.Write("{0}\t", table[k]);
                Console.WriteLine();

            }
           
 
                    
                
               

        }
    }
}
