using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EvaluateExp
    {
        public static void Main()
        {
            int x, y, z;
            Console.WriteLine("Enter value of x :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y :");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of z :");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x+y).z is {3} and x.y + y.z is {4}", x, y, z, (x + y) * z, x * y + y * z);
            Console.ReadKey();
        }
    }
}
