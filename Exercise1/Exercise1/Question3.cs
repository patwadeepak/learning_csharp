using System;

namespace Exercise1
{
    class Question3
    {
        public static void Run()
        {
            Console.Write("Please enter width and height of an image separated by space: ");
            string[] str = Console.ReadLine().Split(' ');
            var dimension = new int[2];
            for (int i = 0; i < 2; i++) {
                dimension[i] = int.Parse(str[i]);
            }
            if (dimension[0] >= dimension[1]) {
                Console.WriteLine("The image is a landscape.");
            }
            else
            {
                Console.WriteLine("The image is a portrait.");
            }
        }
    }
}
