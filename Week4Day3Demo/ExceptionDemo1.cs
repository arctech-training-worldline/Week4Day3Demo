
using System;

namespace Week4Day3Demo
{
    internal class ExceptionDemo1
    {
        internal static void Demo()
        {
            Console.Write("Enter a number: ");
            var s = Console.ReadLine();

            try
            {
                int num = int.Parse(s);
                Console.WriteLine($"You have entered a valid int number {num}");
            }
            catch (FormatException formatException)
            {
                Console.WriteLine("Invalid integer number!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Message={formatException.Message}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"StackTrace={formatException.StackTrace}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"InnerException={formatException.InnerException}");
                Console.WriteLine("--------------------------------------");

            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine("You entered too large number!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Message={overflowException.Message}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"StackTrace={overflowException.StackTrace}");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"InnerException={overflowException.InnerException}");
                Console.WriteLine("--------------------------------------");
            }
            catch (Exception)
            {
                Console.WriteLine("Some other exception happened!");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
