
using System;
using static System.Console;

namespace cslearning1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpWindow();
            DisplayTypes();
        }

        static void DisplayTypes()
        {
            WriteTitle("C# Types");
            WriteTypesHeader();

            /**
             * Table body
             */
            WriteTypeLine("sbyte", sizeof(sbyte), sbyte.MinValue.ToString(),
                          sbyte.MaxValue.ToString());
            WriteTypeLine("byte", sizeof(byte), byte.MinValue.ToString(),
                          byte.MaxValue.ToString());
            WriteTypeLine("short", sizeof(short), short.MinValue.ToString(),
                          short.MaxValue.ToString());
            WriteTypeLine("ushort", sizeof(ushort), ushort.MinValue.ToString(),
                          ushort.MaxValue.ToString());
            WriteTypeLine("int", sizeof(int), int.MinValue.ToString(),
                          int.MaxValue.ToString());
            WriteTypeLine("uint", sizeof(uint), uint.MinValue.ToString(),
                          uint.MaxValue.ToString());
            WriteTypeLine("long", sizeof(long), long.MinValue.ToString(),
                          long.MaxValue.ToString());
            WriteTypeLine("ulong", sizeof(ulong), ulong.MinValue.ToString(),
                          ulong.MaxValue.ToString());
            WriteTypeLine("float", sizeof(float), float.MinValue.ToString(),
                          float.MaxValue.ToString());
            WriteTypeLine("double", sizeof(double), double.MinValue.ToString(),
                          double.MaxValue.ToString());
            WriteTypeLine("decimal", sizeof(decimal), decimal.MinValue.ToString(),
                          decimal.MaxValue.ToString());
            
            WriteTypesFooter();
        }

        public static void WriteFullDashedLine()
        {
            WriteLine(new String('-', 80));
        }

        public static void WriteTypesFooter()
        {
            WriteFullDashedLine();       
            SetConsoleColour("black", "yellow");
            WriteLine("{0, 80}", "pAd - Learning C# 7 - 2018");
            ResetColor();
        }

        public static void WriteTypesHeader()
        {
            SetConsoleColour("yellow", "red");
            WriteFullDashedLine();
            WriteLine("{0,-8} {1,-18} {2,17} {3,34}",
                              "Type", "Bytes(s) of memory", "Min", "Max");
            WriteFullDashedLine();
        }

        public static void WriteTitle(string title)
        {
            SetConsoleColour("red", "yellow");
            WriteLine("{0, -80}", title);
        }

        public static void WriteTypeLine(string typeName, int sizeOfType, 
                                         string minValue, string maxValue)
        {
            WriteLine("{0,-8} {1,-2} {2,33} {3,34}", typeName,
                      sizeOfType, minValue, maxValue);
        }

        public static void SetConsoleColour(string fgColour, string bgColour)
        {
            ForegroundColor = (ConsoleColor)
                Enum.Parse(typeof(ConsoleColor), fgColour, true);
            BackgroundColor = (ConsoleColor)
                Enum.Parse(typeof(ConsoleColor), bgColour, true);
        }

        public static void SetUpWindow()
        {
            /**
             * For Windows we make sure console is 80 width
             * for other platforms we hope it is 80 or more!!
             */
            try
            {
                WindowWidth = 80;
                if (WindowHeight < 25)
                {
                    WindowHeight = 25;
                }
            }
            catch (PlatformNotSupportedException)
            {
                //WriteLine("Sorry this platform does not support changing the 
                // size of a console window.");
            }
        }
    }
}
