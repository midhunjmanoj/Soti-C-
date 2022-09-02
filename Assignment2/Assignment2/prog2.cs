using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class OddEven
    {
        public static void Main1()
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("{0} is an even number", number);
            else
                Console.WriteLine("{0} is an odd number ", number);
            Console.ReadKey();
        }
    }
}
