using System;

namespace Fancy_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Fancy Consonle Calculator");

            string response1 = "";
            string response2 = "";
            decimal num1 = 0;
            decimal num2 = 0;

            do
            {
                Console.WriteLine("Enter a number.");
                response1 = Console.ReadLine();
                if(decimal.TryParse(response1, out num1) == true)
                {
                    break;
                } else
                {
                    Console.WriteLine($"{response1} is not a number");
                }
            } while(decimal.TryParse(response1, out num1) == false );

            do
            {
                Console.WriteLine("Enter another number.");
                response2 = Console.ReadLine();
                if (decimal.TryParse(response2, out num2) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{response2} is not a number");
                }
            } while (decimal.TryParse(response2, out num2) == false);

            var result = Sum(num1, num2);
            Console.WriteLine($"Result: {result}.");
            Console.ReadLine();

            static int Sum(decimal num1, decimal num2)
            {
                return (int)(num1 + num2);
            }

        }

    }
}

//            bool parseSuccess = int.TryParse(response1, out int num1);

            //            if (parseSuccess)
            //            {

            //            }
            //            else
            //            {
            //                Console.WriteLine("This is not a number!");
            //                Console.WriteLine("Enter a number.");
            //            }
            //            string num1AsString = Console.ReadLine();


            //            Console.WriteLine("Enter a second number and I will add it to the first");
            //            var num2AsString = Console.ReadLine();

            //            bool parseSuccess2 = int.TryParse(num2AsString, out int num2);

            //            if (parseSuccess2)
            //                Console.WriteLine($"You entered: {num2}");
            //            else
            //                Console.WriteLine("This is not a number!");

            //            var result = Sum(num1, num2);
            //            Console.WriteLine($"Results: {result}");

            //            Console.WriteLine("Press enter to close the window");
    
