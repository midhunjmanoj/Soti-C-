using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Vote
    {
        public static void Main1()
        {
            Console.WriteLine("Enter the your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age<18)
                Console.WriteLine("Sorry!, you are not eligible to cast your vote");
            else
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            Console.ReadKey();

        }
    }
}

