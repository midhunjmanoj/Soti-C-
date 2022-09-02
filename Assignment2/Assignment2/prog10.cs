using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Eligibilty
    {
        public static void Main1()
        {
            Console.WriteLine("Maths mark: ");
            int mathematics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Physics mark: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chemistry mark: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            int total = mathematics + physics + chemistry;
            if (mathematics >= 65 && physics >= 55 && chemistry >= 50 && total >= 180) 
            Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");
            Console.ReadKey();
        }
    }
}
