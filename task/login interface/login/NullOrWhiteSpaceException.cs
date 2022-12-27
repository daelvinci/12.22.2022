using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    internal class NullOrWhiteSpaceException:Exception
    {
        public NullOrWhiteSpaceException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
