using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskString
{
    internal class Time
    {
        internal int[] Difference(string time1, string time2)
        {

            char s1 = time1[2];
            char s2 = time1[5];
            string[] timea = time1.Split(s1, s2);

            char s3 = time2[2];
            char s4 = time2[5];
            string[] timeb = time2.Split(s3, s4);

            int[] timeFirst = new int[timea.Length];
            int[] timeSecond = new int[timea.Length];
            int[] diff = new int[timea.Length];

            int j = 0;

            for (int i = 0; i < timea.Length; i++)
            {
                timeFirst[i] = int.Parse(timea[i]);
                timeSecond[i] = int.Parse(timeb[i]);
            }

            for (int i = timea.Length - 1; i >= 0; i--)
            {
                diff[i] = timeSecond[i] - timeFirst[i];

                if (i >= timea.Length - 2)
                {
                    if (diff[i] < 0)
                    {
                        timeSecond[timeSecond.Length - 2 - j] -= 1;
                        diff[timea.Length - 1 - j] = 60 + diff[timea.Length - 1 - j];
                    }

                }
                else
                {
                    if (diff[i] < 0)
                        diff[timea.Length - 1 - j] = 24 + diff[timea.Length - 1 - j];
                }

                j++;
            }


            return diff;
        }

        internal void PrintArray(int[] a)
        {
            Console.Write("vaxtlar arasinda ferq:");
            foreach (var item in a)
            {
                Console.Write(item + ":");
            }
        }

    }
}
