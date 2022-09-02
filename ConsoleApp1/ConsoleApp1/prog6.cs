using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class ThreeMultiplication
    {
        public static void Main1()
        {
           
            Console.WriteLine("Input the first number to multiply: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second number to multiply: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*{1}*{2} = {3}", num1, num2, num3, num1 * num2 * num3);
            Console.ReadKey();
        }
    }
}
