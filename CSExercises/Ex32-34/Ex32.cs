using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            Console.Write("enter the sales for each month:\n");
            int[] Sales;
            Sales=new int[12];
            int i,Minimum,Maximum,Average,sum=0;
            for(i=0;i<=11;i++)
            {
                Sales[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sales[{0}]={1}\n",i, Sales[i]);
                sum=sum+Sales[i];
            }
            Maximum = 0;
            Minimum = 0;
            Average = sum / 12;
            for(i=0;i<=11;i++)
            {
                if(Sales[Minimum]>Sales[i])
                    Minimum=i;
                if (Sales[Maximum] < Sales[i])
                    Maximum = i;
            }
            Console.Write("Maximum Sales: {0}\n", Maximum);
            Console.Write("Minimum Sales: {0}\n", Minimum);
            Console.Write("Average Sales: {0}\n", Average);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        }
    }
}
