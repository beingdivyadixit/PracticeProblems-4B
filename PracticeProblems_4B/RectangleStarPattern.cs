using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems_4B
{
    internal class RectangleStarPattern
    {
        public static void Startrectangle()
        {
            int len = 7, width = 7;
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= len; j++)
                {
                    if (i == 1 || i == width || j == 1 || j == len)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
