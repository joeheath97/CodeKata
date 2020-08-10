using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTheOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 2, 8, 1, 4 };
            SortArray(array);
        }

    
        public static int[] SortArray(int[] array)
        {
            var oddList = new List<int>();

            for(var i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 != 0)
                {
                    oddList.Add(array[i]);
                    array[i] = -1;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));

            oddList.Sort();

            Console.WriteLine("[{0}]", string.Join(", ", oddList));

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] == -1)
                {
                    array[i] = oddList.First();

                        oddList.RemoveAt(0);
  
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));

            return array;
        }
    }
}
