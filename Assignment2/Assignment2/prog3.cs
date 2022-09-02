using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class positiveNegative
    {
        public static void Main1()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
                Console.WriteLine("{0} is a negative number", number);
            else
                Console.WriteLine("{0} is a positive number", number);
            Console.ReadKey();
        }
    }
}
