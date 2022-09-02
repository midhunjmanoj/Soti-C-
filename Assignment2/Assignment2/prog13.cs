using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class MultiTableVer
    {
        public static void Main1()
        {
            Console.WriteLine("Input the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            string ans = "";
            for (int i = 1; i <= 10; i++)
            {
                int a = i * number;
                ans = ans + i + " * " + number + " = " + a + ", ";
               // Console.Write("{0} * {1} = {2}, \r", number, i, i * number);
            }
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
