using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day3Demo
{
    internal class ExceptionDemo3
    {
        internal static void Demo()
        {
            try
            {
                Jump();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Jump()
        {
            Climb();
        }

        private static void Climb()
        {
            try
            {
                Show();
            }
            catch (Exception)
            {
                Console.WriteLine("********************************************");
                //throw new BadImageFormatException("I am confusing my user by throwing some unrelated exception!!");
                // You can throw any exception, however in this case,
                // just throw keyword is sufficient as it will rethrow, the existing exception which will bubble up
                // the function calling stack
                throw;
            }
        }

        private static void Show()
        {
            Console.Write("Enter the denominator: ");
            var denominator = int.Parse(Console.ReadLine());
            Console.WriteLine($"Answer={100 / denominator}");
        }
    }
}
