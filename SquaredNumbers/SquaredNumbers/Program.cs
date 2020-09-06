using System;
using System.Linq;

namespace SquaredNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquaredNumber(9119));
        }

        public static int SquaredNumber(int n)
        {

            // LINQ : splits string into char array and converts them to doubles
            // Char needs to be coverted to string inorder to be converted to double
            var digets = n.ToString().Select(x => double.Parse(x.ToString()));

            var result = "";

            /*
             * loops through char array 
             * 
             * number to the power of
             * 
             * and then toString to concate
             * 
             **/
            foreach(var i in digets)
            {
                var squardedNumber = Math.Pow(i, 2);
                result += squardedNumber.ToString();
            }

            Console.WriteLine(int.Parse(result));

            return int.Parse(result);
        }
    }
}
