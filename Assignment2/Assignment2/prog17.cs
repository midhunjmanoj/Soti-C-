using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class RightTriangleRepeat
    {
        public static void Main1()
        {
            Console.Write("Enter the number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("{0}",i+1);
                Console.WriteLine("");
            }
        }
    }
}
