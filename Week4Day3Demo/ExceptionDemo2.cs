
using System;

namespace Week4Day3Demo
{
    internal class ExceptionDemo2
    {
        internal static void Demo()
        {
            Console.Write("Enter a number: ");
            var s = Console.ReadLine();

            Console.Write("Enter a denominator: ");
            var denominator = Console.ReadLine();

            try
            {
                int num = int.Parse(s);
                Console.WriteLine($"You have entered a valid int number {num}");

                int answer = num / int.Parse(denominator);
                Console.WriteLine($"Answer => {num}/{denominator} = {answer}");
            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Invalid integer number! => {formatException.Message}");
            }
            catch (OverflowException overflowException)
            {
                Console.WriteLine($"You entered too large number! => {overflowException.Message}");
            }
            catch (ArithmeticException divideByZeroException)
            {
                Console.WriteLine($"An divideByZeroException exception occurred! => {divideByZeroException.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Some other exception happened! => {exception.Message}");
            }
        }
    }
}
