using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.Write("enter a sentence :\n");
            string sentence=Console.ReadLine().ToLower();
            int count=0,i,numa=0,nume=0,numi=0,numo=0,numu=0;
            for (i = 0; i < sentence.Length; i++)
            {
                if (sentence[i]=='a' || sentence[i]=='e'|| sentence[i]=='i'|| sentence[i]=='o' || sentence[i]=='u')
                { count++;
                }
                if (sentence[i] == 'a') numa++;
                if (sentence[i] == 'e') nume++;
                if (sentence[i] == 'i') numi++;
                if (sentence[i] == 'o') numo++;
                if (sentence[i] == 'u') numu++;

            }
            Console.Write("total num of vowels :  {0}\n", count);
            Console.Write("Number of a:{0}\nNumber of e:{1}\nNumber of i:{2}\nNumber of o:{3}\nNumber of u:{4}\n\n\n\n", numa, nume, numi, numo, numu);

            
        }
    }
}
