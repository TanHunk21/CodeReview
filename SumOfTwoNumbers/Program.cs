using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user to enter two numbers and prints out the sum of these numbers*/
            Console.WriteLine("Enter your first number: ");
            string UserInput = Console.ReadLine();
            int num1 = Int32.Parse(UserInput);
            Console.WriteLine("Enter your second number: ");
            UserInput  = Console.ReadLine();
            int num2 = Int32.Parse(UserInput );

            int result = num1 * num2;

            Console.WriteLine($"{num1} + {num2} = {result}");

        }
    }
}
