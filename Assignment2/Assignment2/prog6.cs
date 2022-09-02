using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class RangeSet
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
                Console.WriteLine("The value of n = 1");
            else if (number == 0)
                Console.WriteLine("The value of n = 0");
            else
                Console.WriteLine("The value of n = -1");
            Console.ReadKey();

        }
    }
}
