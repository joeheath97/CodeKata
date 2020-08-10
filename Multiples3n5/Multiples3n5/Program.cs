using System;
using System.Linq;

namespace Multiples3n5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(totalMuliples(10));
        }

        public static int totalMuliples(int value)
        {

            return Enumerable.Range(0, value).Where(n => n % 3 == 0 || n % 5 == 0).Sum();
        }
    }
}
