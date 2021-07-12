using System;

namespace Fancy_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Consonle Calculator");

            Console.WriteLine("Enter a number.");
            var response1 = Console.ReadLine();

            int num1;

            bool parseSuccess = int.TryParse(response1, out num1);

            if (parseSuccess)
            {
                Console.WriteLine($"You entered: {num1}");

            }
            else
            {
                Console.WriteLine("This is not a number!");
                Console.WriteLine("Enter a number.");
            }
            string num1AsString = Console.ReadLine();


            Console.WriteLine("Enter a second number and I will add it to the first");
            var num2AsString = Console.ReadLine();

            int num2;
            bool parseSuccess2 = int.TryParse(num2AsString, out num2);

            if (parseSuccess2)
                Console.WriteLine($"You entered: {num2}");
            else
                Console.WriteLine("This is not a number!");

            var result = Sum(num1, num2);
            Console.WriteLine("Result: " + result);
        }

        static int Sum(int num1, int num2) => num1 + num2;
    }
}
