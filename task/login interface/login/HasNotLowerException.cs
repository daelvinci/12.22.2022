using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    internal class HasNotLowerException:Exception
    {
        public HasNotLowerException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
