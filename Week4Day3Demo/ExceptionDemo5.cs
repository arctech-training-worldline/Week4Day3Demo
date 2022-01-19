using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day3Demo
{
    class AdvancedUser
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    internal class ExceptionDemo5
    {
        internal static void Demo()
        {
            try
            {
                var user = GetUserInfo();
                Console.WriteLine($"AdvancedUser name:{user.Name} and age:{user.Age}");
            }
            catch (MyLearningAgeOutOfRangeException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (FormatException e2)
            {
                Console.WriteLine(e2.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Some other error occured! {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally we can do something here!!!");
            }
        }

        static AdvancedUser GetUserInfo()
        {
            var user = new AdvancedUser();
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            var ageText = Console.ReadLine();

            GetFromDatabase();

            user.Age = int.Parse(ageText);

            if (user.Age < 13 || user.Age > 75)
                throw new MyLearningAgeOutOfRangeException("You can continue only if you are between 13 and 75 years old");

            return user;
        }

        private static void GetFromDatabase()
        {
            JumpHigh();
        }

        private static void JumpHigh()
        {
            Console.Write("Enter a denominator: ");
            var denominator = int.Parse(Console.ReadLine());

            Console.WriteLine($"100/{denominator} = {100 / denominator}");
        }
    }
}
