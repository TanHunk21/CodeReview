using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/
            Console.WriteLine("Enter your number: ");

            string UserInput = Console.ReadLine();
            int Number = Int32.Parse(UserInput);
            if( Number > 0)
            {
                Console.WriteLine("The number is negative.");
            } else if(Number <0)
            {
                Console.WriteLine("The number is positive.");
            }

        }
    }
}
