using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.Write("NO\t INVERSE\t SQUARE ROOT\t SQUARE \n------------------------------------------------\n");
            int i=2;
            for(i=1;i<=10;i++)
           {
                double i_reverse = 1/(i*1.0);
                double s = Math.Sqrt(i);
                double i_square = i * i;
                Console.WriteLine("{0:0.0##}\t {1:0.000}\t         {2:0.000}\t           {3:0.0} \n",i, i_reverse, s, i_square);
           }
        }
    }
}
