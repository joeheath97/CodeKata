using System;
using System.Collections.Generic;

namespace DoubleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("Hello World!"));
        }

        public static string DoubleChar(string s)
        {
            var doubleChar = new List<char>();


            foreach (char c in s)
            {
                doubleChar.Add(c);
                doubleChar.Add(c);
            }

            return String.Join("", doubleChar);
        }
    }
}
