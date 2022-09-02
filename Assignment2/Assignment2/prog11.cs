using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class CubeN
    {
        public static void Main1()
        {
            Console.WriteLine("Input number of terms: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                Console.WriteLine("Number is : {0} and cube of the {0} is : {1}", i, i * i * i);
            }
            Console.ReadKey();
        }
    }
}
