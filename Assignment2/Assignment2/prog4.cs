using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class LeapYear
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0)
                Console.WriteLine("{0} is a Leap Year", year);
            else
                Console.WriteLine("{0} is not a Leap Year", year);
            Console.ReadKey();

        }
    }
}
