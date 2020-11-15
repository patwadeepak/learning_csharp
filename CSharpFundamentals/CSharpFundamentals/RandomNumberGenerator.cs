using System;

namespace CSharpFundamentals
{
    class RandomNumberGenerator
    {
        public static void Run()
        {
            Console.Write("Enter the length of password needed: ");
            var length = int.Parse(Console.ReadLine());

            var random = new Random();
            int charNum;
            char character;
            for(var i=0; i<length; i++)
            {
                charNum = random.Next(0, 63);
                
                if (charNum < 26)
                {
                    character = (char)(charNum + (int)'a');
                    Console.Write(character);
                }
                else if (charNum < 52)
                {
                    character = (char)(charNum - 26 + (int)'A');
                    Console.Write(character);
                }
                else
                {
                    charNum = charNum - 52;
                    Console.Write(charNum);
                }
            }
            Console.WriteLine();
        }
    }
}
