using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    internal class HasNotUpperException:Exception
    {
        public HasNotUpperException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
