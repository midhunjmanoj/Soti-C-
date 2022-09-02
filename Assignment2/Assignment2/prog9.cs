using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class FindQuadrant
    {
        public static void Main1()
        {   
         
            Console.WriteLine("Enter the x coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
                Console.WriteLine("The point is in 1st quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine("The point is in 2nd quadrant");
            else if(x < 0 && y < 0)
                Console.WriteLine("The point is in 3rd quadrant");
            else
                Console.WriteLine("The point is in 4th quadrant");
            Console.ReadKey();


        }
    }
}
