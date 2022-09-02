using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TwoSum
    {
        public static void Main1()
        {
            float num1,num2;
            Console.WriteLine("Enter two Numbers:");
            num1 =Convert.ToInt32( Console.ReadLine());
            num2 = num1+ Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum is :"+ num2);
            Console.ReadKey();

        }
    }
}
