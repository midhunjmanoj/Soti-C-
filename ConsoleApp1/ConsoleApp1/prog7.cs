using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StdOperations
    {
        public static void Main1()
        {
            Console.WriteLine("Input the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} +  {1} = {2}\n" +
                "{0} - {1} = {3}\n" +
                "{0} *  {1} = {4}\n" +
                "{0} / {1} = {5}\n" +
                "{0} mod {1} = {6}\n",
                num1, num2, num1 + num2, num1 - num2, num1 * num2, num1 / num2, num1 % num2
                );
            Console.ReadKey();

        }

    }
}
