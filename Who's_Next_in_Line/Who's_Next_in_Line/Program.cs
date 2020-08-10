using System;
using System.Collections.Generic;

namespace Who_s_Next_in_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] queue = { "Sally", "Jim", "Bob", "Kate" };
            Console.WriteLine(NextPersonInQueue(queue, 3));
        }

        public static string NextPersonInQueue(string[] queue, int position)
        {

            return queue[position - 1];
        }
    }
}
