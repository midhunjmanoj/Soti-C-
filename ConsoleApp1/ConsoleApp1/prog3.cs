using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DivideNumbers
    {
        public static void Main1()
        {
            Console.WriteLine("Enter two numbers :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of {0} / {1} is {2}",num1, num2, num1/num2);
            Console.ReadKey();
        }
    }
}
