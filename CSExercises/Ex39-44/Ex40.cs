using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            int i;
            Console.Write("No\tsquare root\n");
            for (i = 1; i <= 25; i++)
                Console.Write(i+"\t"+SQT(i)+"\n");
        }

        public static double SQT(int y)
        {
            double s;
            s = Math.Round(Math.Sqrt(y), 2);
            return s;
        }
    }
}
