using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Question1
    {
        public static void RunQuestion1()
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
