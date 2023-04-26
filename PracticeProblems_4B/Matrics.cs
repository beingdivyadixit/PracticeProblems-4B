using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems_4B
{
    internal class Matrics
    {
        public static void SumofMatric()
        {
            int sum, row, col;
            Console.WriteLine("How many rows u want?");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cols u want?");
            col = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine("Enter elements of matrix");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix :");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("sum of row [{0}]:{1}", (i + 1), sum);
            }
        }
    }
}
