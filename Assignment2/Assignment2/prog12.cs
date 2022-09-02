using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class MultiTable
    {
        public static void Main1()
        {
            Console.WriteLine("Input the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number,i,i*number);
            }
            Console.ReadKey();
        }
    }
}
