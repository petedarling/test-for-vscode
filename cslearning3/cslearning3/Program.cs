using System;

namespace cslearning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz simulater 1");
            for (int i = 1; i <= 100; i++)
            {               
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.Write($"{i} ");
            }

            Console.WriteLine(new String('-', 80));
            Console.WriteLine("FizzBuzz simulater 2 (shorthand)");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("{0:#;}{1:;;Fizz}{2:;;Buzz}", i % 3 * i % 5 == 0 ? 0 : i, i % 3, i % 5);
            }

            Console.WriteLine(new String('-', 80));
            Console.WriteLine("FizzBuzz interactive!");
            string input = "";
            int j;
            while (input!="exit") {
                Console.WriteLine("Enter a number or type exit to end...");
                input = Console.ReadLine();

                if (int.TryParse(input, out j))
                {
                    Console.WriteLine("{0:#;}{1:;;Fizz}{2:;;Buzz}", j % 3 * j % 5 == 0 ? 0 : j, j % 3, j % 5);
                }
                else {
                    Console.WriteLine("Invalid number");
                }
            }
        }
    }
}
