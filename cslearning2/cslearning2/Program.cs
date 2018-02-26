//using System;
using static System.Convert;
using static System.Console;

namespace cslearning2
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Banker's Rounding
             * 
             * Note that the rule for rounding in C# is subtly different. 
             * It will round up if the decimal part is .5 or higher and the 
             * nondecimal part is odd, but it will round down if the nondecimal 
             * part is even. It always rounds down if the decimal part is less 
             * than .5
             */
            WriteLine("Round tester");
            WriteLine("Enter number to round or exit");
            string res = ReadLine();
            double g;
            int h;
            while (res!="exit") {
                if (double.TryParse(res, out g)) {
                    h = ToInt32(g);
                    WriteLine($" g is {g} and h is {h}");
                }
                else {
                    WriteLine("invalid input, try again!");
                }
                WriteLine("Enter number to round or exit");
                res = ReadLine();
            }
        }
    }
}
