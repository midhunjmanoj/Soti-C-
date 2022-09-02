using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class OddSum
    {
        public static void Main1()
        {

            Console.WriteLine("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The first {0} odd numbers: ",n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0} ",2*i+1);

            }
            Console.WriteLine("The sum of first {0} odd numbers is : {1} ",n,n*n);
        }
    }
}
