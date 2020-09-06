using System;
using System.Linq;

namespace CreatePhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0}));
        }

        public static string CreatePhoneNumber(int [] numbers)
        {          
            return string.Format("({0}{1}{2}) {3}{4}{5} - {6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
        }
    }
}
