using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems_4B
{
    internal class ReverseString
    {
        public static string Reverse(string Input)
        {
            char[] charArray = Input.ToCharArray();
            string reversedString = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)// Iterating the each character from right to left
            {
                reversedString += charArray[i];
            }
            Console.WriteLine(reversedString);
            return reversedString;
        }
    }
}
