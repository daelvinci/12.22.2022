using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    internal class HasNotDigitException:Exception
    {
        public HasNotDigitException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
