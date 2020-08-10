using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            vowelCount("Hello World!");

        }

        public static int vowelCount(string sentence)
        {
            var charactersArray = sentence.ToCharArray();

            var vowelRegex = new Regex("[a,e,i,o,u]");

            var count = 0;

            foreach(var c in charactersArray)
            {
                if (vowelRegex.IsMatch(c.ToString()) == true)
                {
                    count++;
                }
            }

            Console.WriteLine("[{0}]", string.Join("," , charactersArray));

            Console.WriteLine(count);

            return count;
        } 
    }
}
