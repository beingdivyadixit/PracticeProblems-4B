﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems_4B
{
    class UniqueueValues
    {
        public static void UniqueueInfo()
        {
            int[] a = new int[5];
            int i, j, count = 0;
            Console.WriteLine("Elements");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter Elements");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\narray Elements");
            for (i = 0; i < a.Length; i++)
            {
                Console.WriteLine("\nEnter Elements" + a[i]);
            }
            for (i = 0; i < a.Length; i++)
            {
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        //count++;
                        Console.WriteLine("\n duplicatevalues" + a[i]);
                        break;
                    }
                    else
                    {
                        count++;
                        Console.WriteLine("\nUnique values" + a[i]);
                        break;
                    }
                }
            }
            Console.WriteLine("\nNumber of Elements uniqueue" + count);
        }
    }
}
