using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    internal class PasswordLengthException:Exception
    {
        public PasswordLengthException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
