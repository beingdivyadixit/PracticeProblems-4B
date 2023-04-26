using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems_4B
{
    class ConutDuplicatevalues
    {
        public static void arrayInfo()
        {
            int[] a = new int[5];
            int i, j, count = 0;
            Console.WriteLine("Elements");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Elements");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array Elements");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Elements" + a[i]);
            }
            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        Console.WriteLine(a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("Number of Elements repeated" + count);
        }
    }
}
