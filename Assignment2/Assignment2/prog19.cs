using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class RightTriangle1
    {
        public static void Main1()
        { int i, j, t = 1,k;
            Console.Write("Enter the number : ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int spc = rows + 4 - 1;
            for (i = 1; i <= rows; i++)
            {
                for (k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= i; j++)
                    Console.Write("{0} ", t++);
                Console.Write("\n");
                spc--;
            }
        }
    }
}
