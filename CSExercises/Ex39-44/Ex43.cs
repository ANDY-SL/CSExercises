using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;namespace CSExercises
{
    public class Ex43
    {
        public static int Hex(int i)
        {
            int Sum = 0;
            int j = 0;
            while (i >= 1)
            {

                Sum = Sum + (i % 2) * (int)(Math.Pow(10, j));
                j++;
                i = i / 2;

            }
            return Sum;
        }
    }
}
