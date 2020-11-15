using System;

namespace Exercise1
{
    class Question2
    {
        public static void Run() {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.Write("Please enter another number: ");
            int input2 = int.Parse(Console.ReadLine());
            if (input == input2) {
                Console.WriteLine("{0} is equal to {1}", input, input2);
            }
            else if (input > input2)
            {
                Console.WriteLine("{0} is greater than {1}", input, input2);
            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", input2, input);
            }

        }
    }
}
