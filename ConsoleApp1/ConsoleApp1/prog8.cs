using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MultTable
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}\n",num1,i,num1*i );
            }
            Console.ReadKey();
        }
    }
}
