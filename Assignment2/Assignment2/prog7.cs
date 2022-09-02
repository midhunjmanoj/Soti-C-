using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class catHeight
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if (height < 150)
                Console.WriteLine("The person is Dwarf");
            else if (height >= 150 && height < 180)
                Console.WriteLine("The person is Normal");
            else
                Console.WriteLine("The person is Tall");
            Console.ReadKey();
        }
    }
}
