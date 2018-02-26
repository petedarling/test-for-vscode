using System;
using static System.Convert;

/**
 * Purpose: Demo use of Exceptions, note we would noramlly and use TryParse in 
 * most cases. This is only for learning Exception handling.
 */
namespace cslearning4
{
    class Program
    {
        static Boolean ConvertStr(string input, out byte sum1)
        {
            sum1 = 0;
            try
            {
                sum1 = ToByte(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number, cannot continue!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is too big or too small, cannot continue!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}, cannot continue!");
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 0 and 255:");
            string num1 = Console.ReadLine();
            byte sum1 = 0;
            byte sum2 = 0;
            if (ConvertStr(num1, out sum1))
            {
                Console.WriteLine("Enter another number between 0 and 255:");
                string num2 = Console.ReadLine();
                if (ConvertStr(num2, out sum2))
                {
                    try
                    {
                        int sum = sum1 / sum2;
                        Console.WriteLine($"{num1} / {num2} = {sum}");
                    }                   
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.GetType()} says {ex.Message}");
                    }
                }
            }
       }
    }
}
