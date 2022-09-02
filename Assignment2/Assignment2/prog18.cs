using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class RightTriangleIncrement
    {
        public static void Main1()
        {
            Console.Write("Enter the number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++,k++)
                    Console.Write("{0} ",k);
                Console.WriteLine("");
            }
        }
    }
}
