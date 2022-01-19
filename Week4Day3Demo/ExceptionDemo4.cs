using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day3Demo
{
    internal class ExceptionDemo4
    {
        internal static void Demo()
        {
            try
            {
                Console.WriteLine($"Square root of 25 is {Sqrt(25)}");
                Console.WriteLine($"Square root of -25 is {Sqrt(-25)}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Error found: {e.Message}");
            }
        }

        internal static double Sqrt(double num)
        {
            if (num < 0)
                throw new ArgumentOutOfRangeException("-ve number cannot be square rooted!");

            return Math.Sqrt(num);
        }

        /*
         // This is how you have to write code if try catch Exception handling was not available
         // Messy code to handle errors
        internal static void Demo()
        {
                Console.WriteLine($"Square root of 25 is {Sqrt(25, out var status)}");
                if(status != 0)
                    Console.Write("Invalid number");

                Console.WriteLine($"Square root of -25 is {Sqrt(-25, out var status2)}");
                if (status2 != 0)
                    Console.Write("Invalid number");
        }

        internal static double Sqrt(double num, out int status)
        {
            if (num < 0)
            {
                status = 1;
                return 0;
            }
            
            status = 0;
            return Math.Sqrt(num);
        }
        */
    }
}
