using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int i,j,sum1=0,sum2=0,sum3=0,sum4=0;
            double sumx=0;
            Console.Write("NO\tsubject1\tsubject2\tsubject3\tsubject4\t sum\n");
            int[] subject1;
            int[] subject2;
            int[] subject3;
            int[] subject4;
            int[] sum;
            double[] deviation;
            double[] average;
            subject1 = new int[12];
            subject2 = new int[12];
            subject3 = new int[12];
            subject4 = new int[12];
            sum = new int[12];
            deviation =new double[4];
            average = new double[4];
            subject1[0] = 56; subject1[1] = 94; subject1[2] = 41; subject1[3] = 99; subject1[4] = 62; subject1[5] = 40;
            subject1[6] = 81; subject1[7] = 21; subject1[8] = 88; subject1[9] = 48; subject1[10] = 64; subject1[11] = 16;
            subject2[0] = 84; subject2[1] = 73; subject2[2] = 63; subject2[3] = 9; subject2[4] = 3; subject2[5] = 96;
            subject2[6] = 15; subject2[7] = 70; subject2[8] = 50; subject2[9] = 54; subject2[10] = 71; subject2[11] = 93;
            subject3[0] = 68; subject3[1] = 31; subject3[2] = 36; subject3[3] = 18; subject3[4] = 65; subject3[5] = 53;
            subject3[6] = 27; subject3[7] = 100; subject3[8] = 13; subject3[9] = 52; subject3[10] = 67; subject3[11] = 46;
            subject4[0] = 29; subject4[1] = 89; subject4[2] = 90; subject4[3] = 17; subject4[4] = 75; subject4[5] = 23;
            subject4[6] = 30; subject4[7] = 22; subject4[8] = 12; subject4[9] = 78; subject4[10] = 25; subject4[11] = 72;
            for (i = 0; i < 12; i++)
            {
                sum[i] = subject1[i] + subject2[i] + subject3[i] + subject4[i];
                Console.Write("{5} \t{0}\t\t {1}\t\t {2}\t\t {3}\t\t {4}\n", subject1[i], subject2[i], subject3[i], subject4[i],sum[i],i);
                sum1=sum1+subject1[i];
                sum2=sum2+subject2[i];
                sum3=sum3+subject3[i];
                sum4=sum4+subject4[i];
            }
            average[0] = sum1 / 12;
            average[1] = sum2 / 12;
            average[2] = sum3 / 12;
            average[3] = sum4 / 12;
            Console.Write("average {0:0.##}\t\t {1:0.##}\t\t {2:0.##}\t\t {3:0.##}\n", average[0], average[1], average[2], average[3]);
            Console.Write("deviation");
            for(i=0;i<4;i++)
            {
                sumx = 0;
                for (j = 0; j < 12; j++)
                
                    sumx = sumx + (subject1[j] - average[i]) * (subject1[j] - average[i]);
                deviation[i] =Math.Round(Math.Sqrt(sumx / 12),2);
                Console.Write(deviation[i]+"\t\t");
                                   
            }
            Console.Write("\ntotal average is   {0:0.##} \n\n\n ", (sum1 + sum2 + sum3 + sum4) / 48);
            
        }
    }
}
