﻿using System;

namespace Exercise1
{
    class Question1
    {
        public static void Run()
        {
            Console.WriteLine("Enter a number between 1 to 10.");
            var input = int.Parse(Console.ReadLine());
            if (input >= 0 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
