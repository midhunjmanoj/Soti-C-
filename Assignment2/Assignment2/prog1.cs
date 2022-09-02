using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class CheckEqual
    {

        public static void Main1()
        {
            int num1, num2;
            Console.WriteLine("Input 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2st number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("{0} and {1} are equal", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} and {1} are Not equal", num1, num2);
            }
            Console.ReadKey();

        }
    }
}
