using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems_4B
{
    internal class FrequencyofArray
    {
        public static void Frequency()
        {
            int[] word = new int[100];
            int[] freq = new int[100];
            int i, j, ctr;
            Console.Write("Input the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n");

            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                word[i] = Convert.ToInt32(Console.ReadLine());
                freq[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (word[i] == word[j])
                    {
                        ctr++;
                        freq[j] = 0;
                    }
                }
                if (freq[i] != 0)
                {
                    freq[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (freq[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", word[i], freq[i]);
                }
            }
        }
    }
}
