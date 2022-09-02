using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PrintAverage
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the first numbers; ");
            float num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second numbers; ");
            float num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third numbers; ");
            float num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth numbers; ");
            float num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The average of {0} , {1} , {2} , {3} is : {4}", num1, num2, num3, num4, (num1 + num2 + num3 + num4) / 4);
            Console.ReadKey();


        }
        

    }
}
