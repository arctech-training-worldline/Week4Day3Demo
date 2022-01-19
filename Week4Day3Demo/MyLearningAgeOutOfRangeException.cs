using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Day3Demo
{
    internal class MyLearningAgeOutOfRangeException : ApplicationException
    {
        

        public MyLearningAgeOutOfRangeException(string message) : base(message)
        {
            
        }
    }
}
