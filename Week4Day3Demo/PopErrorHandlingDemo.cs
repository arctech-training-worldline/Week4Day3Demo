using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day3Demo
{
    class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    internal class PopErrorHandlingDemo
    {
        internal static void Demo()
        {
            var user = GetUserInfo(out var status);

            if (status == 0)
                Console.WriteLine($"User name:{user.Name} and age:{user.Age}");
            else if (status == 1)
                Console.WriteLine("Please enter a age between 13 and 75 only");
            else if (status == 2)
                Console.WriteLine("You have entered an invalid age. Please enter a number only");
        }

        static User GetUserInfo(out int status)
        {
            var user = new User();
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var ageText = Console.ReadLine();

            int s = GetFromDatabase();
            if (s != 0)
            {
                status = s;
                return null;
            }

            if (int.TryParse(ageText, out var age))
            {
                if (age < 13 || age > 75)
                    status = 1;
                else
                {
                    status = 0;
                    user.Age = age;
                }
            }
            else
                status = 2;

            return user;
        }

        private static int GetFromDatabase()
        {
            int status = JumpHigh();

            return status;
        }

        private static int JumpHigh()
        {
            return 1;
        }
    }
}
