using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class LargestThree
    {   
        public static void Main1()
        {
            Console.WriteLine("Enter the 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd number:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
                Console.WriteLine("The 1st Number is the greatest among three");
            else if(num2>num1 && num2>num3)
                Console.WriteLine("The 2nd Number is the greatest among three");
            else
                Console.WriteLine("The 3rd Number is the greatest among three");
            Console.ReadKey();

        }
        
    }
}
