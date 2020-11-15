using System;

namespace Exercise1
{
    class Question4
    {
        public static void Run()
        {
            Console.Write("Kindly enter the Speed Limit: ");
            var speedLimit = decimal.Parse(Console.ReadLine());
            Console.Write("Enter the Speed of the car: ");
            var carSpeed = decimal.Parse(Console.ReadLine());
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                decimal difference = carSpeed - speedLimit;
                int demeritPoints = (int)difference / 5;
                if (demeritPoints > 12) {
                    Console.WriteLine("License Suspended");
                }
                else
                    Console.WriteLine("Demerit Points: {0}", demeritPoints);
            }
        }
    }
}
